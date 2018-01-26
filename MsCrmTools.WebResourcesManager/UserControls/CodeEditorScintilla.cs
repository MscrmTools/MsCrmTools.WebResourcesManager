using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Jsbeautifier;
using MsCrmTools.WebResourcesManager.AppCode;
using MsCrmTools.WebResourcesManager.UserControls;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using Yahoo.Yui.Compressor;

namespace MscrmTools.WebResourcesManager.UserControls
{
    public partial class CodeEditorScintilla : UserControl, IWebResourceControl
    {
        #region Variables

        private readonly FindReplace findReplace;

        /// <summary>
        /// Type of web resource
        /// </summary>
       // private readonly Enumerations.WebResourceType innerType;

        private readonly Options options;

        /// <summary>
        /// Base64 content of the web resource when loading this control
        /// </summary>
        private readonly string originalContent;

        //  private string content;
        private string innerContent;

        private readonly WebResource resource;

        #endregion Variables

        #region Constructor

        public CodeEditorScintilla(WebResource resource, Options options)
        {
            InitializeComponent();

            this.resource = resource;
            this.options = options;

            byte[] b = Convert.FromBase64String(resource.EntityContent);
            innerContent = Encoding.UTF8.GetString(b);
            originalContent = innerContent;
            //innerType = type;

            scintilla.ClearCmdKey(Keys.Control | Keys.S);
            scintilla.ClearCmdKey(Keys.Control | Keys.U);
            scintilla.ClearCmdKey(Keys.Control | Keys.F);
            scintilla.ClearCmdKey(Keys.Control | Keys.G);
            scintilla.ClearCmdKey(Keys.Control | Keys.H);
            scintilla.ClearCmdKey(Keys.Control | Keys.K);
            scintilla.ClearCmdKey(Keys.Control | Keys.C);
            scintilla.ClearCmdKey(Keys.Control | Keys.U);
            scintilla.ClearCmdKey(Keys.Control | Keys.M);
            scintilla.ClearCmdKey(Keys.Control | Keys.O);
            scintilla.AssignCmdKey(Keys.Shift | Keys.Delete, Command.LineDelete);
            scintilla.Margins[0].Width = 24;

            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();

            switch (resource.EntityType)
            {
                case (int)Enumerations.WebResourceType.Script:

                    // Configure the CPP (C#) lexer styles
                    scintilla.Styles[Style.Cpp.Default].ForeColor = Color.Silver;
                    scintilla.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
                    scintilla.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
                    scintilla.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
                    scintilla.Styles[Style.Cpp.Number].ForeColor = Color.Black;
                    scintilla.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
                    scintilla.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
                    scintilla.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
                    scintilla.Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
                    scintilla.Styles[Style.Cpp.Operator].ForeColor = Color.Black;
                    scintilla.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Black;
                    scintilla.Lexer = Lexer.Cpp;

                    // Set the keywords
                    scintilla.SetKeywords(0, "debugger abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach function goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using var virtual while");
                    scintilla.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");
                    break;

                case (int)Enumerations.WebResourceType.Css:

                    scintilla.Styles[Style.Css.Directive].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Variable].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
                    scintilla.Styles[Style.Css.Attribute].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Class].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.Id].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.DoubleString].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Css.Important].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Css.SingleString].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Css.Value].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Css.Media].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Css.Tag].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.Operator].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.PseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.PseudoElement].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.UnknownPseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.ExtendedIdentifier].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.ExtendedPseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.ExtendedPseudoElement].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Css.UnknownIdentifier].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Identifier].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Identifier2].ForeColor = Color.Red;
                    scintilla.Styles[Style.Css.Identifier3].ForeColor = Color.Red;

                    scintilla.Lexer = Lexer.Css;
                    break;

                case (int)Enumerations.WebResourceType.WebPage:

                    scintilla.Styles[Style.Html.Asp].ForeColor = Color.Black;
                    scintilla.Styles[Style.Html.Asp].BackColor = Color.Yellow;
                    scintilla.Styles[Style.Html.AspAt].ForeColor = Color.Black;
                    scintilla.Styles[Style.Html.AspAt].BackColor = Color.Yellow;
                    scintilla.Styles[Style.Html.AttributeUnknown].ForeColor = Color.Red;
                    scintilla.Styles[Style.Html.Attribute].ForeColor = Color.Red;
                    scintilla.Styles[Style.Html.CData].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.Comment].ForeColor = Color.Green;
                    scintilla.Styles[Style.Html.Default].ForeColor = Color.Black;
                    scintilla.Styles[Style.Html.DoubleString].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.Other].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.Script].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.SingleString].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.Tag].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.XcComment].ForeColor = Color.Green;
                    scintilla.Styles[Style.Html.XmlStart].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.XmlEnd].ForeColor = Color.Blue;

                    scintilla.Lexer = Lexer.Html;
                    break;

                case (int)Enumerations.WebResourceType.Data:
                case (int)Enumerations.WebResourceType.Resx:
                case (int)Enumerations.WebResourceType.Xsl:

                    scintilla.Styles[Style.Xml.Asp].BackColor = Color.Yellow;
                    scintilla.Styles[Style.Xml.AspAt].ForeColor = Color.Black;
                    scintilla.Styles[Style.Xml.AspAt].BackColor = Color.Yellow;
                    scintilla.Styles[Style.Xml.AttributeUnknown].ForeColor = Color.Red;
                    scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
                    scintilla.Styles[Style.Xml.CData].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Xml.Comment].ForeColor = Color.Green;
                    scintilla.Styles[Style.Xml.Default].ForeColor = Color.Black;
                    scintilla.Styles[Style.Xml.DoubleString].ForeColor = Color.Blue;

                    scintilla.Styles[Style.Xml.Entity].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Xml.Number].ForeColor = Color.Blue;

                    scintilla.Styles[Style.Html.Other].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.Script].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.SingleString].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.Tag].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.TagUnknown].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.FromArgb(128, 0, 0);
                    scintilla.Styles[Style.Html.XcComment].ForeColor = Color.Green;
                    scintilla.Styles[Style.Html.XmlStart].ForeColor = Color.Blue;
                    scintilla.Styles[Style.Html.XmlEnd].ForeColor = Color.Blue;

                    scintilla.Lexer = Lexer.Xml;
                    break;
            }

            // Instruct the lexer to calculate folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            scintilla.SetProperty("fold.html", "1");

            // Configure a margin to display folding symbols
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            findReplace = new FindReplace();
            findReplace.Scintilla = scintilla;
            findReplace.KeyPressed += MyFindReplace_KeyPressed;
        }

        //public CodeEditorScintilla(string content, Enumerations.WebResourceType type, Options options)
        //{
        //    InitializeComponent();

        //    this.options = options;

        //    byte[] b = Convert.FromBase64String(content);
        //    innerContent = Encoding.UTF8.GetString(b);
        //    originalContent = innerContent;
        //    innerType = type;

        //    scintilla.ClearCmdKey(Keys.Control | Keys.S);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.U);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.F);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.G);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.H);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.K);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.C);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.U);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.M);
        //    scintilla.ClearCmdKey(Keys.Control | Keys.O);
        //    scintilla.AssignCmdKey(Keys.Shift | Keys.Delete, Command.LineDelete);
        //    scintilla.Margins[0].Width = 24;

        //    scintilla.StyleResetDefault();
        //    scintilla.Styles[Style.Default].Font = "Consolas";
        //    scintilla.Styles[Style.Default].Size = 10;
        //    scintilla.StyleClearAll();

        //    switch (type)
        //    {
        //        case Enumerations.WebResourceType.Script:

        //            // Configure the CPP (C#) lexer styles
        //            scintilla.Styles[Style.Cpp.Default].ForeColor = Color.Silver;
        //            scintilla.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
        //            scintilla.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
        //            scintilla.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
        //            scintilla.Styles[Style.Cpp.Number].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
        //            scintilla.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
        //            scintilla.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
        //            scintilla.Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
        //            scintilla.Styles[Style.Cpp.Operator].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Black;
        //            scintilla.Lexer = Lexer.Cpp;

        //            // Set the keywords
        //            scintilla.SetKeywords(0, "debugger abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach function goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using var virtual while");
        //            scintilla.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");
        //            break;

        //        case Enumerations.WebResourceType.Css:

        //            scintilla.Styles[Style.Css.Directive].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Variable].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
        //            scintilla.Styles[Style.Css.Attribute].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Class].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.Id].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.DoubleString].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Css.Important].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Css.SingleString].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Css.Value].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Css.Media].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Css.Tag].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.Operator].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.PseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.PseudoElement].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.UnknownPseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.ExtendedIdentifier].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.ExtendedPseudoClass].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.ExtendedPseudoElement].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Css.UnknownIdentifier].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Identifier].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Identifier2].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Css.Identifier3].ForeColor = Color.Red;

        //            scintilla.Lexer = Lexer.Css;
        //            break;

        //        case Enumerations.WebResourceType.WebPage:

        //            scintilla.Styles[Style.Html.Asp].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Html.Asp].BackColor = Color.Yellow;
        //            scintilla.Styles[Style.Html.AspAt].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Html.AspAt].BackColor = Color.Yellow;
        //            scintilla.Styles[Style.Html.AttributeUnknown].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Html.Attribute].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Html.CData].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.Comment].ForeColor = Color.Green;
        //            scintilla.Styles[Style.Html.Default].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Html.DoubleString].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.Other].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.Script].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.SingleString].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.Tag].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.XcComment].ForeColor = Color.Green;
        //            scintilla.Styles[Style.Html.XmlStart].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.XmlEnd].ForeColor = Color.Blue;

        //            scintilla.Lexer = Lexer.Html;
        //            break;

        //        case Enumerations.WebResourceType.Data:
        //        case Enumerations.WebResourceType.Resx:
        //        case Enumerations.WebResourceType.Xsl:

        //            scintilla.Styles[Style.Xml.Asp].BackColor = Color.Yellow;
        //            scintilla.Styles[Style.Xml.AspAt].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Xml.AspAt].BackColor = Color.Yellow;
        //            scintilla.Styles[Style.Xml.AttributeUnknown].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
        //            scintilla.Styles[Style.Xml.CData].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Xml.Comment].ForeColor = Color.Green;
        //            scintilla.Styles[Style.Xml.Default].ForeColor = Color.Black;
        //            scintilla.Styles[Style.Xml.DoubleString].ForeColor = Color.Blue;

        //            scintilla.Styles[Style.Xml.Entity].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Xml.Number].ForeColor = Color.Blue;

        //            scintilla.Styles[Style.Html.Other].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.Script].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.SingleString].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.Tag].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.TagUnknown].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.FromArgb(128, 0, 0);
        //            scintilla.Styles[Style.Html.XcComment].ForeColor = Color.Green;
        //            scintilla.Styles[Style.Html.XmlStart].ForeColor = Color.Blue;
        //            scintilla.Styles[Style.Html.XmlEnd].ForeColor = Color.Blue;

        //            scintilla.Lexer = Lexer.Xml;
        //            break;
        //    }

        //    // Instruct the lexer to calculate folding
        //    scintilla.SetProperty("fold", "1");
        //    scintilla.SetProperty("fold.compact", "1");
        //    scintilla.SetProperty("fold.html", "1");

        //    // Configure a margin to display folding symbols
        //    scintilla.Margins[2].Type = MarginType.Symbol;
        //    scintilla.Margins[2].Mask = Marker.MaskFolders;
        //    scintilla.Margins[2].Sensitive = true;
        //    scintilla.Margins[2].Width = 20;

        //    // Set colors for all folding markers
        //    for (int i = 25; i <= 31; i++)
        //    {
        //        scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
        //        scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
        //    }

        //    // Configure folding markers with respective symbols
        //    scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
        //    scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
        //    scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
        //    scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
        //    scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
        //    scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
        //    scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

        //    findReplace = new FindReplace();
        //    findReplace.Scintilla = scintilla;
        //    findReplace.KeyPressed += MyFindReplace_KeyPressed;
        //}

        #endregion Constructor

        public bool IsDirty => innerContent != originalContent;

        public WebResource Resource => resource;

        #region Event Handlers

        public event EventHandler<WebResourceUpdatedEventArgs> WebResourceUpdated;

        #endregion Event Handlers

        #region Events

        private void CodeEditor_Load(object sender, EventArgs e)
        {
            scintilla.Text = innerContent;
            scintilla.EmptyUndoBuffer();
        }

        /// <summary>
        /// Key down event for each Scintilla. Tie each Scintilla to this event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genericScintilla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                findReplace.ShowFind();
                e.SuppressKeyPress = true;
            }
            else if (e.Shift && e.KeyCode == Keys.F3)
            {
                findReplace.Window.FindPrevious();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                findReplace.Window.FindNext();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.H)
            {
                findReplace.ShowReplace();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                findReplace.ShowIncrementalSearch();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                GoTo MyGoTo = new GoTo((Scintilla)sender);
                MyGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }
        }

        private void MyFindReplace_KeyPressed(object sender, KeyEventArgs e)
        {
            genericScintilla_KeyDown(sender, e);
        }

        private void scintilla_CharAdded(object sender, CharAddedEventArgs e)
        {
            var currentLine = scintilla.Lines[scintilla.CurrentLine];
            var currentPosition = scintilla.CurrentPosition;
            if (currentLine.Text == "\r\n")
            {
                currentLine.Indentation = scintilla.Lines[scintilla.CurrentLine - 1].Indentation;
                scintilla.CurrentPosition = currentPosition + currentLine.Indentation;
                scintilla.SelectionStart = scintilla.CurrentPosition;
            }
        }

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            innerContent = scintilla.Text;
            SendSavedMessage();
        }

        #endregion Events

        #region Methods

        public void Beautify()
        {
            Beautifier b = new Beautifier(new BeautifierOptions
            {
                BraceStyle = BraceStyle.Expand,
                BreakChainedMethods = false,
                EvalCode = true,
                IndentChar = '\t',
                IndentSize = 1,
                IndentWithTabs = true,
                JslintHappy = true,
                KeepArrayIndentation = true,
                KeepFunctionIndentation = true,
                MaxPreserveNewlines = 1,
                PreserveNewlines = true
            });

            scintilla.Text = b.Beautify(scintilla.Text);
        }

        public void CommentSelectedLines()
        {
            Comment(true);
        }

        public void ContractFolds()
        {
            foreach (Line ln in scintilla.Lines)
            {
                if (LineIsFoldPoint(ln.Index))
                {
                    ln.FoldLine(FoldAction.Contract);
                }
            }
        }

        public void Copy()
        {
            scintilla.Copy();
        }

        public void Find(bool replace)
        {
            if (replace)
                findReplace.ShowReplace();
            else
                findReplace.ShowFind();
        }

        public string GetBase64WebResourceContent()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(scintilla.Text);

            return Convert.ToBase64String(bytes);
        }

        public Enumerations.WebResourceType GetWebResourceType()
        {
            return (Enumerations.WebResourceType)resource.EntityType;
        }

        public void GoToLine()
        {
            GoTo goTo = new GoTo(findReplace.Scintilla);
            goTo.ShowGoToDialog();
        }

        public void MinifyJs()
        {
            try
            {
                scintilla.Text = DoMinifyJs();
            }
            catch (Exception error)
            {
                MessageBox.Show(ParentForm, "Error while minifying code: " + error.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshContent(string newContent)
        {
            scintilla.Text = newContent;
        }

        public void ReplaceWithNewFile(string filename)
        {
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    innerContent = reader.ReadToEnd();
                }

                CodeEditor_Load(null, null);

                resource.SetAsSaved();

                //SendSavedMessage();
            }
            catch (Exception error)
            {
                MessageBox.Show(ParentForm, "Error while updating file: " + error.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UncommentSelectedLines()
        {
            Comment(false);
        }

        private void Comment(bool comment)
        {
            int start = scintilla.SelectionStart;
            int end = scintilla.SelectionEnd;

            if (resource.EntityType == (int)Enumerations.WebResourceType.Script)
            {
                foreach (var line in scintilla.Lines.Where(l => l.Position <= start && l.EndPosition > start
                || l.Position >= start && l.EndPosition <= end
                || l.Position <= end && l.EndPosition > end))
                {
                    if (comment)
                    {
                        scintilla.InsertText(line.Position, "//");
                        end += 2;
                    }
                    else
                    {
                        var i = line.Text.IndexOf("//", StringComparison.Ordinal);
                        if (i >= 0)
                        {
                            scintilla.DeleteRange(line.Position + i, 2);
                            end -= 2;
                        }
                    }
                }
            }
            else if (resource.EntityType == (int)Enumerations.WebResourceType.Css)
            {
                var startLine = scintilla.Lines.First(l => l.Position <= start && l.EndPosition > start);
                var endLine = start == end ? startLine : scintilla.Lines.First(l => l.Position < end && l.EndPosition >= end);
                DoCommentWithStartAndEndTags(comment, startLine, endLine, "/*", "*/");
            }
            else if (resource.EntityType == (int)Enumerations.WebResourceType.WebPage
                || resource.EntityType == (int)Enumerations.WebResourceType.Data
                || resource.EntityType == (int)Enumerations.WebResourceType.Xsl)
            {
                if (comment)
                {
                    var indexOfComment = scintilla.Text.IndexOf("<!--", start, StringComparison.Ordinal);
                    if (indexOfComment >= 0 && indexOfComment < end)
                    {
                        MessageBox.Show(this, "Cannot comment a block that already contains a comment", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var startLine = scintilla.Lines.First(l => l.Position <= start && l.EndPosition > start);
                var endLine = start == end ? startLine : scintilla.Lines.First(l => l.Position < end && l.EndPosition >= end);
                DoCommentWithStartAndEndTags(comment, startLine, endLine, "<!--", "-->");
            }
        }

        private void DoCommentWithStartAndEndTags(bool comment, Line startLine, Line endLine, string startString, string endString)
        {
            if (comment)
            {
                scintilla.InsertText(startLine.Position, startString);
                scintilla.InsertText(endLine.EndPosition - 1, endString);
            }
            else
            {
                Line tempLine = startLine;
                int i = tempLine.Text.IndexOf(startString, StringComparison.Ordinal);
                while (i < 0)
                {
                    tempLine = scintilla.Lines[tempLine.Index - 1];
                    if (tempLine.Index == 0)
                    {
                        break;
                    }

                    i = tempLine.Text.IndexOf(startString, StringComparison.Ordinal);
                }

                if (i < 0)
                {
                    tempLine = startLine;
                    while (i < 0)
                    {
                        tempLine = scintilla.Lines[tempLine.Index + 1];
                        if (tempLine.Index > endLine.Index)
                        {
                            break;
                        }

                        i = tempLine.Text.IndexOf(startString, StringComparison.Ordinal);
                    }
                }

                if (i < 0)
                {
                    return;
                }

                scintilla.DeleteRange(tempLine.Position + i, startString.Length);

                tempLine = endLine;
                i = tempLine.Text.IndexOf(endString, StringComparison.Ordinal);
                while (i < 0)
                {
                    tempLine = scintilla.Lines[tempLine.Index + 1];
                    if (tempLine.Index == scintilla.Lines.Count - 1)
                    {
                        break;
                    }

                    i = tempLine.Text.IndexOf(endString, StringComparison.Ordinal);
                }

                if (i < 0)
                {
                    tempLine = endLine;
                    i = tempLine.Text.IndexOf(endString, StringComparison.Ordinal);

                    while (i < 0)
                    {
                        tempLine = scintilla.Lines[tempLine.Index - 1];

                        if (tempLine.Index < startLine.Index)
                        {
                            break;
                        }

                        i = tempLine.Text.IndexOf(endString, StringComparison.Ordinal);
                    }
                }

                if (i < 0)
                {
                    MessageBox.Show(this, "Unable to find Comment end tag", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                scintilla.DeleteRange(tempLine.Position + i, endString.Length);
            }
        }

        private string DoMinifyJs()
        {
            try
            {
                if (resource.EntityType == (int)Enumerations.WebResourceType.Script)
                {
                    var compressor = new JavaScriptCompressor { ObfuscateJavascript = options.ObfuscateJavascript };
                    return compressor.Compress(scintilla.Text);
                }

                if (resource.EntityType == (int)Enumerations.WebResourceType.Css)
                {
                    var compressor = new CssCompressor { RemoveComments = options.RemoveCssComments };
                    return compressor.Compress(scintilla.Text);
                }

                return scintilla.Text;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return originalContent;
            }
        }

        private bool LineIsFoldPoint(int linenum)
        {
            return ((scintilla.Lines[linenum].FoldLevelFlags & FoldLevelFlags.Header) > 0);
        }

        private void SendSavedMessage()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(innerContent);

            var wrueArgs = new WebResourceUpdatedEventArgs
            {
                Base64Content = Convert.ToBase64String(bytes),
                IsDirty = innerContent != originalContent,
                Type = (Enumerations.WebResourceType)resource.EntityType
            };

            WebResourceUpdated?.Invoke(this, wrueArgs);
        }

        #endregion Methods
    }
}