namespace Fractals
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
            this.components = new System.ComponentModel.Container();
            this.recursionDepthTextBox = new System.Windows.Forms.TextBox();
            this.fractalColorDialog = new System.Windows.Forms.ColorDialog();
            this.segmentLengthTextBox = new System.Windows.Forms.TextBox();
            this.recursionDepthLabel = new System.Windows.Forms.Label();
            this.segmentLengthLabel = new System.Windows.Forms.Label();
            this.firstColorPanel = new System.Windows.Forms.Panel();
            this.secondColorPanel = new System.Windows.Forms.Panel();
            this.secondColorLabel = new System.Windows.Forms.Label();
            this.firstColorLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.leftAngleTextBox = new System.Windows.Forms.TextBox();
            this.rightAngleLabel = new System.Windows.Forms.Label();
            this.rightAngleTextBox = new System.Windows.Forms.TextBox();
            this.fractalLabel = new System.Windows.Forms.Label();
            this.fractalComboBox = new System.Windows.Forms.ComboBox();
            this.leftAngleLabel = new System.Windows.Forms.Label();
            this.MainSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.AdditionalSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.segmentWidthDescriptionLabel = new System.Windows.Forms.Label();
            this.segmentWidthTextBox = new System.Windows.Forms.TextBox();
            this.segmentWidthLabel = new System.Windows.Forms.Label();
            this.colorsDescriptionLablel = new System.Windows.Forms.Label();
            this.GraphicsSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.enableRedrawCheckBox = new System.Windows.Forms.CheckBox();
            this.redrawDescriptionLabel = new System.Windows.Forms.Label();
            this.brushDescriptionLabel = new System.Windows.Forms.Label();
            this.brushWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.brushWidthLabel = new System.Windows.Forms.Label();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainSettingsGroupBox.SuspendLayout();
            this.AdditionalSettingsGroupBox.SuspendLayout();
            this.GraphicsSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // recursionDepthTextBox
            // 
            this.recursionDepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recursionDepthTextBox.Location = new System.Drawing.Point(209, 84);
            this.recursionDepthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.recursionDepthTextBox.Name = "recursionDepthTextBox";
            this.recursionDepthTextBox.Size = new System.Drawing.Size(137, 26);
            this.recursionDepthTextBox.TabIndex = 1;
            this.recursionDepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recursionDepthTextBox_KeyPress);
            // 
            // segmentLengthTextBox
            // 
            this.segmentLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segmentLengthTextBox.Location = new System.Drawing.Point(209, 130);
            this.segmentLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.segmentLengthTextBox.Name = "segmentLengthTextBox";
            this.segmentLengthTextBox.Size = new System.Drawing.Size(137, 26);
            this.segmentLengthTextBox.TabIndex = 2;
            this.segmentLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.segmentLengthTextBox_KeyPress);
            // 
            // recursionDepthLabel
            // 
            this.recursionDepthLabel.AutoSize = true;
            this.recursionDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recursionDepthLabel.Location = new System.Drawing.Point(20, 87);
            this.recursionDepthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recursionDepthLabel.Name = "recursionDepthLabel";
            this.recursionDepthLabel.Size = new System.Drawing.Size(149, 20);
            this.recursionDepthLabel.TabIndex = 2;
            this.recursionDepthLabel.Text = "Recursion Depth:";
            this.recursionDepthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // segmentLengthLabel
            // 
            this.segmentLengthLabel.AutoSize = true;
            this.segmentLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.segmentLengthLabel.Location = new System.Drawing.Point(20, 134);
            this.segmentLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segmentLengthLabel.Name = "segmentLengthLabel";
            this.segmentLengthLabel.Size = new System.Drawing.Size(147, 20);
            this.segmentLengthLabel.TabIndex = 3;
            this.segmentLengthLabel.Text = "Segment Length:";
            this.segmentLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // firstColorPanel
            // 
            this.firstColorPanel.BackColor = System.Drawing.Color.White;
            this.firstColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstColorPanel.Location = new System.Drawing.Point(172, 43);
            this.firstColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstColorPanel.Name = "firstColorPanel";
            this.firstColorPanel.Size = new System.Drawing.Size(116, 27);
            this.firstColorPanel.TabIndex = 6;
            this.firstColorPanel.Click += new System.EventHandler(this.firstColorPanel_Click);
            // 
            // secondColorPanel
            // 
            this.secondColorPanel.BackColor = System.Drawing.Color.Black;
            this.secondColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondColorPanel.Location = new System.Drawing.Point(172, 87);
            this.secondColorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secondColorPanel.Name = "secondColorPanel";
            this.secondColorPanel.Size = new System.Drawing.Size(116, 27);
            this.secondColorPanel.TabIndex = 7;
            this.secondColorPanel.Click += new System.EventHandler(this.secondColorPanel_Click);
            // 
            // secondColorLabel
            // 
            this.secondColorLabel.AutoSize = true;
            this.secondColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondColorLabel.Location = new System.Drawing.Point(10, 87);
            this.secondColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondColorLabel.Name = "secondColorLabel";
            this.secondColorLabel.Size = new System.Drawing.Size(129, 20);
            this.secondColorLabel.TabIndex = 7;
            this.secondColorLabel.Text = "*Second Color:";
            // 
            // firstColorLabel
            // 
            this.firstColorLabel.AutoSize = true;
            this.firstColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstColorLabel.Location = new System.Drawing.Point(35, 43);
            this.firstColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstColorLabel.Name = "firstColorLabel";
            this.firstColorLabel.Size = new System.Drawing.Size(104, 20);
            this.firstColorLabel.TabIndex = 6;
            this.firstColorLabel.Text = "*First Color:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.Orange;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveSettingsButton.ForeColor = System.Drawing.Color.White;
            this.saveSettingsButton.Location = new System.Drawing.Point(14, 406);
            this.saveSettingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(693, 47);
            this.saveSettingsButton.TabIndex = 10;
            this.saveSettingsButton.Text = "Save";
            this.saveToolTip.SetToolTip(this.saveSettingsButton, "Save current configs.");
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // leftAngleTextBox
            // 
            this.leftAngleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftAngleTextBox.Location = new System.Drawing.Point(158, 39);
            this.leftAngleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.leftAngleTextBox.Name = "leftAngleTextBox";
            this.leftAngleTextBox.Size = new System.Drawing.Size(116, 26);
            this.leftAngleTextBox.TabIndex = 3;
            this.leftAngleTextBox.Text = "0";
            this.leftAngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftAngleTextBox_KeyPress);
            // 
            // rightAngleLabel
            // 
            this.rightAngleLabel.AutoSize = true;
            this.rightAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rightAngleLabel.Location = new System.Drawing.Point(15, 84);
            this.rightAngleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rightAngleLabel.Name = "rightAngleLabel";
            this.rightAngleLabel.Size = new System.Drawing.Size(108, 20);
            this.rightAngleLabel.TabIndex = 12;
            this.rightAngleLabel.Text = "Right Angle:";
            // 
            // rightAngleTextBox
            // 
            this.rightAngleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightAngleTextBox.Location = new System.Drawing.Point(158, 84);
            this.rightAngleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rightAngleTextBox.Name = "rightAngleTextBox";
            this.rightAngleTextBox.Size = new System.Drawing.Size(116, 26);
            this.rightAngleTextBox.TabIndex = 4;
            this.rightAngleTextBox.Text = "0";
            this.rightAngleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightAngleTextBox_KeyPress);
            // 
            // fractalLabel
            // 
            this.fractalLabel.AutoSize = true;
            this.fractalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fractalLabel.Location = new System.Drawing.Point(117, 43);
            this.fractalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fractalLabel.Name = "fractalLabel";
            this.fractalLabel.Size = new System.Drawing.Size(70, 20);
            this.fractalLabel.TabIndex = 13;
            this.fractalLabel.Text = "Fractal:";
            // 
            // fractalComboBox
            // 
            this.fractalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fractalComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fractalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fractalComboBox.FormattingEnabled = true;
            this.fractalComboBox.Items.AddRange(new object[] {
            "Tree",
            "Koch",
            "Cantor set",
            "Triangle",
            "Carpet"});
            this.fractalComboBox.Location = new System.Drawing.Point(209, 39);
            this.fractalComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fractalComboBox.Name = "fractalComboBox";
            this.fractalComboBox.Size = new System.Drawing.Size(137, 28);
            this.fractalComboBox.TabIndex = 0;
            this.fractalComboBox.SelectedIndexChanged += new System.EventHandler(this.fractalComboBox_SelectedIndexChanged);
            // 
            // leftAngleLabel
            // 
            this.leftAngleLabel.AutoSize = true;
            this.leftAngleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftAngleLabel.Location = new System.Drawing.Point(37, 43);
            this.leftAngleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftAngleLabel.Name = "leftAngleLabel";
            this.leftAngleLabel.Size = new System.Drawing.Size(97, 20);
            this.leftAngleLabel.TabIndex = 15;
            this.leftAngleLabel.Text = "Left Angle:";
            // 
            // MainSettingsGroupBox
            // 
            this.MainSettingsGroupBox.Controls.Add(this.fractalLabel);
            this.MainSettingsGroupBox.Controls.Add(this.recursionDepthTextBox);
            this.MainSettingsGroupBox.Controls.Add(this.fractalComboBox);
            this.MainSettingsGroupBox.Controls.Add(this.segmentLengthTextBox);
            this.MainSettingsGroupBox.Controls.Add(this.recursionDepthLabel);
            this.MainSettingsGroupBox.Controls.Add(this.segmentLengthLabel);
            this.MainSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainSettingsGroupBox.Location = new System.Drawing.Point(14, 14);
            this.MainSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainSettingsGroupBox.Name = "MainSettingsGroupBox";
            this.MainSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainSettingsGroupBox.Size = new System.Drawing.Size(380, 204);
            this.MainSettingsGroupBox.TabIndex = 16;
            this.MainSettingsGroupBox.TabStop = false;
            this.MainSettingsGroupBox.Text = "Main settings";
            // 
            // AdditionalSettingsGroupBox
            // 
            this.AdditionalSettingsGroupBox.Controls.Add(this.segmentWidthDescriptionLabel);
            this.AdditionalSettingsGroupBox.Controls.Add(this.segmentWidthTextBox);
            this.AdditionalSettingsGroupBox.Controls.Add(this.segmentWidthLabel);
            this.AdditionalSettingsGroupBox.Controls.Add(this.leftAngleTextBox);
            this.AdditionalSettingsGroupBox.Controls.Add(this.rightAngleTextBox);
            this.AdditionalSettingsGroupBox.Controls.Add(this.leftAngleLabel);
            this.AdditionalSettingsGroupBox.Controls.Add(this.rightAngleLabel);
            this.AdditionalSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionalSettingsGroupBox.Location = new System.Drawing.Point(401, 14);
            this.AdditionalSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdditionalSettingsGroupBox.Name = "AdditionalSettingsGroupBox";
            this.AdditionalSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AdditionalSettingsGroupBox.Size = new System.Drawing.Size(306, 204);
            this.AdditionalSettingsGroupBox.TabIndex = 17;
            this.AdditionalSettingsGroupBox.TabStop = false;
            this.AdditionalSettingsGroupBox.Text = "Additional settings";
            // 
            // segmentWidthDescriptionLabel
            // 
            this.segmentWidthDescriptionLabel.AutoSize = true;
            this.segmentWidthDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segmentWidthDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.segmentWidthDescriptionLabel.Location = new System.Drawing.Point(16, 172);
            this.segmentWidthDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segmentWidthDescriptionLabel.Name = "segmentWidthDescriptionLabel";
            this.segmentWidthDescriptionLabel.Size = new System.Drawing.Size(207, 13);
            this.segmentWidthDescriptionLabel.TabIndex = 8;
            this.segmentWidthDescriptionLabel.Text = "(Distance between segments on iterations)";
            // 
            // segmentWidthTextBox
            // 
            this.segmentWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segmentWidthTextBox.Location = new System.Drawing.Point(158, 130);
            this.segmentWidthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.segmentWidthTextBox.Name = "segmentWidthTextBox";
            this.segmentWidthTextBox.Size = new System.Drawing.Size(116, 26);
            this.segmentWidthTextBox.TabIndex = 5;
            this.segmentWidthTextBox.Text = "0";
            this.segmentWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.segmentWidthTextBox_KeyPress);
            // 
            // segmentWidthLabel
            // 
            this.segmentWidthLabel.AutoSize = true;
            this.segmentWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.segmentWidthLabel.Location = new System.Drawing.Point(61, 134);
            this.segmentWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.segmentWidthLabel.Name = "segmentWidthLabel";
            this.segmentWidthLabel.Size = new System.Drawing.Size(67, 20);
            this.segmentWidthLabel.TabIndex = 17;
            this.segmentWidthLabel.Text = "*Width:";
            this.segmentWidthLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // colorsDescriptionLablel
            // 
            this.colorsDescriptionLablel.AutoSize = true;
            this.colorsDescriptionLablel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorsDescriptionLablel.ForeColor = System.Drawing.Color.Crimson;
            this.colorsDescriptionLablel.Location = new System.Drawing.Point(12, 129);
            this.colorsDescriptionLablel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorsDescriptionLablel.Name = "colorsDescriptionLablel";
            this.colorsDescriptionLablel.Size = new System.Drawing.Size(255, 13);
            this.colorsDescriptionLablel.TabIndex = 0;
            this.colorsDescriptionLablel.Text = "(To select a new foreground color, click in the panel)";
            // 
            // GraphicsSettingsGroupBox
            // 
            this.GraphicsSettingsGroupBox.Controls.Add(this.enableRedrawCheckBox);
            this.GraphicsSettingsGroupBox.Controls.Add(this.redrawDescriptionLabel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.brushDescriptionLabel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.brushWidthTrackBar);
            this.GraphicsSettingsGroupBox.Controls.Add(this.brushWidthLabel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.firstColorLabel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.colorsDescriptionLablel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.firstColorPanel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.secondColorPanel);
            this.GraphicsSettingsGroupBox.Controls.Add(this.secondColorLabel);
            this.GraphicsSettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GraphicsSettingsGroupBox.Location = new System.Drawing.Point(14, 225);
            this.GraphicsSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GraphicsSettingsGroupBox.Name = "GraphicsSettingsGroupBox";
            this.GraphicsSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GraphicsSettingsGroupBox.Size = new System.Drawing.Size(693, 174);
            this.GraphicsSettingsGroupBox.TabIndex = 18;
            this.GraphicsSettingsGroupBox.TabStop = false;
            this.GraphicsSettingsGroupBox.Text = "Graphics settings";
            // 
            // enableRedrawCheckBox
            // 
            this.enableRedrawCheckBox.AutoSize = true;
            this.enableRedrawCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enableRedrawCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enableRedrawCheckBox.Location = new System.Drawing.Point(350, 98);
            this.enableRedrawCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enableRedrawCheckBox.Name = "enableRedrawCheckBox";
            this.enableRedrawCheckBox.Size = new System.Drawing.Size(265, 24);
            this.enableRedrawCheckBox.TabIndex = 9;
            this.enableRedrawCheckBox.Text = "*Enable redraw while resizing:";
            this.enableRedrawCheckBox.UseVisualStyleBackColor = true;
            this.enableRedrawCheckBox.CheckedChanged += new System.EventHandler(this.enableRedrawCheckBox_CheckedChanged);
            // 
            // redrawDescriptionLabel
            // 
            this.redrawDescriptionLabel.AutoSize = true;
            this.redrawDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redrawDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.redrawDescriptionLabel.Location = new System.Drawing.Point(346, 129);
            this.redrawDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redrawDescriptionLabel.Name = "redrawDescriptionLabel";
            this.redrawDescriptionLabel.Size = new System.Drawing.Size(150, 13);
            this.redrawDescriptionLabel.TabIndex = 12;
            this.redrawDescriptionLabel.Text = "(Highly impact on perfomance)";
            // 
            // brushDescriptionLabel
            // 
            this.brushDescriptionLabel.AutoSize = true;
            this.brushDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brushDescriptionLabel.ForeColor = System.Drawing.Color.Crimson;
            this.brushDescriptionLabel.Location = new System.Drawing.Point(384, 80);
            this.brushDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brushDescriptionLabel.Name = "brushDescriptionLabel";
            this.brushDescriptionLabel.Size = new System.Drawing.Size(137, 13);
            this.brushDescriptionLabel.TabIndex = 10;
            this.brushDescriptionLabel.Text = "(Brush width range: 1 to 10)";
            // 
            // brushWidthTrackBar
            // 
            this.brushWidthTrackBar.LargeChange = 1;
            this.brushWidthTrackBar.Location = new System.Drawing.Point(516, 43);
            this.brushWidthTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.brushWidthTrackBar.Minimum = 1;
            this.brushWidthTrackBar.Name = "brushWidthTrackBar";
            this.brushWidthTrackBar.Size = new System.Drawing.Size(146, 45);
            this.brushWidthTrackBar.TabIndex = 8;
            this.brushWidthTrackBar.Value = 1;
            // 
            // brushWidthLabel
            // 
            this.brushWidthLabel.AutoSize = true;
            this.brushWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brushWidthLabel.Location = new System.Drawing.Point(378, 43);
            this.brushWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brushWidthLabel.Name = "brushWidthLabel";
            this.brushWidthLabel.Size = new System.Drawing.Size(119, 20);
            this.brushWidthLabel.TabIndex = 8;
            this.brushWidthLabel.Text = "*Brush Width:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.GraphicsSettingsGroupBox);
            this.Controls.Add(this.AdditionalSettingsGroupBox);
            this.Controls.Add(this.MainSettingsGroupBox);
            this.Controls.Add(this.saveSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settingsForm_FormClosed);
            this.MainSettingsGroupBox.ResumeLayout(false);
            this.MainSettingsGroupBox.PerformLayout();
            this.AdditionalSettingsGroupBox.ResumeLayout(false);
            this.AdditionalSettingsGroupBox.PerformLayout();
            this.GraphicsSettingsGroupBox.ResumeLayout(false);
            this.GraphicsSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushWidthTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog fractalColorDialog;
        private System.Windows.Forms.TextBox recursionDepthTextBox;
        private System.Windows.Forms.TextBox segmentLengthTextBox;
        private System.Windows.Forms.Label recursionDepthLabel;
        private System.Windows.Forms.Label segmentLengthLabel;
        private System.Windows.Forms.Panel firstColorPanel;
        private System.Windows.Forms.Panel secondColorPanel;
        private System.Windows.Forms.Label secondColorLabel;
        private System.Windows.Forms.Label firstColorLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.TextBox leftAngleTextBox;
        private System.Windows.Forms.Label rightAngleLabel;
        private System.Windows.Forms.TextBox rightAngleTextBox;
        private System.Windows.Forms.Label fractalLabel;
        private System.Windows.Forms.ComboBox fractalComboBox;
        private System.Windows.Forms.Label leftAngleLabel;
        private System.Windows.Forms.GroupBox MainSettingsGroupBox;
        private System.Windows.Forms.GroupBox AdditionalSettingsGroupBox;
        private System.Windows.Forms.Label colorsDescriptionLablel;
        private System.Windows.Forms.GroupBox GraphicsSettingsGroupBox;
        private System.Windows.Forms.Label segmentWidthDescriptionLabel;
        private System.Windows.Forms.TextBox segmentWidthTextBox;
        private System.Windows.Forms.Label segmentWidthLabel;
        private System.Windows.Forms.Label brushWidthLabel;
        private System.Windows.Forms.TrackBar brushWidthTrackBar;
        private System.Windows.Forms.Label brushDescriptionLabel;
        private System.Windows.Forms.Label redrawDescriptionLabel;
        private System.Windows.Forms.CheckBox enableRedrawCheckBox;
        private System.Windows.Forms.ToolTip saveToolTip;
    }
}