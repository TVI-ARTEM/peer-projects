
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class RemoveTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveTaskForm));
            this.TasksDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.RemoveTaskButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TasksDataGridView
            // 
            this.TasksDataGridView.AllowUserToAddRows = false;
            this.TasksDataGridView.AllowUserToDeleteRows = false;
            this.TasksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TasksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TasksDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(81)))), ((int)(((byte)(107)))));
            this.TasksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(53)))), ((int)(((byte)(114)))));
            this.TasksDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TasksDataGridView.Location = new System.Drawing.Point(0, 0);
            this.TasksDataGridView.Name = "TasksDataGridView";
            this.TasksDataGridView.ReadOnly = true;
            this.TasksDataGridView.RowTemplate.Height = 25;
            this.TasksDataGridView.Size = new System.Drawing.Size(800, 300);
            this.TasksDataGridView.TabIndex = 1;
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
            this.splitContainer.Panel1.Controls.Add(this.TasksDataGridView);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(88)))));
            this.splitContainer.Panel2.Controls.Add(this.RemoveTaskButton);
            this.splitContainer.Panel2MinSize = 75;
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 4;
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveTaskButton.FlatAppearance.BorderSize = 0;
            this.RemoveTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemoveTaskButton.ForeColor = System.Drawing.Color.White;
            this.RemoveTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveTaskButton.Image")));
            this.RemoveTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveTaskButton.Location = new System.Drawing.Point(286, 50);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RemoveTaskButton.Size = new System.Drawing.Size(216, 60);
            this.RemoveTaskButton.TabIndex = 6;
            this.RemoveTaskButton.Text = "Remove Task";
            this.RemoveTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveTaskButton.UseVisualStyleBackColor = true;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // RemoveTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "RemoveTaskForm";
            this.Text = "RemoveTaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveTaskForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RemoveTaskForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TasksDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button RemoveTaskButton;
    }
}