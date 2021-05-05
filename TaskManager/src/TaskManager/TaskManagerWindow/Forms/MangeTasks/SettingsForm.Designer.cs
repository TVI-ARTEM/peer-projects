
namespace TaskManagerWindow.Forms.MangeTasks
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TaskPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StateComboBox
            // 
            this.StateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(506, 286);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(200, 35);
            this.StateComboBox.TabIndex = 23;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StateLabel.Location = new System.Drawing.Point(421, 287);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(74, 29);
            this.StateLabel.TabIndex = 22;
            this.StateLabel.Text = "State:";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Image = ((System.Drawing.Image)(resources.GetObject("ConfirmButton.Image")));
            this.ConfirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.Location = new System.Drawing.Point(307, 355);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ConfirmButton.Size = new System.Drawing.Size(163, 60);
            this.ConfirmButton.TabIndex = 20;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskNameTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskNameTextBox.Location = new System.Drawing.Point(171, 285);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(200, 35);
            this.TaskNameTextBox.TabIndex = 19;
            this.TaskNameTextBox.Text = "Enter Name...";
            // 
            // TaskLabel
            // 
            this.TaskLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaskLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.TaskLabel.Location = new System.Drawing.Point(328, 229);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(78, 29);
            this.TaskLabel.TabIndex = 18;
            this.TaskLabel.Text = "Task: ";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(71, 287);
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
            this.TaskPictureBox.Location = new System.Drawing.Point(295, 25);
            this.TaskPictureBox.Name = "TaskPictureBox";
            this.TaskPictureBox.Size = new System.Drawing.Size(200, 200);
            this.TaskPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TaskPictureBox.TabIndex = 16;
            this.TaskPictureBox.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TaskNameTextBox);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TaskPictureBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox TaskPictureBox;
    }
}