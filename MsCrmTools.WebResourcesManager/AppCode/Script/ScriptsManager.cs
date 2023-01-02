using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Entity = Microsoft.Xrm.Sdk.Entity;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public class ScriptsManager
    {
        private readonly IOrganizationService _service;
        private readonly BackgroundWorker _worker;
        private List<EntityMetadata> _emds;

        public ScriptsManager(IOrganizationService service, BackgroundWorker worker)
        {
            this._service = service;
            this._worker = worker;
            Scripts = new List<Script>();
        }

        public List<Entity> Forms { get; } = new List<Entity>();
        public List<Entity> HomePageGrids { get; } = new List<Entity>();
        public List<EntityMetadata> Metadata { get; private set; }
        public List<Script> Scripts { get; }
        public int UserLcid { get; private set; }
        public List<Entity> Views { get; } = new List<Entity>();

        public void Find(List<Entity> solutions, bool loadManagedEntities, Version crmVersion)
        {
            _worker.ReportProgress(0, "Loading User language...");
            GetCurrentUserLcid();

            _worker.ReportProgress(0, "Loading Entities metadata...");
            _emds = GetEntities(solutions, loadManagedEntities);
            Metadata = _emds.Where(x => x.DisplayName.UserLocalizedLabel != null).ToList();

            _worker.ReportProgress(0, "Loading Forms Scripts...");
            LoadScripts(Metadata, crmVersion.Major >= 6);

            _worker.ReportProgress(0, "Loading Views Icon Scripts...");
            LoadViews(Metadata);

            if (crmVersion >= new Version(8, 2, 0, 0))
            {
                _worker.ReportProgress(0, "Loading Homepages Scripts...");
                LoadCustomControls(Metadata);
            }
        }

        public void UpdateForms(List<Script> scripts)
        {
            var uiItems = scripts.Select(s => s.UiItem).Distinct();

            var bulk = new ExecuteMultipleRequest
            {
                Requests = new OrganizationRequestCollection(),
                Settings = new ExecuteMultipleSettings
                {
                    ReturnResponses = true,
                    ContinueOnError = true
                }
            };

            foreach (var uiItem in uiItems)
            {
                var attribute = uiItem.LogicalName == "systemform" ? "formxml" : uiItem.LogicalName == "savedquery" ? "layoutxml" : "eventsxml";
                var updateAttribute = uiItem.LogicalName == "systemform" ? "updatedformxml" : uiItem.LogicalName == "savedquery" ? "updatedlayoutxml" : "updatedeventsxml";

                if (!uiItem.Contains(updateAttribute))
                    continue;

                var formToUpdate = new Entity(uiItem.LogicalName)
                {
                    Id = uiItem.Id,
                    Attributes =
                    {
                        {attribute, uiItem[updateAttribute]}
                    }
                };

                bulk.Requests.Add(new UpdateRequest { Target = formToUpdate });
            }

            bulk.Requests.Add(new PublishXmlRequest
            {
                ParameterXml = $"<importexportxml><entities><entity>{string.Join("</entity><entity>", scripts.Select(s => s.EntityLogicalName))}</entity></entities><nodes/><securityroles/><settings/><workflows/></importexportxml>"
            });

            var bulkResponse = (ExecuteMultipleResponse)_service.Execute(bulk);

            foreach (var response in bulkResponse.Responses)
            {
                if (response.Fault == null)
                {
                    foreach (var script in scripts.Where(s => s.UiItem.Id == (bulk.Requests[response.RequestIndex] as UpdateRequest)?.Target.Id))
                    {
                        script.Parameters = script.NewParameters ?? script.Parameters;
                        script.Enabled = script.NewEnabled ?? script.Enabled;
                        script.MethodCalled = script.NewMethodCalled ?? script.MethodCalled;
                        script.PassExecutionContext = script.NewPassExecutionContext ?? script.PassExecutionContext;
                        script.Library = script.NewLibrary ?? script.Library;

                        script.NewParameters = null;
                        script.NewEnabled = null;
                        script.NewMethodCalled = null;
                        script.NewPassExecutionContext = null;
                        script.NewLibrary = null;
                        script.NewOrder = null;

                        script.UpdateErrorMessage = null;
                        if (script.UiItem.Contains(script.ItemUpdateAttribute))
                        {
                            script.UiItem[script.ItemAttribute] = script.UiItem[script.ItemUpdateAttribute];
                            script.UiItem.Attributes.Remove(script.ItemUpdateAttribute);
                        }
                    }
                }
                else
                {
                    foreach (var script in scripts.Where(s =>
                        s.UiItem.Id == (bulk.Requests[response.RequestIndex] as UpdateRequest)?.Target.Id))
                    {
                        script.UpdateErrorMessage = response.Fault.Message;
                    }
                }
            }

            if (bulkResponse.IsFaulted)
            {
                throw new Exception("At least one form could not be updated. Select a row in error and click on button \"Show Error Message\" to read a detailed error");
            }
        }

        private void GetCurrentUserLcid()
        {
            var user = (WhoAmIResponse)_service.Execute(new WhoAmIRequest());

            var userSettings = _service.RetrieveMultiple(new QueryByAttribute("usersettings")
            {
                ColumnSet = new ColumnSet("uilanguageid"),
                Attributes = { "systemuserid" },
                Values = { user.UserId },
            }).Entities.First();

            UserLcid = userSettings.GetAttributeValue<int>("uilanguageid");
        }

        private List<EntityMetadata> GetEntities(List<Entity> solutions, bool loadManagedEntities)
        {
            if (solutions.Count > 0)
            {
                var components = _service.RetrieveMultiple(new QueryExpression("solutioncomponent")
                {
                    ColumnSet = new ColumnSet("objectid"),
                    NoLock = true,
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("solutionid", ConditionOperator.In,
                                solutions.Select(s => s.Id).ToArray()),
                            new ConditionExpression("componenttype", ConditionOperator.Equal, 1)
                        }
                    }
                }).Entities;

                var list = components.Select(component => component.GetAttributeValue<Guid>("objectid"))
                    .ToList();

                if (list.Count > 0)
                {
                    EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                    {
                        Criteria = new MetadataFilterExpression(LogicalOperator.Or),
                        Properties = new MetadataPropertiesExpression
                        {
                            AllProperties = false,
                            PropertyNames = { "DisplayName", "LogicalName", "Attributes", "ObjectTypeCode" }
                        },
                        AttributeQuery = new AttributeQueryExpression
                        {
                            // Récupération de l'attribut spécifié
                            Properties = new MetadataPropertiesExpression
                            {
                                AllProperties = false,
                                PropertyNames = { "DisplayName", "LogicalName" }
                            }
                        }
                    };

                    list.ForEach(id =>
                    {
                        entityQueryExpression.Criteria.Conditions.Add(new MetadataConditionExpression("MetadataId", MetadataConditionOperator.Equals, id));
                    });

                    RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                    {
                        Query = entityQueryExpression,
                        ClientVersionStamp = null
                    };

                    var response = (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

                    return response.EntityMetadata.ToList();
                }

                return new List<EntityMetadata>();
            }
            else
            {
                EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                {
                    Criteria = new MetadataFilterExpression(LogicalOperator.Or)
                    {
                        Conditions =
                        {
                            new MetadataConditionExpression("IsCustomizable", MetadataConditionOperator.Equals, true),
                        }
                    },
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = false,
                        PropertyNames = { "DisplayName", "LogicalName", "Attributes", "ObjectTypeCode" }
                    },
                    AttributeQuery = new AttributeQueryExpression
                    {
                        // Récupération de l'attribut spécifié
                        Properties = new MetadataPropertiesExpression
                        {
                            AllProperties = false,
                            PropertyNames = { "DisplayName", "LogicalName" }
                        }
                    }
                };

                if (!loadManagedEntities)
                {
                    entityQueryExpression.Criteria.Conditions.Add(
                        new MetadataConditionExpression("IsManaged", MetadataConditionOperator.Equals, false));
                }

                RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                {
                    Query = entityQueryExpression,
                    ClientVersionStamp = null
                };

                var response = (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

                return response.EntityMetadata.ToList();
            }
        }

        private void LoadCustomControls(List<EntityMetadata> emds)
        {
            var ccs = _service.RetrieveMultiple(new QueryExpression("customcontroldefaultconfig")
            {
                ColumnSet = new ColumnSet("eventsxml", "primaryentitytypecode"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("primaryentitytypecode", ConditionOperator.In, emds.Select(e => e.ObjectTypeCode??0).ToArray()),
                    }
                }
            });

            var homePageGrids = ccs.Entities.ToList();
            HomePageGrids.AddRange(homePageGrids);
        }

        private void LoadScripts(List<EntityMetadata> emds, bool supportFormActivationState)
        {
            var query = new QueryExpression("systemform")
            {
                ColumnSet = new ColumnSet("name", "formxml", "type", "objecttypecode"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("objecttypecode", ConditionOperator.In,
                            emds.Select(e => e.ObjectTypeCode ?? 0).ToArray())
                    }
                }
            };

            if (supportFormActivationState)
            {
                query.ColumnSet.AddColumn("formactivationstate");
            }

            var forms = _service.RetrieveMultiple(query).Entities.ToList();
            Forms.AddRange(forms);
        }

        private void LoadViews(List<EntityMetadata> emds)
        {
            var query = new QueryExpression("savedquery")
            {
                ColumnSet = new ColumnSet("layoutxml", "name", "returnedtypecode"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("returnedtypecode", ConditionOperator.In, emds.Select(e => e.LogicalName).ToArray())
                    }
                }
            };

            var views = _service.RetrieveMultiple(query).Entities.ToList();
            Views.AddRange(views);
        }
    }
}