
namespace Excel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.RollButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ShowChartButton = new System.Windows.Forms.Button();
            this.ShowSheetButton = new System.Windows.Forms.Button();
            this.ExitToolPanelButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainPanel.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(162)))), ((int)(((byte)(215)))));
            this.MainPanel.Controls.Add(this.HideButton);
            this.MainPanel.Controls.Add(this.RollButton);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.PageNameLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(980, 75);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.FlatAppearance.BorderSize = 0;
            this.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideButton.Image = global::Excel.Properties.Resources.hide_button;
            this.HideButton.Location = new System.Drawing.Point(914, 3);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(18, 18);
            this.HideButton.TabIndex = 4;
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // RollButton
            // 
            this.RollButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.Image = global::Excel.Properties.Resources.roll_button;
            this.RollButton.Location = new System.Drawing.Point(937, 3);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(18, 18);
            this.RollButton.TabIndex = 3;
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::Excel.Properties.Resources.exit_button;
            this.ExitButton.Location = new System.Drawing.Point(959, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 18);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.PageNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PageNameLabel.Location = new System.Drawing.Point(374, 12);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Size = new System.Drawing.Size(115, 46);
            this.PageNameLabel.TabIndex = 1;
            this.PageNameLabel.Text = "Home";
            this.PageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PageNameLabel_MouseDown);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(0, 75);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(980, 636);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.ToolPanel.Controls.Add(this.ShowChartButton);
            this.ToolPanel.Controls.Add(this.ShowSheetButton);
            this.ToolPanel.Controls.Add(this.ExitToolPanelButton);
            this.ToolPanel.Controls.Add(this.HomeButton);
            this.ToolPanel.Controls.Add(this.LogoPanel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(200, 711);
            this.ToolPanel.TabIndex = 0;
            // 
            // ShowChartButton
            // 
            this.ShowChartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowChartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowChartButton.FlatAppearance.BorderSize = 0;
            this.ShowChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowChartButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.ShowChartButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowChartButton.Image = global::Excel.Properties.Resources.chart_button;
            this.ShowChartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowChartButton.Location = new System.Drawing.Point(0, 195);
            this.ShowChartButton.Name = "ShowChartButton";
            this.ShowChartButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowChartButton.Size = new System.Drawing.Size(200, 60);
            this.ShowChartButton.TabIndex = 4;
            this.ShowChartButton.Text = "Show Charts";
            this.ShowChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowChartButton.UseVisualStyleBackColor = true;
            this.ShowChartButton.Click += new System.EventHandler(this.ShowChartButton_Click);
            // 
            // ShowSheetButton
            // 
            this.ShowSheetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowSheetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowSheetButton.FlatAppearance.BorderSize = 0;
            this.ShowSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowSheetButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.ShowSheetButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowSheetButton.Image = global::Excel.Properties.Resources.sheet_button;
            this.ShowSheetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowSheetButton.Location = new System.Drawing.Point(0, 135);
            this.ShowSheetButton.Name = "ShowSheetButton";
            this.ShowSheetButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowSheetButton.Size = new System.Drawing.Size(200, 60);
            this.ShowSheetButton.TabIndex = 3;
            this.ShowSheetButton.Text = "Show Sheets";
            this.ShowSheetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowSheetButton.UseVisualStyleBackColor = true;
            this.ShowSheetButton.Click += new System.EventHandler(this.ShowSheetButton_Click);
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
            this.ExitToolPanelButton.Location = new System.Drawing.Point(0, 651);
            this.ExitToolPanelButton.Name = "ExitToolPanelButton";
            this.ExitToolPanelButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitToolPanelButton.Size = new System.Drawing.Size(200, 60);
            this.ExitToolPanelButton.TabIndex = 2;
            this.ExitToolPanelButton.Text = "Exit";
            this.ExitToolPanelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitToolPanelButton.UseVisualStyleBackColor = true;
            this.ExitToolPanelButton.Click += new System.EventHandler(this.ExitToolPanelButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.HomeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.Image = global::Excel.Properties.Resources.home_button;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 75);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(200, 60);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.LogoLabel.Location = new System.Drawing.Point(6, 20);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(186, 36);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Analyze Data";
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoLabel_MouseDown);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ToolPanel);
            this.MainSplitContainer.Panel1MinSize = 20;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ChildFormPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.MainPanel);
            this.MainSplitContainer.Size = new System.Drawing.Size(1184, 711);
            this.MainSplitContainer.SplitterDistance = 200;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.MainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "MainForm";
            this.Text = "Analyze Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ToolPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Button ExitToolPanelButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Button ShowChartButton;
        private System.Windows.Forms.Button ShowSheetButton;
    }
}

