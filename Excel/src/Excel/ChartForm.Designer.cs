
namespace Excel
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ExitToolPanelButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RollButton = new System.Windows.Forms.Button();
            this.ChartTabControl = new System.Windows.Forms.TabControl();
            this.TabPageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseThisTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TabPageContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.ToolPanel.Controls.Add(this.ExitToolPanelButton);
            this.ToolPanel.Controls.Add(this.LogoPanel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(200, 911);
            this.ToolPanel.TabIndex = 0;
            // 
            // ExitToolPanelButton
            // 
            this.ExitToolPanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitToolPanelButton.FlatAppearance.BorderSize = 0;
            this.ExitToolPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitToolPanelButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.ExitToolPanelButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitToolPanelButton.Image = global::Excel.Properties.Resources.exit_to_app_button;
            this.ExitToolPanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolPanelButton.Location = new System.Drawing.Point(0, 851);
            this.ExitToolPanelButton.Name = "ExitToolPanelButton";
            this.ExitToolPanelButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitToolPanelButton.Size = new System.Drawing.Size(200, 60);
            this.ExitToolPanelButton.TabIndex = 3;
            this.ExitToolPanelButton.Text = "Exit";
            this.ExitToolPanelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitToolPanelButton.UseVisualStyleBackColor = true;
            this.ExitToolPanelButton.Click += new System.EventHandler(this.ExitToolPanelButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(200, 75);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
            this.LogoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoLabel.Location = new System.Drawing.Point(20, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(161, 36);
            this.LogoLabel.TabIndex = 1;
            this.LogoLabel.Text = "Live Charts";
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoLabel_MouseDown);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(162)))), ((int)(((byte)(215)))));
            this.MainPanel.Controls.Add(this.HideButton);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.RollButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(784, 75);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Image = global::Excel.Properties.Resources.hide_button;
            this.HideButton.Location = new System.Drawing.Point(718, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(18, 18);
            this.HideButton.TabIndex = 7;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::Excel.Properties.Resources.exit_button;
            this.ExitButton.Location = new System.Drawing.Point(763, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 18);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RollButton
            // 
            this.RollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.Image = global::Excel.Properties.Resources.roll_button;
            this.RollButton.Location = new System.Drawing.Point(741, 3);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(18, 18);
            this.RollButton.TabIndex = 6;
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // ChartTabControl
            // 
            this.ChartTabControl.ContextMenuStrip = this.TabPageContextMenuStrip;
            this.ChartTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartTabControl.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ChartTabControl.Location = new System.Drawing.Point(200, 75);
            this.ChartTabControl.Name = "ChartTabControl";
            this.ChartTabControl.SelectedIndex = 0;
            this.ChartTabControl.Size = new System.Drawing.Size(784, 836);
            this.ChartTabControl.TabIndex = 2;
            // 
            // TabPageContextMenuStrip
            // 
            this.TabPageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseThisTabToolStripMenuItem});
            this.TabPageContextMenuStrip.Name = "TabPageContextMenuStrip";
            this.TabPageContextMenuStrip.Size = new System.Drawing.Size(149, 26);
            // 
            // CloseThisTabToolStripMenuItem
            // 
            this.CloseThisTabToolStripMenuItem.Image = global::Excel.Properties.Resources.Close_16x;
            this.CloseThisTabToolStripMenuItem.Name = "CloseThisTabToolStripMenuItem";
            this.CloseThisTabToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CloseThisTabToolStripMenuItem.Text = "Close This Tab";
            this.CloseThisTabToolStripMenuItem.Click += new System.EventHandler(this.CloseThisTabToolStripMenuItem_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 911);
            this.Controls.Add(this.ChartTabControl);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 950);
            this.Name = "ChartForm";
            this.Text = "Charts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChartForm_FormClosing);
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.ToolPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.TabPageContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Button ExitToolPanelButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.TabControl ChartTabControl;
        private System.Windows.Forms.ContextMenuStrip TabPageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseThisTabToolStripMenuItem;
    }
}