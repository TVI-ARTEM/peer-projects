
namespace TaskManagerWindow.Forms.ManageUsers
{
    partial class RemoveUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUserForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.FireUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.UsersDataGridView);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.splitContainer.Panel2.Controls.Add(this.FireUserButton);
            this.splitContainer.Panel2MinSize = 75;
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 266;
            this.splitContainer.TabIndex = 0;
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
            this.UsersDataGridView.Size = new System.Drawing.Size(800, 266);
            this.UsersDataGridView.TabIndex = 1;
            // 
            // FireUserButton
            // 
            this.FireUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FireUserButton.FlatAppearance.BorderSize = 0;
            this.FireUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FireUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FireUserButton.ForeColor = System.Drawing.Color.White;
            this.FireUserButton.Image = ((System.Drawing.Image)(resources.GetObject("FireUserButton.Image")));
            this.FireUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FireUserButton.Location = new System.Drawing.Point(300, 60);
            this.FireUserButton.Name = "FireUserButton";
            this.FireUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.FireUserButton.Size = new System.Drawing.Size(200, 60);
            this.FireUserButton.TabIndex = 5;
            this.FireUserButton.Text = "Fire User";
            this.FireUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FireUserButton.UseVisualStyleBackColor = true;
            this.FireUserButton.Click += new System.EventHandler(this.FireUserButton_Click);
            // 
            // RemoveUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "RemoveUserForm";
            this.Text = "Remove User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveUserForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RemoveUserForm_Paint);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Button FireUserButton;
    }
}