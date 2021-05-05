using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Notepad.CustomControls;
using Language = FastColoredTextBoxNS.Language;

namespace Notepad.Forms
{
    public partial class MainForm : Form
    {
        public const string NotepadPath = "Notepad";
        public const string SettingsPath = "Settings";
        public const string BackUpPath = "BackUp";

        public Theme CurrentTheme = Theme.Light;
        public List<string> RecentFiles = new List<string>();

        /// <summary>
        /// Create main form of notepad application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ChangeTheme(CurrentTheme);
        }

        #region File

        #region Create

        /// <summary>
        /// Create new tab with a clear text box.
        /// </summary>
        private void CreateNewCustomTab()
        {
            var newTab = new CustomTabPage(this, new CustomRichTextBox($"untitled{mainTabControl.TabCount}.txt", true));

            // Add new tab to tab control.
            mainTabControl.TabPages.Insert(mainTabControl.TabCount - 1, newTab);
            mainTabControl.SelectedIndex = mainTabControl.TabCount - 2;

            ChangeTheme(CurrentTheme);
        }

        /// <summary>
        /// Open new window.
        /// </summary>
        private static void CreateNewWindow()
        {
            try
            {
                var newMainForm = new MainForm();

                // open new window.
                newMainForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Open

        /// <summary>
        /// Open file by openFileDialog.
        /// </summary>
        private void OpenFile()
        {
            try
            {
                using var openFileDialog = new OpenFileDialog();

                SetDefaultSettingsDialog(openFileDialog);

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                OpenFileInternal(openFileDialog.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Internal method to open file.
        /// </summary>
        /// <param name="fileSource">File's path.</param>
        private void OpenFileInternal(string fileSource)
        {
            // Restart controls.
            SuspendLayout();

            // create and add new tab to tab control.
            var newFile = new CustomRichTextBox(fileSource, false);
            var newTab = new CustomTabPage(this, newFile);

            mainTabControl.TabPages.Insert(mainTabControl.TabCount - 1, newTab);

            // Restart controls.
            ResumeLayout();

            GetFileType(newFile.FileExtension, out var extension, out var language);

            // read text and upload this to text box.
            newTab.UploadText(newFile.FileSource, extension, language);

            ChangeTheme(CurrentTheme);

            // Check if it backup file.
            if (newFile.FileSource.Contains(Path.GetFullPath(Path.Combine(NotepadPath, BackUpPath))))
            {
                // delete file source.
                newFile.FileSource = string.Empty;
            }
            else
            {
                // Mark this as saved.
                newFile.IsSaved = true;
            }

            GetRecentFiles();

            // Set tab page as selected. 
            mainTabControl.SelectedIndex = mainTabControl.TabCount - 2;
            mainTabControl.SelectedTab.Text = newFile.FileName + newFile.FileExtension;
        }

        #endregion

        #region Save

        /// <summary>
        /// Save current file. 
        /// </summary>
        private void Save()
        {
            try
            {
                // Check tab page is custom.
                if (!(mainTabControl.SelectedTab is CustomTabPage)) return;

                SaveFile((CustomTabPage) mainTabControl.SelectedTab);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Internal method to save certain file.
        /// </summary>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        private void SaveFile(CustomTabPage currentTabPage)
        {
            // Check if this file has path.
            if (currentTabPage.RichTextBox.FileSource != string.Empty)
                RewriteFile(currentTabPage);
            else
                SaveNewFile(currentTabPage);
        }

        /// <summary>
        /// Save file in certain parameters.
        /// </summary>
        private void SaveAs()
        {
            try
            {
                // Check tab page is custom.
                if (!(mainTabControl.SelectedTab is CustomTabPage)) return;

                SaveNewFile((CustomTabPage) mainTabControl.SelectedTab);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save file, if it doesn't have path.
        /// </summary>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        private void SaveNewFile(CustomTabPage currentTabPage)
        {
            using var saveFileDialog = new SaveFileDialog();

            SetDefaultSettingsDialog(saveFileDialog);

            // Set saveFileDialog file name by this tab page's name.
            saveFileDialog.FileName =
                currentTabPage.RichTextBox.FileName + currentTabPage.RichTextBox.FileExtension;

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            GetFileNameDialog(currentTabPage, saveFileDialog);

            RewriteFile(currentTabPage);
        }

        /// <summary>
        /// Save all files, which opened in window.
        /// </summary>
        private void SaveAll()
        {
            try
            {
                // Check all files and save them.
                foreach (var tabPage in mainTabControl.TabPages.OfType<CustomTabPage>())
                {
                    // Don't save file if it doc's file.
                    if (tabPage.RichTextBox.FileExtension.Contains(".doc")
                        || tabPage.RichTextBox.FileExtension.Contains(".docx")) continue;

                    SaveFile(tabPage);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Rewrite file in certain path.
        /// </summary>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        private void RewriteFile(CustomTabPage currentTabPage)
        {
            RewriteFileInternal(currentTabPage);

            // Set current tab page name
            currentTabPage.Text = currentTabPage.RichTextBox.FileName + currentTabPage.RichTextBox.FileExtension;
        }

        /// <summary>
        /// Internal method to rewrite file.
        /// </summary>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        private void RewriteFileInternal(CustomTabPage currentTabPage)
        {
            GetFileType(currentTabPage.RichTextBox.FileExtension, out var extension, out _);

            currentTabPage.SaveFile(currentTabPage.RichTextBox.FileSource, extension);

            if (extension != Extension.Doc)
            {
                currentTabPage.SaveFile(Path.Combine(
                        NotepadPath,
                        BackUpPath,
                        currentTabPage.RichTextBox.FileName,
                        currentTabPage.RichTextBox.GetTimeLastChanged,
                        currentTabPage.RichTextBox.FileName + currentTabPage.RichTextBox.FileExtension),
                    extension);
            }

            GetRecentFiles();
        }

        /// <summary>
        /// Save all files in certain interval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSave_Tick(object sender, EventArgs e)
        {
            // Check all files and save them.
            foreach (var tabPage in mainTabControl.TabPages.OfType<CustomTabPage>())
            {
                // Don't save if this file doesn't have path or doc's file.
                if (tabPage.RichTextBox.FileSource != string.Empty &&
                    !tabPage.RichTextBox.IsSaved &&
                    !tabPage.RichTextBox.FileExtension.Equals(".doc") &&
                    !tabPage.RichTextBox.FileExtension.Equals(".docx"))

                    RewriteFile(tabPage);
            }
        }

        #endregion


        #region Close Tab

        /// <summary>
        /// Close current tab.
        /// </summary>
        private void CloseThisTab()
        {
            try
            {
                CloseTab(out _, mainTabControl.SelectedTab);

                GetRecentFiles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Close all tabs, which opened in window.
        /// </summary>
        private void CloseAllTabs()
        {
            try
            {
                // Check all files and close them.
                for (var indexTab = 0; indexTab < mainTabControl.TabCount; indexTab++)
                {
                    var currentTabPage = mainTabControl.TabPages[indexTab];

                    if (!CloseTab(out var eventCancel, currentTabPage)) continue;

                    // Stop closing if user click cancel;
                    if (eventCancel) break;

                    indexTab--;
                }

                GetRecentFiles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Internal method to close certain tab.
        /// </summary>
        /// <param name="eventCancel">Define to stop closing.</param>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        /// <returns></returns>
        private bool CloseTab(out bool eventCancel, TabPage currentTabPage)
        {
            eventCancel = false;

            // Check tap page is custom tab page.
            if (!(currentTabPage is CustomTabPage)) return false;

            var customCurrentTabPage = (CustomTabPage) currentTabPage;

            // If this file is saved - just close this tab page.
            if (customCurrentTabPage.RichTextBox.IsSaved)
            {
                mainTabControl.TabPages.Remove(currentTabPage);
                return true;
            }

            // Show message box to save this file or not.
            var saveClose = MessageBox.Show(
                $@"Do you want to save {customCurrentTabPage.RichTextBox.FileName + customCurrentTabPage.RichTextBox.FileExtension}?",
                @"Saving!",
                MessageBoxButtons.YesNoCancel);

            switch (saveClose)
            {
                case DialogResult.Yes:
                    SaveFile(customCurrentTabPage);
                    mainTabControl.TabPages.Remove(currentTabPage);
                    break;
                case DialogResult.No:
                    mainTabControl.TabPages.Remove(currentTabPage);
                    break;
                case DialogResult.Cancel:
                    eventCancel = true;
                    break;
            }


            return true;
        }

        #endregion

        #endregion

        #region Edit

        /// <summary>
        /// Undo actions in current text box.
        /// </summary>
        public void Undo()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.Undo();
        }

        /// <summary>
        /// Redo actions in current text box.
        /// </summary>
        public void Redo()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.Redo();
        }


        /// <summary>
        /// Cut selected text to clipboard.
        /// </summary>
        public void Cut()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.Cut();
        }

        /// <summary>
        /// Copy selected text to clipboard.
        /// </summary>
        public void Copy()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.Copy();
        }

        /// <summary>
        /// Paste selected text to clipboard.
        /// </summary>
        public void Paste()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.Paste();
        }

        /// <summary>
        /// Select all text in current text box.
        /// </summary>
        public void SelectAll()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.SelectAll();
        }

        /// <summary>
        /// Change font of selected text in current text box.
        /// </summary>
        public void ChangeFont()
        {
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeFont();
        }

        #endregion

        #region Internal Methods

        /// <summary>
        /// Set name to fileDialog.
        /// </summary>
        /// <param name="currentTabPage">Tab page, which contains a certain file.</param>
        /// <param name="fileDialog">File dialog, which save or open file.</param>
        private static void GetFileNameDialog(CustomTabPage currentTabPage, FileDialog fileDialog)
        {
            currentTabPage.RichTextBox.FileSource = fileDialog.FileName;
            currentTabPage.RichTextBox.FileName =
                Path.GetFileNameWithoutExtension(currentTabPage.RichTextBox.FileSource);
            currentTabPage.RichTextBox.FileExtension = Path.GetExtension(currentTabPage.RichTextBox.FileSource);
        }

        /// <summary>
        /// Set default settings to fileDialog.
        /// </summary>
        /// <param name="fileDialog">File dialog, which save or open file.</param>
        private static void SetDefaultSettingsDialog(FileDialog fileDialog)
        {
            fileDialog.Filter = "txt files (*.txt)|*.txt|" +
                                "rtf files (*.rtf)|*.rtf|" +
                                "All files (*.*)|*.*";
            fileDialog.FilterIndex = 3;
            fileDialog.RestoreDirectory = true;
        }

        /// <summary>
        /// Get type of certain file.
        /// </summary>
        /// <param name="fileExtension">File's extension.</param>
        /// <param name="extension">Return file's extension as Enum.</param>
        /// <param name="language">Return file's programming language as Enum.</param>
        private static void GetFileType(string fileExtension, out Extension extension, out Language language)
        {
            // Check file extension.
            switch (fileExtension)
            {
                case ".txt":
                    extension = Extension.TextFile;
                    language = Language.Custom;
                    break;
                case ".rtf":
                    extension = Extension.Rtf;
                    language = Language.Custom;
                    break;
                case ".doc":
                case ".docx":
                    extension = Extension.Doc;
                    language = Language.Custom;
                    break;
                case ".cs":
                case ".cpp":
                case ".c":
                    extension = Extension.Code;
                    language = Language.CSharp;
                    break;
                case ".html":
                case ".xhtml":
                case ".htm":
                    extension = Extension.Code;
                    language = Language.HTML;
                    break;
                case ".js":
                    extension = Extension.Code;
                    language = Language.JS;
                    break;
                case ".vb":
                    extension = Extension.Code;
                    language = Language.VB;
                    break;
                default:
                    extension = Extension.TextFile;
                    language = Language.Custom;
                    break;
            }
        }

        #endregion


        #region Tool Strip

        #region File

        private void NewToolStripButton_Click(object sender, EventArgs e) => CreateNewCustomTab();
        private void CreateNewWindowToolStripButton_Click(object sender, EventArgs e) => CreateNewWindow();

        private void OpenToolStripButton_Click(object sender, EventArgs e) => OpenFile();

        private void SaveToolStripButton_Click(object sender, EventArgs e) => Save();
        private void SaveAsToolStripButton_Click(object sender, EventArgs e) => SaveAs();
        private void SaveAllToolStripButton_Click(object sender, EventArgs e) => SaveAll();

        private void CloseThisTabToolStripButton_Click(object sender, EventArgs e) => CloseThisTab();
        private void CloseAllTabsToolStripButton_Click(object sender, EventArgs e) => CloseAllTabs();

        private void ExitTolStripButton_Click(object sender, EventArgs e) => Close();

        #endregion

        #region Edit

        private void UndoToolStripButton_Click(object sender, EventArgs e) => Undo();
        private void RedoToolStripButton_Click(object sender, EventArgs e) => Redo();

        private void CopyToolStripButton_Click(object sender, EventArgs e) => Copy();
        private void CutToolStripButton_Click(object sender, EventArgs e) => Cut();
        private void PasteToolStripButton_Click(object sender, EventArgs e) => Paste();

        private void FontToolStripButton_Click(object sender, EventArgs e) => ChangeFont();
        private void SelectAllToolStripButton_Click(object sender, EventArgs e) => SelectAll();

        #endregion

        #region Text Style

        /// <summary>
        /// Change text style to plain / rtf text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SimpleTextToolStripMenuItem_Click(object sender, EventArgs e) =>
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeToRichTextBox();

        /// <summary>
        /// Change text style to CSharp Syntax.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSharpStyleToolStripMenuItem_Click(object sender, EventArgs e) =>
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeToFastColoredTextBox(Language.CSharp);

        /// <summary>
        /// Change text style to HTML Syntax.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HTMLStyleToolStripMenuItem_Click(object sender, EventArgs e) =>
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeToFastColoredTextBox(Language.HTML);

        /// <summary>
        /// Change text style to JS Style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JSStyleToolStripMenuItem_Click(object sender, EventArgs e) =>
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeToFastColoredTextBox(Language.JS);

        /// <summary>
        /// Change text style to VB Style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VBStyleToolStripMenuItem_Click(object sender, EventArgs e) =>
            (mainTabControl.SelectedTab as CustomTabPage)?.ChangeToFastColoredTextBox(Language.VB);

        #endregion

        /// <summary>
        /// Run compile form to compile a code from current text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunCodeToolStripButton_Click(object sender, EventArgs e)
        {
            // Check if this tab is custom tab page.
            if (!(mainTabControl.SelectedTab is CustomTabPage tabPage)) return;

            // Create and run compile form.
            var newCompileForm = new CompileForm(tabPage.GetText());
            newCompileForm.ShowDialog();
        }

        #endregion

        #region Tool Strip Menu

        #region File

        private void NewToolStripMenuItem_Click(object sender, EventArgs e) => CreateNewCustomTab();
        private void CreateNewWindowToolStripMenuItem_Click(object sender, EventArgs e) => CreateNewWindow();

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) => OpenFile();

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => Save();
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) => SaveAs();
        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e) => SaveAll();

        private void CloseThisTabToolStripMenuItem_Click(object sender, EventArgs e) => CloseThisTab();
        private void CloseAllTabsToolStripMenuItem_Click(object sender, EventArgs e) => CloseAllTabs();

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        #endregion

        #region Edit

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e) => Undo();
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e) => Redo();

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) => Cut();
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) => Copy();
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) => Paste();

        private void FontToolStripMenuItem_Click(object sender, EventArgs e) => ChangeFont();
        private void SelectAllTextToolStripMenuItem_Click(object sender, EventArgs e) => SelectAll();

        #endregion


        #region Tools

        #region Customize

        /// <summary>
        /// Change notepad theme to dark. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.Dark);

        /// <summary>
        /// Change notepad theme to light.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LightThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.Light);

        /// <summary>
        /// Change notepad theme to blue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlueThemeToolStripMenuItem_Click(object sender, EventArgs e) => ChangeTheme(Theme.Blue);

        #endregion

        #region Settings

        /// <summary>
        /// Change timer's interval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerIntervalToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (string) timerIntervalToolStripComboBox.SelectedItem;

            TimerIntervalChange(item);
        }

        /// <summary>
        /// Internal method to change timer's interval to save files.
        /// </summary>
        /// <param name="item">Selected item.</param>
        private void TimerIntervalChange(string item)
        {
            try
            {
                if (item.Equals("never", StringComparison.CurrentCultureIgnoreCase))
                {
                    timerSave.Enabled = false;
                    return;
                }

                var minute = int.Parse(item.Split()[1]);

                timerSave.Enabled = true;
                timerSave.Interval = minute * 6000;
            }
            catch
            {
                timerIntervalToolStripComboBox.SelectedItem =
                    timerIntervalToolStripComboBox.Items[timerIntervalToolStripComboBox.Items.Count - 1];
            }
        }

        /// <summary>
        /// Delete all backUp files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete all backup files and recreate this folder.

            Directory.Delete(Path.Combine(NotepadPath, BackUpPath), true);
            Directory.CreateDirectory(Path.Combine(NotepadPath, BackUpPath));

            GetRecentFiles();
        }

        /// <summary>
        /// Show tree view with recent files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTreeViewToolStripMenuItem_Click(object sender, EventArgs e) =>
            splitContainer.Panel1Collapsed = false;

        #endregion

        #endregion

        #region About

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        #endregion

        #endregion

        #region Tool Tab Control

        private void NewToolTabControlContextMenuStrip_Click(object sender, EventArgs e) => CreateNewCustomTab();
        private void OpenToolTabControlContextMenuStrip_Click(object sender, EventArgs e) => OpenFile();

        private void SaveToolTabControlContextMenuStrip_Click(object sender, EventArgs e) => Save();
        private void SaveAsToolTabControlContextMenuStrip_Click(object sender, EventArgs e) => SaveAs();

        private void CloseThisToolTabControlContextMenuStrip_Click(object sender, EventArgs e) => CloseThisTab();

        /// <summary>
        /// Get lines ang length of current file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LinesToolStripLabel.Text = "Line:";
            LengthToolStripLabel.Text = "Length:";

            (mainTabControl.SelectedTab as CustomTabPage)?.GetLength();
        }

        /// <summary>
        /// Close this tab if double click by middle mouse button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMain_DoubleClick(object sender, EventArgs e)
        {
            // Check click to middle mouse button.
            if (((MouseEventArgs) e).Button == MouseButtons.Middle)
            {
                CloseThisTab();
            }
        }

        /// <summary>
        /// Create new file/tab if click add file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMain_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex == mainTabControl.TabCount - 1) CreateNewCustomTab();
        }

        #endregion

        #region Tree View

        /// <summary>
        /// Open file from recent files if double click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecentFilesTreeView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileInternal((recentFilesTreeView.SelectedNode as CustomNode)?.FileSource);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hide tree view with recent files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideTreeView_Click(object sender, EventArgs e) => splitContainer.Panel1Collapsed = true;

        #endregion

        #region Settings

        /// <summary>
        /// Save all files, which opened and save all settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveAll();

                // Save current settings to file.
                File.WriteAllLines(Path.Combine(NotepadPath, SettingsPath, "Settings.txt"),
                    new[]
                    {
                        $"{CurrentTheme}",
                        $"{timerIntervalToolStripComboBox.SelectedItem}"
                    });
            }
            catch
            {
                // Save settings if something went wrong.

                File.WriteAllLines(Path.Combine(NotepadPath, SettingsPath, "Settings.txt"),
                    new[]
                    {
                        $"{Theme.Dark}",
                        $"{timerIntervalToolStripComboBox.Items[timerIntervalToolStripComboBox.Items.Count]}"
                    });
            }
        }

        /// <summary>
        /// Create directory for notepad data and set settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Create notepad folder settings.
                var notepadDirectory = Directory.CreateDirectory(NotepadPath);
                notepadDirectory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                notepadDirectory.CreateSubdirectory(SettingsPath);
                notepadDirectory.CreateSubdirectory(BackUpPath);

                SetSettings();

                GetOpenedFiles();

                GetRecentFiles();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open file, which be opened in previous session. 
        /// </summary>
        private void GetOpenedFiles()
        {
            var openedFilePath = Path.Combine(NotepadPath, SettingsPath, "OpenedFile.txt");

            if (!File.Exists(openedFilePath)) return;

            var filesPath = File.ReadAllLines(openedFilePath);

            // Open all files, which opened in previous session.
            foreach (var path in filesPath)
            {
                try
                {
                    OpenFileInternal(path);
                }
                catch
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// Set settings from previous session.
        /// </summary>
        private void SetSettings()
        {
            // Read file and set settings if setting's file exist or set default settings.
            if (File.Exists(Path.Combine(NotepadPath, SettingsPath, "Settings.txt")))
            {
                var settings = File.ReadAllLines(Path.Combine(NotepadPath, SettingsPath, "Settings.txt"));

                if (settings.Length == 2)
                {
                    switch (settings[0])
                    {
                        case "Dark":
                            ChangeTheme(Theme.Dark);
                            break;
                        case "Light":
                            ChangeTheme(Theme.Light);
                            break;
                        case "Blue":
                            ChangeTheme(Theme.Blue);
                            break;
                        default:
                            ChangeTheme(Theme.Light);
                            break;
                    }

                    foreach (var timerInterval in timerIntervalToolStripComboBox.Items)
                    {
                        if ((string) timerInterval != settings[1])
                        {
                            timerIntervalToolStripComboBox.SelectedItem =
                                timerIntervalToolStripComboBox.Items[^1];
                            continue;
                        }

                        timerIntervalToolStripComboBox.SelectedItem = timerInterval;
                    }
                }
                else
                {
                    ChangeTheme(Theme.Light);
                    timerIntervalToolStripComboBox.SelectedItem =
                        timerIntervalToolStripComboBox.Items[^1];
                }
            }
            else
            {
                ChangeTheme(Theme.Light);
                timerIntervalToolStripComboBox.SelectedItem =
                    timerIntervalToolStripComboBox.Items[^1];
            }
        }

        /// <summary>
        /// Get recent files, which be opened.
        /// </summary>
        private void GetRecentFiles()
        {
            // Get opened file's path.
            var filesPath = (from customTabPage in mainTabControl.TabPages.OfType<CustomTabPage>()
                where customTabPage.RichTextBox.FileSource != string.Empty
                select customTabPage.RichTextBox.FileSource).ToList();

            // Get recent file's path.
            if (File.Exists(Path.Combine(NotepadPath, SettingsPath, "RecentFile.txt")))
            {
                RecentFiles = File.ReadAllLines(Path.Combine(NotepadPath, SettingsPath, "RecentFile.txt")).ToList();
            }

            foreach (var path in filesPath.Where(path => RecentFiles.All(x => x != path)))
            {
                RecentFiles.Add(path);
            }

            // Rewrite file, which contains path to opened and recent files.
            File.WriteAllLines(Path.Combine(NotepadPath, SettingsPath, "OpenedFile.txt"), filesPath);
            File.WriteAllLines(Path.Combine(NotepadPath, SettingsPath, "RecentFile.txt"), RecentFiles);

            SetRecentFilesTreeView();
        }

        /// <summary>
        /// Set recent files to tree view.
        /// </summary>
        private void SetRecentFilesTreeView()
        {
            recentFilesTreeView.Nodes.Clear();
            // Get recent file's path.
            var recentFiles = File.ReadAllLines(Path.Combine(NotepadPath, SettingsPath, "RecentFile.txt"));

            // Check all path and add to tree view..
            foreach (var filePath in recentFiles)
            {
                var newNode = new CustomNode(filePath) {Text = filePath};

                var backUpPath = Path.Combine(NotepadPath, BackUpPath, Path.GetFileNameWithoutExtension(filePath));

                // Check directory to exists.
                if (Directory.Exists(backUpPath))
                {
                    var backUpDirectory = new DirectoryInfo(backUpPath);

                    // Check all directory which belong to certain file.
                    foreach (var childDirectory in backUpDirectory.GetDirectories())
                    {
                        // Rewrite directory name to time creation. 
                        var timeCreation = DateTime.ParseExact(childDirectory.Name, "ddMMyyyyTHHmmss",
                            CultureInfo.InvariantCulture);

                        // Create child node - backUp file.
                        var childNode =
                            new CustomNode(Path.Combine(childDirectory.FullName, Path.GetFileName(filePath)))
                            {
                                Text = timeCreation.ToString(CultureInfo.InvariantCulture)
                            };

                        newNode.Nodes.Add(childNode);
                    }
                }

                recentFilesTreeView.Nodes.Add(newNode);
            }
        }

        /// <summary>
        /// Change theme of notepad.
        /// </summary>
        /// <param name="theme"></param>
        private void ChangeTheme(Theme theme)
        {
            var backColor = Color.Empty;
            var backColorSecond = Color.Empty;
            var textBoxBackColor = Color.Empty;
            var textBoxForeColor = Color.Empty;
            var foreColor = Color.Empty;

            // Set colors to selected theme.
            switch (theme)
            {
                case Theme.Dark:
                    backColor = Color.FromArgb(30, 30, 30);
                    backColorSecond = Color.FromArgb(62, 62, 66);
                    foreColor = Color.FromArgb(255, 255, 255);

                    textBoxBackColor = Color.FromArgb(62, 62, 66);
                    textBoxForeColor = Color.FromArgb(255, 255, 255);

                    break;

                case Theme.Light:
                    backColor = Color.FromArgb(245, 245, 245);
                    backColorSecond = Color.FromArgb(255, 255, 255);
                    foreColor = Color.FromArgb(52, 62, 71);

                    textBoxBackColor = Color.FromArgb(255, 255, 255);
                    textBoxForeColor = Color.FromArgb(52, 62, 71);


                    break;

                case Theme.Blue:
                    backColor = Color.FromArgb(93, 107, 153);
                    backColorSecond = Color.FromArgb(204, 213, 240);
                    foreColor = Color.FromArgb(255, 255, 255);


                    textBoxBackColor = Color.FromArgb(255, 255, 255);
                    textBoxForeColor = Color.FromArgb(52, 62, 71);

                    break;
            }

            // Set color to several layouts of controls.
            foreach (Control control in Controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;

                foreach (Control secondLayoutControl in control.Controls)
                {
                    secondLayoutControl.BackColor = backColorSecond;
                    secondLayoutControl.ForeColor = foreColor;

                    foreach (Control thirdLayoutControl in secondLayoutControl.Controls)
                    {
                        thirdLayoutControl.BackColor = backColor;
                        thirdLayoutControl.ForeColor = foreColor;

                        foreach (Control fourthLayoutControl in thirdLayoutControl.Controls)
                        {
                            fourthLayoutControl.BackColor = backColorSecond;
                            fourthLayoutControl.ForeColor = foreColor;
                        }
                    }
                }
            }

            // Change tab pages color.
            ChangeTabPageColor(textBoxBackColor, textBoxForeColor);

            // Redraw controls.
            ResumeLayout();
            CurrentTheme = theme;
        }

        /// <summary>
        /// Internal method to change certain tab page theme.
        /// </summary>
        /// <param name="backColor"></param>
        /// <param name="foreColor"></param>
        private void ChangeTabPageColor(Color backColor, Color foreColor)
        {
            // Check all tab page and change their colors.
            foreach (var tabPage in mainTabControl.TabPages.OfType<CustomTabPage>())
            {
                tabPage.ChangeColor(backColor, foreColor);
            }
        }

        #endregion
    }
}