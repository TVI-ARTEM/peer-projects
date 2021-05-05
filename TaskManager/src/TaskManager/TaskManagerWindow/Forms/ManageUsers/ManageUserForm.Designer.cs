
namespace TaskManagerWindow.Forms.ManageUsers
{
    partial class ManageUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FireUserButton = new System.Windows.Forms.Button();
            this.HireUserButton = new System.Windows.Forms.Button();
            this.ShowUserButton = new System.Windows.Forms.Button();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.FireUserButton);
            this.panel1.Controls.Add(this.HireUserButton);
            this.panel1.Controls.Add(this.ShowUserButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // FireUserButton
            // 
            this.FireUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FireUserButton.FlatAppearance.BorderSize = 0;
            this.FireUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FireUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FireUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.FireUserButton.Image = ((System.Drawing.Image)(resources.GetObject("FireUserButton.Image")));
            this.FireUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FireUserButton.Location = new System.Drawing.Point(0, 120);
            this.FireUserButton.Name = "FireUserButton";
            this.FireUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.FireUserButton.Size = new System.Drawing.Size(200, 60);
            this.FireUserButton.TabIndex = 4;
            this.FireUserButton.Text = "Fire User";
            this.FireUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FireUserButton.UseVisualStyleBackColor = true;
            this.FireUserButton.Click += new System.EventHandler(this.FireUserButton_Click);
            // 
            // HireUserButton
            // 
            this.HireUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HireUserButton.FlatAppearance.BorderSize = 0;
            this.HireUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HireUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HireUserButton.Image = ((System.Drawing.Image)(resources.GetObject("HireUserButton.Image")));
            this.HireUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HireUserButton.Location = new System.Drawing.Point(0, 60);
            this.HireUserButton.Name = "HireUserButton";
            this.HireUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HireUserButton.Size = new System.Drawing.Size(200, 60);
            this.HireUserButton.TabIndex = 3;
            this.HireUserButton.Text = "Hire User";
            this.HireUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HireUserButton.UseVisualStyleBackColor = true;
            this.HireUserButton.Click += new System.EventHandler(this.HireUserButton_Click);
            // 
            // ShowUserButton
            // 
            this.ShowUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowUserButton.FlatAppearance.BorderSize = 0;
            this.ShowUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowUserButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowUserButton.Image")));
            this.ShowUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowUserButton.Location = new System.Drawing.Point(0, 0);
            this.ShowUserButton.Name = "ShowUserButton";
            this.ShowUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ShowUserButton.Size = new System.Drawing.Size(200, 60);
            this.ShowUserButton.TabIndex = 2;
            this.ShowUserButton.Text = "Show Users";
            this.ShowUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowUserButton.UseVisualStyleBackColor = true;
            this.ShowUserButton.Click += new System.EventHandler(this.ShowUserButton_Click);
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(200, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(600, 450);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ManageUserForm";
            this.Text = "Manage User";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowUserButton;
        private System.Windows.Forms.Button FireUserButton;
        private System.Windows.Forms.Button HireUserButton;
        private System.Windows.Forms.Panel ChildFormPanel;
    }
}