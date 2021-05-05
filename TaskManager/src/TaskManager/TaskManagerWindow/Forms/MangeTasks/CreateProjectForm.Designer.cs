
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class CreateProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProjectForm));
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.NewProjectLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProjectPictureBox = new System.Windows.Forms.PictureBox();
            this.MaxTaskLabel = new System.Windows.Forms.Label();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.MaxTaskTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateProjectButton.FlatAppearance.BorderSize = 0;
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateProjectButton.ForeColor = System.Drawing.Color.White;
            this.CreateProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateProjectButton.Image")));
            this.CreateProjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateProjectButton.Location = new System.Drawing.Point(298, 371);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CreateProjectButton.Size = new System.Drawing.Size(234, 60);
            this.CreateProjectButton.TabIndex = 4;
            this.CreateProjectButton.Text = "Create Project";
            this.CreateProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateProjectButton.UseVisualStyleBackColor = true;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectNameTextBox.Location = new System.Drawing.Point(186, 273);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.PlaceholderText = "Enter Name...";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(200, 35);
            this.ProjectNameTextBox.TabIndex = 1;
            // 
            // NewProjectLabel
            // 
            this.NewProjectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewProjectLabel.AutoSize = true;
            this.NewProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewProjectLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewProjectLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.NewProjectLabel.Location = new System.Drawing.Point(343, 226);
            this.NewProjectLabel.Name = "NewProjectLabel";
            this.NewProjectLabel.Size = new System.Drawing.Size(140, 29);
            this.NewProjectLabel.TabIndex = 7;
            this.NewProjectLabel.Text = "New project";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(86, 275);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 29);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // ProjectPictureBox
            // 
            this.ProjectPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProjectPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ProjectPictureBox.Image")));
            this.ProjectPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ProjectPictureBox.InitialImage")));
            this.ProjectPictureBox.Location = new System.Drawing.Point(310, 13);
            this.ProjectPictureBox.Name = "ProjectPictureBox";
            this.ProjectPictureBox.Size = new System.Drawing.Size(200, 200);
            this.ProjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProjectPictureBox.TabIndex = 5;
            this.ProjectPictureBox.TabStop = false;
            // 
            // MaxTaskLabel
            // 
            this.MaxTaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxTaskLabel.AutoSize = true;
            this.MaxTaskLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxTaskLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MaxTaskLabel.Location = new System.Drawing.Point(409, 275);
            this.MaxTaskLabel.Name = "MaxTaskLabel";
            this.MaxTaskLabel.Size = new System.Drawing.Size(138, 29);
            this.MaxTaskLabel.TabIndex = 10;
            this.MaxTaskLabel.Text = "Max Tasks:";
            // 
            // StateComboBox
            // 
            this.StateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(344, 323);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(200, 35);
            this.StateComboBox.TabIndex = 3;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StateLabel.Location = new System.Drawing.Point(259, 324);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(74, 29);
            this.StateLabel.TabIndex = 13;
            this.StateLabel.Text = "State:";
            // 
            // MaxTaskTextBox
            // 
            this.MaxTaskTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxTaskTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxTaskTextBox.Location = new System.Drawing.Point(544, 273);
            this.MaxTaskTextBox.Name = "MaxTaskTextBox";
            this.MaxTaskTextBox.PlaceholderText = "Enter Max Tasks...";
            this.MaxTaskTextBox.Size = new System.Drawing.Size(200, 35);
            this.MaxTaskTextBox.TabIndex = 2;
            // 
            // CreateProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxTaskTextBox);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.MaxTaskLabel);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.NewProjectLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ProjectPictureBox);
            this.Name = "CreateProjectForm";
            this.Text = "CreateProjectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateProjectForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProjectButton;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label NewProjectLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ProjectPictureBox;
        private System.Windows.Forms.Label MaxTaskLabel;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox MaxTaskTextBox;
    }
}