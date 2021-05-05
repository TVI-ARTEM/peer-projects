namespace Fractals
{
    partial class FractalsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FractalsForm));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomX1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomX3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomX5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fractalPanel = new System.Windows.Forms.Panel();
            this.fractalPictureBox = new System.Windows.Forms.PictureBox();
            this.generateToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fractalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "Save file or close program.";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Save image.";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.ToolTipText = "Close program.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.zoomX1ToolStripMenuItem,
            this.zoomX2ToolStripMenuItem,
            this.zoomX3ToolStripMenuItem,
            this.zoomX5ToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.ToolTipText = "Change settings or zoom.";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.ToolTipText = "Change settings.";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // zoomX1ToolStripMenuItem
            // 
            this.zoomX1ToolStripMenuItem.Name = "zoomX1ToolStripMenuItem";
            this.zoomX1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zoomX1ToolStripMenuItem.Text = "Zoom x1";
            this.zoomX1ToolStripMenuItem.Click += new System.EventHandler(this.zoomX1ToolStripMenuItem_Click);
            // 
            // zoomX2ToolStripMenuItem
            // 
            this.zoomX2ToolStripMenuItem.Name = "zoomX2ToolStripMenuItem";
            this.zoomX2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zoomX2ToolStripMenuItem.Text = "Zoom x2";
            this.zoomX2ToolStripMenuItem.Click += new System.EventHandler(this.zoomX2ToolStripMenuItem_Click);
            // 
            // zoomX3ToolStripMenuItem
            // 
            this.zoomX3ToolStripMenuItem.Name = "zoomX3ToolStripMenuItem";
            this.zoomX3ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zoomX3ToolStripMenuItem.Text = "Zoom x3";
            this.zoomX3ToolStripMenuItem.Click += new System.EventHandler(this.zoomX3ToolStripMenuItem_Click);
            // 
            // zoomX5ToolStripMenuItem
            // 
            this.zoomX5ToolStripMenuItem.Name = "zoomX5ToolStripMenuItem";
            this.zoomX5ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zoomX5ToolStripMenuItem.Text = "Zoom x5";
            this.zoomX5ToolStripMenuItem.Click += new System.EventHandler(this.zoomX5ToolStripMenuItem_Click);
            // 
            // mainMenuMenuStrip
            // 
            this.mainMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mainMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuMenuStrip.Name = "mainMenuMenuStrip";
            this.mainMenuMenuStrip.Size = new System.Drawing.Size(780, 24);
            this.mainMenuMenuStrip.TabIndex = 1;
            this.mainMenuMenuStrip.Text = "menuStrip1";
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.generateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(4, 3);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(382, 40);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateToolTip.SetToolTip(this.generateButton, "Generate fractal.\r\nChange settings: Tools->Settings");
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Crimson;
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(394, 3);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(382, 40);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "Clear image.");
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 439);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 46);
            this.tableLayoutPanel1.TabIndex = 3;
            this.generateToolTip.SetToolTip(this.tableLayoutPanel1, "Geterate fractal according to settings.\r\nChange settings: Tools->Settings");
            // 
            // fractalPanel
            // 
            this.fractalPanel.AutoScroll = true;
            this.fractalPanel.Controls.Add(this.fractalPictureBox);
            this.fractalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fractalPanel.Location = new System.Drawing.Point(0, 24);
            this.fractalPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fractalPanel.Name = "fractalPanel";
            this.fractalPanel.Size = new System.Drawing.Size(780, 415);
            this.fractalPanel.TabIndex = 4;
            // 
            // fractalPictureBox
            // 
            this.fractalPictureBox.Location = new System.Drawing.Point(329, 175);
            this.fractalPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fractalPictureBox.Name = "fractalPictureBox";
            this.fractalPictureBox.Size = new System.Drawing.Size(100, 50);
            this.fractalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fractalPictureBox.TabIndex = 0;
            this.fractalPictureBox.TabStop = false;
            // 
            // FractalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 485);
            this.Controls.Add(this.fractalPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenuMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(795, 381);
            this.Name = "FractalsForm";
            this.Text = "Fractals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FractalsForm_FormClosing);
            this.Load += new System.EventHandler(this.FractalsForm_Load);
            this.Resize += new System.EventHandler(this.FractalsForm_Resize);
            this.mainMenuMenuStrip.ResumeLayout(false);
            this.mainMenuMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.fractalPanel.ResumeLayout(false);
            this.fractalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fractalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuMenuStrip;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ToolStripMenuItem zoomX1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomX3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomX5ToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel fractalPanel;
        private System.Windows.Forms.PictureBox fractalPictureBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip generateToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
    }
}

