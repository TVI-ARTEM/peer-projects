using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.Office.Interop.Word;
using Notepad.Forms;
using Notepad.Properties;
using Language = FastColoredTextBoxNS.Language;

namespace Notepad.CustomControls
{
    public sealed partial class CustomTabPage : TabPage
    {
        public MainForm MainForm;
        public CustomRichTextBox RichTextBox;
        public FastColoredTextBox FastColoredTextBox;

        public bool IsRtb;

        /// <summary>
        /// Custom tab page with text box to change text.
        /// </summary>
        /// <param name="mainForm">Main form owner.</param>
        /// <param name="file">File, which this tab contains.</param>
        public CustomTabPage(MainForm mainForm, CustomRichTextBox file)
        {
            // Set default settings of current tab page.
            MainForm = mainForm;

            RichTextBox = file;
            Text = file.FileName + file.FileExtension;

            RichTextBox.Dock = DockStyle.Fill;

            RichTextBox.Select();
            RichTextBox.TextChanged += BoxTextChanged;
            RichTextBox.LinkClicked += RichTextBoxLinkClicked;
            RichTextBox.ContextMenuStrip = CreateContextMenuStrip();

            FastColoredTextBox = new FastColoredTextBox {Dock = DockStyle.Fill};
            FastColoredTextBox.Select();
            FastColoredTextBox.SyntaxHighlighter = new SyntaxHighlighter(FastColoredTextBox);
            FastColoredTextBox.TextChanged += BoxTextChanged;
            FastColoredTextBox.ContextMenuStrip = CreateContextMenuStrip(true);
            FastColoredTextBox.Language = Language.CSharp;
            FastColoredTextBox.Visible = false;

            IsRtb = true;

            Controls.AddRange(new Control[] {FastColoredTextBox, RichTextBox});
        }

        /// <summary>
        /// Event handler when text in text box is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BoxTextChanged(object sender, EventArgs e)
        {
            RichTextBox.IsSaved = false;
            RichTextBox.TimeLastChange = DateTime.Now;

            GetLength();

            Text = Text.EndsWith("*") ? Text : Text + "*";
        }

        /// <summary>
        /// Event handler when user click to link in richtextbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void RichTextBoxLinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        /// <summary>
        /// Create context menu strip for text boxes.
        /// </summary>
        /// <param name="isFormatCode">Is Fast colored box.</param>
        /// <returns>Context menu strip.</returns>
        private ContextMenuStrip CreateContextMenuStrip(bool isFormatCode = false)
        {
            // Create tools for new context menu strip.

            var newContextMenuStrip = new ContextMenuStrip();
            var undo = new ToolStripMenuItem("Undo", Resources.Undo_16x, (sender, args) => MainForm.Undo());
            var redo = new ToolStripMenuItem("Redo", Resources.Redo_16x, (sender, args) => MainForm.Redo());
            var cut = new ToolStripMenuItem("Cut", Resources.Cut_16x, (sender, args) => MainForm.Cut());
            var copy = new ToolStripMenuItem("Copy", Resources.Copy_16x, (sender, args) => MainForm.Copy());
            var paste = new ToolStripMenuItem("Paste", Resources.Paste_16x, (sender, args) => MainForm.Paste());
            var font = new ToolStripMenuItem("Font", Resources.Font_16x, (sender, args) => MainForm.ChangeFont());
            var selectAll = new ToolStripMenuItem("Select All", Resources.SelectAll_16x,
                (sender, args) => MainForm.SelectAll());
            newContextMenuStrip.Items.AddRange(new ToolStripItem[] {undo, redo, cut, copy, paste, font, selectAll});

            if (!isFormatCode) return newContextMenuStrip;

            var formatCode = new ToolStripMenuItem("Format Code", Resources.ExtensionPackage_16x,
                    (sender, args) => FormatCode())
                {ShortcutKeys = (Keys) Shortcut.CtrlK};

            newContextMenuStrip.Items.Add(formatCode);


            return newContextMenuStrip;
        }

        #region Edit
        /// <summary>
        /// Undo actions in current text box.
        /// </summary>
        public void Undo()
        {
            if (IsRtb)
                RichTextBox.Undo();
            else
                FastColoredTextBox.Undo();
        }

        /// <summary>
        /// Redo actions in current text box.
        /// </summary>
        public void Redo()
        {
            if (IsRtb)
                RichTextBox.Redo();
            else
                FastColoredTextBox.Redo();
        }

        /// <summary>
        /// Cut selected text to clipboard.
        /// </summary>
        public void Cut()
        {
            if (IsRtb)
                RichTextBox.Cut();
            else
                FastColoredTextBox.Cut();
        }

        /// <summary>
        /// Copy selected text to clipboard.
        /// </summary>
        public void Copy()
        {
            if (IsRtb)
                RichTextBox.Copy();
            else
                FastColoredTextBox.Copy();
        }

        /// <summary>
        /// Paste selected text to clipboard.
        /// </summary>
        public void Paste()
        {
            if (IsRtb)
                RichTextBox.Paste();
            else
                FastColoredTextBox.Paste();
        }

        /// <summary>
        /// Change font of selected text in current text box.
        /// </summary>
        public void ChangeFont()
        {
            using var fontDialog = new FontDialog
            {
                ShowColor = true,
                Color = IsRtb ? RichTextBox.SelectionColor : FastColoredTextBox.SelectionColor,
                Font = IsRtb ? RichTextBox.SelectionFont : FastColoredTextBox.Font
            };


            if (fontDialog.ShowDialog() != DialogResult.OK) return;
            // Set new colors.
            if (IsRtb)
            {
                RichTextBox.SelectionFont = fontDialog.Font;
                RichTextBox.SelectionColor = fontDialog.Color;
            }
            else
            {
                FastColoredTextBox.Font = fontDialog.Font;
                FastColoredTextBox.ForeColor = fontDialog.Color;
            }
        }

        /// <summary>
        /// Select all text in current text box.
        /// </summary>
        public void SelectAll()
        {
            if (IsRtb)
                RichTextBox.SelectAll();
            else
                FastColoredTextBox.SelectAll();
        }

        #endregion
        /// <summary>
        /// Change text style to plain/rtf text.
        /// </summary>
        public void ChangeToRichTextBox()
        {
            if (IsRtb) return;
            // Change visible of richtextbox and fastcoloredbox.
            RichTextBox.Rtf = FastColoredTextBox.Rtf;

            RichTextBox.Visible = true;
            FastColoredTextBox.Visible = false;

            IsRtb = true;
        }

        /// <summary>
        /// Apply certain programming language syntax.
        /// </summary>
        /// <param name="newLanguage">Programming language syntax.</param>
        public void ChangeToFastColoredTextBox(Language newLanguage)
        {
            // Change visible of richtextbox and fastcoloredbox and apply code syntax..
            if (IsRtb)
            {
                FastColoredTextBox.Text = RichTextBox.Text;
                RichTextBox.Visible = false;
                FastColoredTextBox.Visible = true;

                IsRtb = false;
            }


            FastColoredTextBox.Language = newLanguage;
            FastColoredTextBox.OnSyntaxHighlight(new TextChangedEventArgs(FastColoredTextBox.Range));
        }

        /// <summary>
        /// Upload text to current text box.
        /// </summary>
        /// <param name="fileSource">File's path.</param>
        /// <param name="extension">File's extension as enum.</param>
        /// <param name="language">File's programming language syntax.</param>
        public void UploadText(string fileSource, Extension extension, Language language)
        {
            // Open and read file's text.
            switch (extension)
            {
                case Extension.Code:
                    RichTextBox.LoadFile(fileSource, RichTextBoxStreamType.PlainText);
                    ChangeToFastColoredTextBox(language);
                    break;
                case Extension.Doc:
                    OpenDocFile(fileSource);
                    break;
                case Extension.Rtf:
                    RichTextBox.Rtf = File.ReadAllText(fileSource);
                    break;
                case Extension.TextFile:
                    RichTextBox.Text = File.ReadAllText(fileSource);
                    break;
            }
        }

        /// <summary>
        /// Internal method to open doc's file.
        /// </summary>
        /// <param name="newFileSource">File's path.</param>
        public void OpenDocFile(string newFileSource)
        {
            // Default settings to open doc file.
            object readOnly = true;
            object visible = true;
            object fileSource = newFileSource;
            var missing = Type.Missing;

            // Use Microsoft lib to open doc file.
            _Application wordApplication = new Microsoft.Office.Interop.Word.Application {Visible = false};

            _Document openDocument = wordApplication.Documents.Open(
                ref fileSource, ref missing, ref readOnly, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref visible,
                ref missing, ref missing, ref missing, ref missing);

            openDocument.ActiveWindow.Selection.WholeStory();
            openDocument.ActiveWindow.Selection.Copy();

            // Get doc's text.
            var data = Clipboard.GetDataObject();
            RichTextBox.Rtf = data?.GetData(DataFormats.Rtf).ToString();

            wordApplication.Quit(ref missing, ref missing, ref missing);
        }

        /// <summary>
        /// Save current file to certain place.
        /// </summary>
        /// <param name="fileSource">File's path.</param>
        /// <param name="extension">File's extension as enum.</param>
        public void SaveFile(string fileSource, Extension extension)
        {
            // Doesn't save file if it's doc's
            if (extension == Extension.Doc)
            {
                MessageBox.Show(@"Saving .doc files works bad. Save like .rtf file.", @"Saving!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Save file.
            if (!Directory.Exists(Path.GetDirectoryName(fileSource)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileSource));
            }

            if (IsRtb)
            {
                RichTextBox.SaveFile(fileSource,
                    extension == Extension.Rtf
                        ? RichTextBoxStreamType.RichText
                        : RichTextBoxStreamType.PlainText);
            }

            else
            {
                File.WriteAllText(fileSource, FastColoredTextBox.Rtf);
            }

            RichTextBox.IsSaved = true;
        }

        /// <summary>
        /// Apply CSharp code style.
        /// </summary>
        public void FormatCode()
        {
            if (IsRtb) return;

            // Format current code by Microsoft lib.
            var workspace = new AdhocWorkspace(MefHostServices.DefaultHost);

            FastColoredTextBox.Text = Formatter
                .Format(CSharpSyntaxTree.ParseText(FastColoredTextBox.Text).GetRoot(), workspace)
                .ToFullString();
        }

        /// <summary>
        /// Get quantity lines and length of current text.
        /// </summary>
        public void GetLength()
        {
            MainForm.LinesToolStripLabel.Text =
                $@"Lines: {(IsRtb ? RichTextBox.Lines.Length : FastColoredTextBox.Lines.Count)}";
            MainForm.LengthToolStripLabel.Text =
                $@"Length: {(IsRtb ? RichTextBox.TextLength : FastColoredTextBox.TextLength)}";
        }

        /// <summary>
        /// Change theme of current text box.
        /// </summary>
        /// <param name="backColor">Back color.</param>
        /// <param name="foreColor">Fore color.</param>
        public void ChangeColor(Color backColor, Color foreColor)
        {
            RichTextBox.BackColor = backColor;
            FastColoredTextBox.BackColor = backColor;

            RichTextBox.ForeColor = foreColor;
            FastColoredTextBox.ForeColor = foreColor;
        }

        /// <summary>
        /// Get text of current text box.
        /// </summary>
        /// <returns>Text of current text box.</returns>
        public string GetText() => IsRtb ? RichTextBox.Text : FastColoredTextBox.Text;
    }
}