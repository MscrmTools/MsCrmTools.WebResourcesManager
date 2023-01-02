using System.Collections.Generic;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public enum CdsFormControlType
    {
        Attribute,
        Form,
        Grid,
        Tab,
        HomepageGrid,
        View
    }

    public class CdsFormControl
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CdsFormControlType Type { get; set; }

        public List<string> GetEvents()
        {
            switch (Type)
            {
                case CdsFormControlType.Attribute:
                    return new List<string>
                    {
                        "OnChange"
                    };

                case CdsFormControlType.Form:
                    return new List<string>
                    {
                        "OnLoad",
                        "OnSave"
                    };

                case CdsFormControlType.Grid:
                    return new List<string>
                    {
                        "OnRecordSelect",
                        "OnLoad",
                        "OnSave",
                        "OnChange"
                    };

                case CdsFormControlType.HomepageGrid:
                    return new List<string>
                    {
                        "OnRecordSelect",
                        "OnSave",
                        "OnChange"
                    };

                case CdsFormControlType.Tab:
                    return new List<string>
                    {
                        "OnTabStateChange"
                    };

                case CdsFormControlType.View:
                    return new List<string>
                    {
                        "N/A"
                    };
            }

            return null;
        }

        public override string ToString()
        {
            switch (Type)
            {
                case CdsFormControlType.Attribute:
                case CdsFormControlType.Form:
                case CdsFormControlType.Grid:
                    return $@"{Type}: {Name} ({Id})";

                case CdsFormControlType.Tab:
                    return $@"{Type}: {Name} ({Id})";

                case CdsFormControlType.HomepageGrid:
                    return "Homepage Grid";

                case CdsFormControlType.View:
                    return Name;
            }

            return string.Empty;
        }
    }
}