
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ManageTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTaskForm));
            this.ManageUsersButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ManageSubTaskButton = new System.Windows.Forms.Button();
            this.ManageProjectButton = new System.Windows.Forms.Button();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManageUsersButton
            // 
            this.ManageUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageUsersButton.FlatAppearance.BorderSize = 0;
            this.ManageUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUsersButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageUsersButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManageUsersButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageUsersButton.Image")));
            this.ManageUsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUsersButton.Location = new System.Drawing.Point(0, 150);
            this.ManageUsersButton.Name = "ManageUsersButton";
            this.ManageUsersButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageUsersButton.Size = new System.Drawing.Size(174, 75);
            this.ManageUsersButton.TabIndex = 4;
            this.ManageUsersButton.Text = "Manage Users";
            this.ManageUsersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageUsersButton.UseVisualStyleBackColor = true;
            this.ManageUsersButton.Click += new System.EventHandler(this.ManageUsersButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.PreviousButton);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.ManageUsersButton);
            this.panel1.Controls.Add(this.ManageSubTaskButton);
            this.panel1.Controls.Add(this.ManageProjectButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 450);
            this.panel1.TabIndex = 2;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(0, 225);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SettingsButton.Size = new System.Drawing.Size(174, 60);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ManageSubTaskButton
            // 
            this.ManageSubTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageSubTaskButton.FlatAppearance.BorderSize = 0;
            this.ManageSubTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageSubTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageSubTaskButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManageSubTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageSubTaskButton.Image")));
            this.ManageSubTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageSubTaskButton.Location = new System.Drawing.Point(0, 75);
            this.ManageSubTaskButton.Name = "ManageSubTaskButton";
            this.ManageSubTaskButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageSubTaskButton.Size = new System.Drawing.Size(174, 75);
            this.ManageSubTaskButton.TabIndex = 3;
            this.ManageSubTaskButton.Text = "Manage SubTasks";
            this.ManageSubTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageSubTaskButton.UseVisualStyleBackColor = true;
            this.ManageSubTaskButton.Click += new System.EventHandler(this.ManageSubTasksButton_Click);
            // 
            // ManageProjectButton
            // 
            this.ManageProjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageProjectButton.FlatAppearance.BorderSize = 0;
            this.ManageProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageProjectButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ManageProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageProjectButton.Image")));
            this.ManageProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageProjectButton.Location = new System.Drawing.Point(0, 0);
            this.ManageProjectButton.Name = "ManageProjectButton";
            this.ManageProjectButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageProjectButton.Size = new System.Drawing.Size(174, 75);
            this.ManageProjectButton.TabIndex = 2;
            this.ManageProjectButton.Text = "Manage Projects";
            this.ManageProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ManageProjectButton.UseVisualStyleBackColor = true;
            this.ManageProjectButton.Click += new System.EventHandler(this.ManageProjectButton_Click);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(174, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(626, 450);
            this.ChildFormPanel.TabIndex = 3;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviousButton.FlatAppearance.BorderSize = 0;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PreviousButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreviousButton.Location = new System.Drawing.Point(0, 285);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PreviousButton.Size = new System.Drawing.Size(174, 60);
            this.PreviousButton.TabIndex = 6;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // ManageTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ManageTaskForm";
            this.Text = "Manage Task";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ManageTaskForm_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageUsersButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManageSubTaskButton;
        private System.Windows.Forms.Button ManageProjectButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Button PreviousButton;
    }
}