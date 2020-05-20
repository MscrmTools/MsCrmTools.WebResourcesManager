using Jsbeautifier;
using MscrmTools.WebresourcesManager.AppCode;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Yahoo.Yui.Compressor;

namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    public partial class CodeEditorForm : BaseContentForm
    {
        private readonly FindReplace findReplace;

        public CodeEditorForm()
        {
        }

        public CodeEditorForm(MyPluginControl control, Webresource resource) : base(control, resource, true)
        {
            InitializeComponent();

            ManageCmdKeys();
            SetEditorStyle();

            findReplace = new FindReplace();
            findReplace.Scintilla = scintilla;
            findReplace.KeyPressed += MyFindReplace_KeyPressed;

            Controls.SetChildIndex(scintilla, 0);

            Text = resource.Name;
            resource.ContentReplaced += Resource_ContentReplaced;
        }

        protected override void ClearEvents()
        {
            Resource.ContentReplaced -= Resource_ContentReplaced;
        }

        private void CodeEditorForm_Load(object sender, EventArgs e)
        {
            scintilla.Text = Resource.StringContent;
            scintilla.EmptyUndoBuffer();

            scintilla.Margins[0].Width = scintilla.Lines.Count.ToString().Length * 12;

            scintilla.TextChanged += scintilla_TextChanged;
        }

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
                GoTo myGoTo = new GoTo((Scintilla)sender);
                myGoTo.ShowGoToDialog();
                e.SuppressKeyPress = true;
            }
        }

        private void ManageCmdKeys()
        {
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
        }

        private void MyFindReplace_KeyPressed(object sender, KeyEventArgs e)
        {
            genericScintilla_KeyDown(sender, e);
        }

        private void Resource_ContentReplaced(object sender, AppCode.Args.ResourceEventArgs e)
        {
            Invoke(new Action(() =>
            {
                scintilla.TextChanged -= scintilla_TextChanged;
                scintilla.Text = e.Resource.StringContent;
                scintilla.TextChanged += scintilla_TextChanged;
            }));
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
            Resource.UpdatedStringContent = scintilla.Text;
            scintilla.Margins[0].Width = scintilla.Lines.Count.ToString().Length * 12;
        }

        private void SetEditorStyle()
        {
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();

            switch (Resource.Type)
            {
                case (int)WebresourceType.Script:

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
                    scintilla.SetKeywords(0,
                        "debugger abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach function goto if implicit in interface internal is let lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using var virtual while");
                    scintilla.SetKeywords(1,
                        "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");
                    break;

                case (int)WebresourceType.Css:

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

                case (int)WebresourceType.WebPage:

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

                case (int)WebresourceType.Data:
                case (int)WebresourceType.Resx:
                case (int)WebresourceType.Xsl:

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
        }

        #region Comment methods

        public void CommentSelectedLines()
        {
            Comment(true);
        }

        public void UncommentSelectedLines()
        {
            Comment(false);
        }

        private void Comment(bool comment)
        {
            int start = scintilla.SelectionStart;
            int end = scintilla.SelectionEnd;

            if (Resource.Type == (int)WebresourceType.Script)
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
            else if (Resource.Type == (int)WebresourceType.Css)
            {
                var startLine = scintilla.Lines.First(l => l.Position <= start && l.EndPosition > start);
                var endLine = start == end ? startLine : scintilla.Lines.First(l => l.Position < end && l.EndPosition >= end);
                DoCommentWithStartAndEndTags(comment, startLine, endLine, "/*", "*/");
            }
            else if (Resource.Type == (int)WebresourceType.WebPage
                || Resource.Type == (int)WebresourceType.Data
                || Resource.Type == (int)WebresourceType.Xsl)
            {
                if (comment)
                {
                    var indexOfComment = scintilla.Text.IndexOf("<!--", start, StringComparison.Ordinal);
                    if (indexOfComment >= 0 && indexOfComment < end)
                    {
                        MessageBox.Show(this, @"Cannot comment a block that already contains a comment", @"Warning",
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
                    MessageBox.Show(this, @"Unable to find Comment end tag", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                scintilla.DeleteRange(tempLine.Position + i, endString.Length);
            }
        }

        #endregion Comment methods

        #region Folding methods

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

        private bool LineIsFoldPoint(int linenum)
        {
            return ((scintilla.Lines[linenum].FoldLevelFlags & FoldLevelFlags.Header) > 0);
        }

        #endregion Folding methods

        #region Actions methods

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

            Resource.UpdatedStringContent = b.Beautify(Resource.UpdatedStringContent);
            scintilla.Text = Resource.UpdatedStringContent;
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

        public void GoToLine()
        {
            GoTo goTo = new GoTo(findReplace.Scintilla);
            goTo.ShowGoToDialog();
        }

        public void Minify()
        {
            try
            {
                if (Resource.Type == (int)WebresourceType.Script)
                {
                    var compressor = new JavaScriptCompressor { ObfuscateJavascript = Settings.Instance.ObfuscateJavascript };
                    Resource.UpdatedStringContent = compressor.Compress(Resource.UpdatedStringContent);
                    scintilla.Text = Resource.UpdatedStringContent;
                }
                else if (Resource.Type == (int)WebresourceType.Css)
                {
                    var compressor = new CssCompressor { RemoveComments = Settings.Instance.RemoveCssComments };
                    Resource.UpdatedStringContent = compressor.Compress(Resource.UpdatedStringContent);
                    scintilla.Text = Resource.UpdatedStringContent;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, $@"An error occured while minifying code: {error.Message}", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Actions methods
    }
}