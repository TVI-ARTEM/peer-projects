
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ManageSubTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubTaskForm));
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.ShowTaskButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(142, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(658, 450);
            this.ChildFormPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(3)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.RemoveTaskButton);
            this.panel1.Controls.Add(this.CreateTaskButton);
            this.panel1.Controls.Add(this.ShowTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 450);
            this.panel1.TabIndex = 4;
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RemoveTaskButton.FlatAppearance.BorderSize = 0;
            this.RemoveTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveTaskButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RemoveTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveTaskButton.Image")));
            this.RemoveTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTaskButton.Location = new System.Drawing.Point(0, 155);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.RemoveTaskButton.Size = new System.Drawing.Size(142, 75);
            this.RemoveTaskButton.TabIndex = 4;
            this.RemoveTaskButton.Text = "Remove Task";
            this.RemoveTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateTaskButton.FlatAppearance.BorderSize = 0;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTaskButton.Location = new System.Drawing.Point(0, 80);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CreateTaskButton.Size = new System.Drawing.Size(142, 75);
            this.CreateTaskButton.TabIndex = 3;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // ShowTaskButton
            // 
            this.ShowTaskButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowTaskButton.FlatAppearance.BorderSize = 0;
            this.ShowTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowTaskButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ShowTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowTaskButton.Image")));
            this.ShowTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowTaskButton.Location = new System.Drawing.Point(0, 0);
            this.ShowTaskButton.Name = "ShowTaskButton";
            this.ShowTaskButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ShowTaskButton.Size = new System.Drawing.Size(142, 80);
            this.ShowTaskButton.TabIndex = 2;
            this.ShowTaskButton.Text = "Show Tasks";
            this.ShowTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowTaskButton.UseVisualStyleBackColor = true;
            this.ShowTaskButton.Click += new System.EventHandler(this.ShowTaskButton_Click);
            // 
            // ManageSubTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSubTaskForm";
            this.Text = "ManageSubTaskForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RemoveTaskButton;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Button ShowTaskButton;
    }
}