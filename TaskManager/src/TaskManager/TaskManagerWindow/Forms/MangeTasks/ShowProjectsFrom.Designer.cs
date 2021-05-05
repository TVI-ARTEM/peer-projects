
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ShowProjectsFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProjectsFrom));
            this.ProjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ChooseProjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectsDataGridView
            // 
            this.ProjectsDataGridView.AllowUserToAddRows = false;
            this.ProjectsDataGridView.AllowUserToDeleteRows = false;
            this.ProjectsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProjectsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(107)))));
            this.ProjectsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ProjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.ProjectsDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ProjectsDataGridView.Name = "ProjectsDataGridView";
            this.ProjectsDataGridView.ReadOnly = true;
            this.ProjectsDataGridView.RowTemplate.Height = 25;
            this.ProjectsDataGridView.Size = new System.Drawing.Size(800, 300);
            this.ProjectsDataGridView.TabIndex = 1;
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
            this.splitContainer.Panel1.Controls.Add(this.ProjectsDataGridView);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(188)))), ((int)(((byte)(112)))));
            this.splitContainer.Panel2.Controls.Add(this.ChooseProjectButton);
            this.splitContainer.Panel2MinSize = 75;
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 2;
            // 
            // ChooseProjectButton
            // 
            this.ChooseProjectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseProjectButton.FlatAppearance.BorderSize = 0;
            this.ChooseProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseProjectButton.ForeColor = System.Drawing.Color.White;
            this.ChooseProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("ChooseProjectButton.Image")));
            this.ChooseProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseProjectButton.Location = new System.Drawing.Point(280, 46);
            this.ChooseProjectButton.Name = "ChooseProjectButton";
            this.ChooseProjectButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ChooseProjectButton.Size = new System.Drawing.Size(236, 60);
            this.ChooseProjectButton.TabIndex = 6;
            this.ChooseProjectButton.Text = "Choose Project";
            this.ChooseProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChooseProjectButton.UseVisualStyleBackColor = true;
            this.ChooseProjectButton.Click += new System.EventHandler(this.ChooseProjectButton_Click);
            // 
            // ShowProjectsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "ShowProjectsFrom";
            this.Text = "Show Projects";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowProjectsFrom_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectsDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button ChooseProjectButton;
    }
}