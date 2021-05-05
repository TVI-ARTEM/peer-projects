
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class ShowSubTasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSubTasksForm));
            this.ChooseTaskButton = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.ProjectsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseTaskButton
            // 
            this.ChooseTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseTaskButton.FlatAppearance.BorderSize = 0;
            this.ChooseTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseTaskButton.ForeColor = System.Drawing.Color.White;
            this.ChooseTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("ChooseTaskButton.Image")));
            this.ChooseTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseTaskButton.Location = new System.Drawing.Point(286, 46);
            this.ChooseTaskButton.Name = "ChooseTaskButton";
            this.ChooseTaskButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ChooseTaskButton.Size = new System.Drawing.Size(208, 60);
            this.ChooseTaskButton.TabIndex = 6;
            this.ChooseTaskButton.Text = "Choose Task";
            this.ChooseTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChooseTaskButton.UseVisualStyleBackColor = true;
            this.ChooseTaskButton.Click += new System.EventHandler(this.ChooseTaskButton_Click);
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
            this.splitContainer.Panel2.Controls.Add(this.ChooseTaskButton);
            this.splitContainer.Panel2MinSize = 75;
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 3;
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
            // ShowSubTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "ShowSubTasksForm";
            this.Text = "ShowSubTasksForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowSubTasksForm_Paint);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChooseTaskButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView ProjectsDataGridView;
    }
}