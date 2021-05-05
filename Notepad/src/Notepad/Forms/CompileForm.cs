using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Notepad.Forms
{
    public partial class CompileForm : Form
    {
        private readonly string _sourceCode;

        private static readonly string Output = Path.Combine(MainForm.NotepadPath, MainForm.SettingsPath, "Out.exe");

        /// <summary>
        /// Form to show compile result.
        /// </summary>
        /// <param name="sourceCode">Source code.</param>
        public CompileForm(string sourceCode)
        {
            InitializeComponent();
            _sourceCode = sourceCode;
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Start compile after loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompileForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Copy from MSDN.

                var provider = CodeDomProvider.CreateProvider("CSharp");
                //var codeCompiler = codeProvider.CreateCompiler();

                ErrorRichTextBox.Text = "";
                var parameters = new CompilerParameters {GenerateExecutable = true, OutputAssembly = Output};

                // Compile result.
                var compilerResults = provider.CompileAssemblyFromSource(parameters, _sourceCode);

                // Show error while compiling.
                if (compilerResults.Errors.Count > 0)
                {
                    ErrorRichTextBox.ForeColor = Color.Red;
                    foreach (CompilerError compErr in compilerResults.Errors)
                        ErrorRichTextBox.Text = ErrorRichTextBox.Text +
                                                "Line number " + compErr.Line +
                                                ", Error Number: " + compErr.ErrorNumber +
                                                ", '" + compErr.ErrorText + ";" +
                                                Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    ErrorRichTextBox.ForeColor = Color.Blue;
                    ErrorRichTextBox.Text = "Success!";

                    // Start cdm.
                    Process.Start(Output);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unfortunately this func isn't work in net core :(", "Error!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}