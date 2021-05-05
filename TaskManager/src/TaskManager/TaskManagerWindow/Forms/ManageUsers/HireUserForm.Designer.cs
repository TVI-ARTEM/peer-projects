
namespace TaskManagerWindow.Forms.ManageUsers
{
    partial class HireUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireUserForm));
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NewUserLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.HireUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.Image")));
            this.UserPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("UserPictureBox.InitialImage")));
            this.UserPictureBox.Location = new System.Drawing.Point(304, 39);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(200, 200);
            this.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPictureBox.TabIndex = 0;
            this.UserPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(204, 293);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // NewUserLabel
            // 
            this.NewUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewUserLabel.AutoSize = true;
            this.NewUserLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewUserLabel.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewUserLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.NewUserLabel.Location = new System.Drawing.Point(346, 252);
            this.NewUserLabel.Name = "NewUserLabel";
            this.NewUserLabel.Size = new System.Drawing.Size(117, 29);
            this.NewUserLabel.TabIndex = 2;
            this.NewUserLabel.Text = "New User";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameTextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTextBox.Location = new System.Drawing.Point(304, 291);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PlaceholderText = "Enter Name...";
            this.UserNameTextBox.Size = new System.Drawing.Size(200, 35);
            this.UserNameTextBox.TabIndex = 3;
            // 
            // HireUserButton
            // 
            this.HireUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HireUserButton.FlatAppearance.BorderSize = 0;
            this.HireUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HireUserButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HireUserButton.ForeColor = System.Drawing.Color.White;
            this.HireUserButton.Image = ((System.Drawing.Image)(resources.GetObject("HireUserButton.Image")));
            this.HireUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HireUserButton.Location = new System.Drawing.Point(304, 349);
            this.HireUserButton.Name = "HireUserButton";
            this.HireUserButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HireUserButton.Size = new System.Drawing.Size(200, 60);
            this.HireUserButton.TabIndex = 4;
            this.HireUserButton.Text = "Hire User";
            this.HireUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HireUserButton.UseVisualStyleBackColor = true;
            this.HireUserButton.Click += new System.EventHandler(this.HireUserButton_Click);
            // 
            // HireUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HireUserButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.NewUserLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.UserPictureBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HireUserForm";
            this.Text = "Hire User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HireUserForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserPictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NewUserLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button HireUserButton;
    }
}