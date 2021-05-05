
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class CreateTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskForm));
            this.MaxTaskTextBox = new System.Windows.Forms.TextBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.MaxTaskLabel = new System.Windows.Forms.Label();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.NewTaskLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TaskPictureBox = new System.Windows.Forms.PictureBox();
            this.TypeTaskComboBox = new System.Windows.Forms.ComboBox();
            this.TypeTaskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxTaskTextBox
            // 
            this.MaxTaskTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxTaskTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxTaskTextBox.Location = new System.Drawing.Point(529, 330);
            this.MaxTaskTextBox.Name = "MaxTaskTextBox";
            this.MaxTaskTextBox.PlaceholderText = "Enter Max Tasks...";
            this.MaxTaskTextBox.Size = new System.Drawing.Size(200, 35);
            this.MaxTaskTextBox.TabIndex = 4;
            // 
            // StateComboBox
            // 
            this.StateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(170, 276);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(200, 35);
            this.StateComboBox.TabIndex = 1;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StateLabel.Location = new System.Drawing.Point(85, 277);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(74, 29);
            this.StateLabel.TabIndex = 22;
            this.StateLabel.Text = "State:";
            // 
            // MaxTaskLabel
            // 
            this.MaxTaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxTaskLabel.AutoSize = true;
            this.MaxTaskLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTaskLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaxTaskLabel.Location = new System.Drawing.Point(394, 332);
            this.MaxTaskLabel.Name = "MaxTaskLabel";
            this.MaxTaskLabel.Size = new System.Drawing.Size(138, 29);
            this.MaxTaskLabel.TabIndex = 21;
            this.MaxTaskLabel.Text = "Max Tasks:";
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateTaskButton.FlatAppearance.BorderSize = 0;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTaskButton.ForeColor = System.Drawing.Color.White;
            this.CreateTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTaskButton.Image")));
            this.CreateTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTaskButton.Location = new System.Drawing.Point(283, 378);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CreateTaskButton.Size = new System.Drawing.Size(212, 60);
            this.CreateTaskButton.TabIndex = 5;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskNameTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskNameTextBox.Location = new System.Drawing.Point(171, 330);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.PlaceholderText = "Enter Name...";
            this.TaskNameTextBox.Size = new System.Drawing.Size(200, 35);
            this.TaskNameTextBox.TabIndex = 3;
            // 
            // NewTaskLabel
            // 
            this.NewTaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewTaskLabel.AutoSize = true;
            this.NewTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewTaskLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewTaskLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.NewTaskLabel.Location = new System.Drawing.Point(328, 229);
            this.NewTaskLabel.Name = "NewTaskLabel";
            this.NewTaskLabel.Size = new System.Drawing.Size(111, 29);
            this.NewTaskLabel.TabIndex = 18;
            this.NewTaskLabel.Text = "New task";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(71, 332);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 29);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name:";
            // 
            // TaskPictureBox
            // 
            this.TaskPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TaskPictureBox.Image")));
            this.TaskPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("TaskPictureBox.InitialImage")));
            this.TaskPictureBox.Location = new System.Drawing.Point(295, 16);
            this.TaskPictureBox.Name = "TaskPictureBox";
            this.TaskPictureBox.Size = new System.Drawing.Size(200, 200);
            this.TaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TaskPictureBox.TabIndex = 16;
            this.TaskPictureBox.TabStop = false;
            // 
            // TypeTaskComboBox
            // 
            this.TypeTaskComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeTaskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeTaskComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeTaskComboBox.FormattingEnabled = true;
            this.TypeTaskComboBox.Location = new System.Drawing.Point(528, 276);
            this.TypeTaskComboBox.Name = "TypeTaskComboBox";
            this.TypeTaskComboBox.Size = new System.Drawing.Size(200, 35);
            this.TypeTaskComboBox.TabIndex = 2;
            this.TypeTaskComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeTaskComboBox_SelectedIndexChanged);
            // 
            // TypeTaskLabel
            // 
            this.TypeTaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeTaskLabel.AutoSize = true;
            this.TypeTaskLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeTaskLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TypeTaskLabel.Location = new System.Drawing.Point(443, 277);
            this.TypeTaskLabel.Name = "TypeTaskLabel";
            this.TypeTaskLabel.Size = new System.Drawing.Size(72, 29);
            this.TypeTaskLabel.TabIndex = 25;
            this.TypeTaskLabel.Text = "Type:";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TypeTaskComboBox);
            this.Controls.Add(this.TypeTaskLabel);
            this.Controls.Add(this.MaxTaskTextBox);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.MaxTaskLabel);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.TaskNameTextBox);
            this.Controls.Add(this.NewTaskLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TaskPictureBox);
            this.Name = "CreateTaskForm";
            this.Text = "CreateTaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateTaskForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxTaskTextBox;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label MaxTaskLabel;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label NewTaskLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox TaskPictureBox;
        private System.Windows.Forms.ComboBox TypeTaskComboBox;
        private System.Windows.Forms.Label TypeTaskLabel;
    }
}