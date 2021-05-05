
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ManageTaskUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTaskUserForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.AddUserSplitContainer = new System.Windows.Forms.SplitContainer();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.RemoveSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TaskUserDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserSplitContainer)).BeginInit();
            this.AddUserSplitContainer.Panel1.SuspendLayout();
            this.AddUserSplitContainer.Panel2.SuspendLayout();
            this.AddUserSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveSplitContainer)).BeginInit();
            this.RemoveSplitContainer.Panel1.SuspendLayout();
            this.RemoveSplitContainer.Panel2.SuspendLayout();
            this.RemoveSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.AddUserSplitContainer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.RemoveSplitContainer);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.TabIndex = 0;
            // 
            // AddUserSplitContainer
            // 
            this.AddUserSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.AddUserSplitContainer.Name = "AddUserSplitContainer";
            this.AddUserSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AddUserSplitContainer.Panel1
            // 
            this.AddUserSplitContainer.Panel1.Controls.Add(this.UsersDataGridView);
            this.AddUserSplitContainer.Panel1MinSize = 300;
            // 
            // AddUserSplitContainer.Panel2
            // 
            this.AddUserSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(188)))), ((int)(((byte)(112)))));
            this.AddUserSplitContainer.Panel2.Controls.Add(this.AddUserButton);
            this.AddUserSplitContainer.Panel2MinSize = 50;
            this.AddUserSplitContainer.Size = new System.Drawing.Size(400, 450);
            this.AddUserSplitContainer.SplitterDistance = 350;
            this.AddUserSplitContainer.TabIndex = 0;
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AllowUserToAddRows = false;
            this.UsersDataGridView.AllowUserToDeleteRows = false;
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(107)))));
            this.UsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.UsersDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.RowTemplate.Height = 25;
            this.UsersDataGridView.Size = new System.Drawing.Size(400, 350);
            this.UsersDataGridView.TabIndex = 2;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserButton.FlatAppearance.BorderSize = 0;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Image = ((System.Drawing.Image)(resources.GetObject("AddUserButton.Image")));
            this.AddUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserButton.Location = new System.Drawing.Point(109, 18);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AddUserButton.Size = new System.Drawing.Size(170, 60);
            this.AddUserButton.TabIndex = 7;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // RemoveSplitContainer
            // 
            this.RemoveSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RemoveSplitContainer.Name = "RemoveSplitContainer";
            this.RemoveSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RemoveSplitContainer.Panel1
            // 
            this.RemoveSplitContainer.Panel1.Controls.Add(this.TaskUserDataGridView);
            this.RemoveSplitContainer.Panel1MinSize = 300;
            // 
            // RemoveSplitContainer.Panel2
            // 
            this.RemoveSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.RemoveSplitContainer.Panel2.Controls.Add(this.RemoveUserButton);
            this.RemoveSplitContainer.Panel2MinSize = 50;
            this.RemoveSplitContainer.Size = new System.Drawing.Size(396, 450);
            this.RemoveSplitContainer.SplitterDistance = 350;
            this.RemoveSplitContainer.TabIndex = 1;
            // 
            // TaskUserDataGridView
            // 
            this.TaskUserDataGridView.AllowUserToAddRows = false;
            this.TaskUserDataGridView.AllowUserToDeleteRows = false;
            this.TaskUserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskUserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TaskUserDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(107)))));
            this.TaskUserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskUserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TaskUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskUserDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.TaskUserDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TaskUserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TaskUserDataGridView.Name = "TaskUserDataGridView";
            this.TaskUserDataGridView.ReadOnly = true;
            this.TaskUserDataGridView.RowTemplate.Height = 25;
            this.TaskUserDataGridView.Size = new System.Drawing.Size(396, 350);
            this.TaskUserDataGridView.TabIndex = 2;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveUserButton.FlatAppearance.BorderSize = 0;
            this.RemoveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveUserButton.ForeColor = System.Drawing.Color.White;
            this.RemoveUserButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUserButton.Image")));
            this.RemoveUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveUserButton.Location = new System.Drawing.Point(98, 18);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RemoveUserButton.Size = new System.Drawing.Size(216, 60);
            this.RemoveUserButton.TabIndex = 6;
            this.RemoveUserButton.Text = "Remove User";
            this.RemoveUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // ManageTaskUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "ManageTaskUserForm";
            this.Text = "Manage Task User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageTaskUserForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ManageTaskUserForm_Paint);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.AddUserSplitContainer.Panel1.ResumeLayout(false);
            this.AddUserSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddUserSplitContainer)).EndInit();
            this.AddUserSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.RemoveSplitContainer.Panel1.ResumeLayout(false);
            this.RemoveSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveSplitContainer)).EndInit();
            this.RemoveSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer AddUserSplitContainer;
        private System.Windows.Forms.SplitContainer RemoveSplitContainer;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.DataGridView TaskUserDataGridView;
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Button AddUserButton;
    }
}