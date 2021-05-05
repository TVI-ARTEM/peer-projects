
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ManageProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProjectForm));
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveProjectButton = new System.Windows.Forms.Button();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.ShowProjectButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(160, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(640, 450);
            this.ChildFormPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(3)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.RemoveProjectButton);
            this.panel1.Controls.Add(this.CreateProjectButton);
            this.panel1.Controls.Add(this.ShowProjectButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 450);
            this.panel1.TabIndex = 2;
            // 
            // RemoveProjectButton
            // 
            this.RemoveProjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveProjectButton.FlatAppearance.BorderSize = 0;
            this.RemoveProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveProjectButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RemoveProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveProjectButton.Image")));
            this.RemoveProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveProjectButton.Location = new System.Drawing.Point(0, 155);
            this.RemoveProjectButton.Name = "RemoveProjectButton";
            this.RemoveProjectButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RemoveProjectButton.Size = new System.Drawing.Size(160, 75);
            this.RemoveProjectButton.TabIndex = 4;
            this.RemoveProjectButton.Text = "Remove Project";
            this.RemoveProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveProjectButton.UseVisualStyleBackColor = true;
            this.RemoveProjectButton.Click += new System.EventHandler(this.RemoveProjectButton_Click);
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateProjectButton.FlatAppearance.BorderSize = 0;
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateProjectButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreateProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateProjectButton.Image")));
            this.CreateProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateProjectButton.Location = new System.Drawing.Point(0, 80);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CreateProjectButton.Size = new System.Drawing.Size(160, 75);
            this.CreateProjectButton.TabIndex = 3;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateProjectButton.UseVisualStyleBackColor = true;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // ShowProjectButton
            // 
            this.ShowProjectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowProjectButton.FlatAppearance.BorderSize = 0;
            this.ShowProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowProjectButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowProjectButton.Image")));
            this.ShowProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowProjectButton.Location = new System.Drawing.Point(0, 0);
            this.ShowProjectButton.Name = "ShowProjectButton";
            this.ShowProjectButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowProjectButton.Size = new System.Drawing.Size(160, 80);
            this.ShowProjectButton.TabIndex = 2;
            this.ShowProjectButton.Text = "Show Projects";
            this.ShowProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowProjectButton.UseVisualStyleBackColor = true;
            this.ShowProjectButton.Click += new System.EventHandler(this.ShowProjectButton_Click);
            // 
            // ManageProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProjectForm";
            this.Text = "Manage Project";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveProjectButton;
        private System.Windows.Forms.Button CreateProjectButton;
        private System.Windows.Forms.Button ShowProjectButton;
    }
}