
namespace TaskManagerWindow.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ManagePanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ManageUserButton = new System.Windows.Forms.Button();
            this.ManageTaskButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.HideCircleButton = new System.Windows.Forms.Button();
            this.RollCircleButton = new System.Windows.Forms.Button();
            this.ExitCircleButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PageNameLabel = new System.Windows.Forms.Label();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.ManagePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagePanel
            // 
            this.ManagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.ManagePanel.Controls.Add(this.ExitButton);
            this.ManagePanel.Controls.Add(this.AboutButton);
            this.ManagePanel.Controls.Add(this.ManageUserButton);
            this.ManagePanel.Controls.Add(this.ManageTaskButton);
            this.ManagePanel.Controls.Add(this.HomeButton);
            this.ManagePanel.Controls.Add(this.LogoPanel);
            this.ManagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ManagePanel.Location = new System.Drawing.Point(0, 0);
            this.ManagePanel.Name = "ManagePanel";
            this.ManagePanel.Size = new System.Drawing.Size(211, 711);
            this.ManagePanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 651);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(211, 60);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.Location = new System.Drawing.Point(0, 255);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AboutButton.Size = new System.Drawing.Size(211, 60);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ManageUserButton
            // 
            this.ManageUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUserButton.FlatAppearance.BorderSize = 0;
            this.ManageUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManageUserButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageUserButton.Image")));
            this.ManageUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUserButton.Location = new System.Drawing.Point(0, 195);
            this.ManageUserButton.Name = "ManageUserButton";
            this.ManageUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageUserButton.Size = new System.Drawing.Size(211, 60);
            this.ManageUserButton.TabIndex = 3;
            this.ManageUserButton.Text = "Manage User";
            this.ManageUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageUserButton.UseVisualStyleBackColor = true;
            this.ManageUserButton.Click += new System.EventHandler(this.ManageUserButton_Click);
            // 
            // ManageTaskButton
            // 
            this.ManageTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageTaskButton.FlatAppearance.BorderSize = 0;
            this.ManageTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageTaskButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManageTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageTaskButton.Image")));
            this.ManageTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageTaskButton.Location = new System.Drawing.Point(0, 135);
            this.ManageTaskButton.Name = "ManageTaskButton";
            this.ManageTaskButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageTaskButton.Size = new System.Drawing.Size(211, 60);
            this.ManageTaskButton.TabIndex = 2;
            this.ManageTaskButton.Text = "Manage Task";
            this.ManageTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageTaskButton.UseVisualStyleBackColor = true;
            this.ManageTaskButton.Click += new System.EventHandler(this.ManageTaskButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 75);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HomeButton.Size = new System.Drawing.Size(211, 60);
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
            this.LogoPanel.Size = new System.Drawing.Size(211, 75);
            this.LogoPanel.TabIndex = 0;
            this.LogoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPanel_MouseDown);
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoLabel.Location = new System.Drawing.Point(8, 19);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(192, 36);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Task Manager";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoLabel_MouseDown);
            // 
            // HideCircleButton
            // 
            this.HideCircleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideCircleButton.FlatAppearance.BorderSize = 0;
            this.HideCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("HideCircleButton.Image")));
            this.HideCircleButton.Location = new System.Drawing.Point(1004, 0);
            this.HideCircleButton.Name = "HideCircleButton";
            this.HideCircleButton.Size = new System.Drawing.Size(18, 18);
            this.HideCircleButton.TabIndex = 7;
            this.HideCircleButton.UseVisualStyleBackColor = true;
            this.HideCircleButton.Click += new System.EventHandler(this.HideCircleButton_Click);
            // 
            // RollCircleButton
            // 
            this.RollCircleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RollCircleButton.FlatAppearance.BorderSize = 0;
            this.RollCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("RollCircleButton.Image")));
            this.RollCircleButton.Location = new System.Drawing.Point(1028, 0);
            this.RollCircleButton.Name = "RollCircleButton";
            this.RollCircleButton.Size = new System.Drawing.Size(18, 18);
            this.RollCircleButton.TabIndex = 8;
            this.RollCircleButton.UseVisualStyleBackColor = true;
            this.RollCircleButton.Click += new System.EventHandler(this.RollCircleButton_Click);
            // 
            // ExitCircleButton
            // 
            this.ExitCircleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitCircleButton.FlatAppearance.BorderSize = 0;
            this.ExitCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitCircleButton.Image")));
            this.ExitCircleButton.Location = new System.Drawing.Point(1052, 0);
            this.ExitCircleButton.Name = "ExitCircleButton";
            this.ExitCircleButton.Size = new System.Drawing.Size(18, 18);
            this.ExitCircleButton.TabIndex = 9;
            this.ExitCircleButton.UseVisualStyleBackColor = true;
            this.ExitCircleButton.Click += new System.EventHandler(this.ExitCircleButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(162)))), ((int)(((byte)(215)))));
            this.MainPanel.Controls.Add(this.HideCircleButton);
            this.MainPanel.Controls.Add(this.PageNameLabel);
            this.MainPanel.Controls.Add(this.ExitCircleButton);
            this.MainPanel.Controls.Add(this.RollCircleButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(211, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1073, 75);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // PageNameLabel
            // 
            this.PageNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageNameLabel.AutoSize = true;
            this.PageNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PageNameLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PageNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PageNameLabel.Location = new System.Drawing.Point(418, 11);
            this.PageNameLabel.Name = "PageNameLabel";
            this.PageNameLabel.Padding = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.PageNameLabel.Size = new System.Drawing.Size(235, 46);
            this.PageNameLabel.TabIndex = 0;
            this.PageNameLabel.Text = "Home";
            this.PageNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PageNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PageNameLabel_MouseDown);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(211, 75);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1073, 636);
            this.ChildFormPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ManagePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.ManagePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagePanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label PageNameLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ManageUserButton;
        private System.Windows.Forms.Button ManageTaskButton;
        private System.Windows.Forms.Button ExitCircleButton;
        private System.Windows.Forms.Button HideCircleButton;
        private System.Windows.Forms.Button RollCircleButton;
        private System.Windows.Forms.Panel ChildFormPanel;
    }
}

