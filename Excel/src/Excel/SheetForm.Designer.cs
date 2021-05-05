
namespace Excel
{
    partial class SheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OpenFileToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SheetsTabControl = new System.Windows.Forms.TabControl();
            this.SheetContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanel.SuspendLayout();
            this.SheetContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ToolPanel.Controls.Add(this.OpenFileButton);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(50, 450);
            this.ToolPanel.TabIndex = 0;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileButton.FlatAppearance.BorderSize = 0;
            this.OpenFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFileButton.Image = global::Excel.Properties.Resources.file_open;
            this.OpenFileButton.Location = new System.Drawing.Point(0, 0);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(50, 50);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileToolTip.SetToolTip(this.OpenFileButton, "Open File");
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SheetsTabControl
            // 
            this.SheetsTabControl.ContextMenuStrip = this.SheetContextMenuStrip;
            this.SheetsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SheetsTabControl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.SheetsTabControl.Location = new System.Drawing.Point(50, 0);
            this.SheetsTabControl.Name = "SheetsTabControl";
            this.SheetsTabControl.SelectedIndex = 0;
            this.SheetsTabControl.Size = new System.Drawing.Size(750, 450);
            this.SheetsTabControl.TabIndex = 1;
            // 
            // SheetContextMenuStrip
            // 
            this.SheetContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.SheetContextMenuStrip.Name = "SheetContextMenuStrip";
            this.SheetContextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Image = global::Excel.Properties.Resources.Close_16x;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Close This Tab";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // SheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SheetsTabControl);
            this.Controls.Add(this.ToolPanel);
            this.Name = "SheetForm";
            this.Text = "Sheets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SheetForm_FormClosing);
            this.Load += new System.EventHandler(this.SheetForm_Load);
            this.ToolPanel.ResumeLayout(false);
            this.SheetContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.ToolTip OpenFileToolTip;
        private System.Windows.Forms.TabControl SheetsTabControl;
        private System.Windows.Forms.ContextMenuStrip SheetContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}