
namespace Excel
{
    partial class GraphChartUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ValueYGroupBox = new System.Windows.Forms.GroupBox();
            this.VarianceYLabel = new System.Windows.Forms.Label();
            this.SAYLabel = new System.Windows.Forms.Label();
            this.MedianYLabel = new System.Windows.Forms.Label();
            this.AVGYLabel = new System.Windows.Forms.Label();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.ValueXGroupBox = new System.Windows.Forms.GroupBox();
            this.VarianceXLabel = new System.Windows.Forms.Label();
            this.SAXLabel = new System.Windows.Forms.Label();
            this.MedianXLabel = new System.Windows.Forms.Label();
            this.AVGXLabel = new System.Windows.Forms.Label();
            this.SaveAsImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.ValueYGroupBox.SuspendLayout();
            this.ValueXGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.ValueYGroupBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.cartesianChart, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.ValueXGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.SaveAsImageButton, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.14023F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.85977F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(761, 599);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // ValueYGroupBox
            // 
            this.ValueYGroupBox.Controls.Add(this.VarianceYLabel);
            this.ValueYGroupBox.Controls.Add(this.SAYLabel);
            this.ValueYGroupBox.Controls.Add(this.MedianYLabel);
            this.ValueYGroupBox.Controls.Add(this.AVGYLabel);
            this.ValueYGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueYGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ValueYGroupBox.Location = new System.Drawing.Point(307, 506);
            this.ValueYGroupBox.Name = "ValueYGroupBox";
            this.ValueYGroupBox.Size = new System.Drawing.Size(298, 90);
            this.ValueYGroupBox.TabIndex = 4;
            this.ValueYGroupBox.TabStop = false;
            this.ValueYGroupBox.Text = "Value Y";
            // 
            // VarianceYLabel
            // 
            this.VarianceYLabel.AutoSize = true;
            this.VarianceYLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.VarianceYLabel.Location = new System.Drawing.Point(153, 54);
            this.VarianceYLabel.Name = "VarianceYLabel";
            this.VarianceYLabel.Size = new System.Drawing.Size(82, 21);
            this.VarianceYLabel.TabIndex = 3;
            this.VarianceYLabel.Text = "Variance: ";
            // 
            // SAYLabel
            // 
            this.SAYLabel.AutoSize = true;
            this.SAYLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.SAYLabel.Location = new System.Drawing.Point(6, 54);
            this.SAYLabel.Name = "SAYLabel";
            this.SAYLabel.Size = new System.Drawing.Size(43, 21);
            this.SAYLabel.TabIndex = 2;
            this.SAYLabel.Text = "SA: ";
            // 
            // MedianYLabel
            // 
            this.MedianYLabel.AutoSize = true;
            this.MedianYLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.MedianYLabel.Location = new System.Drawing.Point(153, 22);
            this.MedianYLabel.Name = "MedianYLabel";
            this.MedianYLabel.Size = new System.Drawing.Size(74, 21);
            this.MedianYLabel.TabIndex = 1;
            this.MedianYLabel.Text = "Median: ";
            // 
            // AVGYLabel
            // 
            this.AVGYLabel.AutoSize = true;
            this.AVGYLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.AVGYLabel.Location = new System.Drawing.Point(6, 22);
            this.AVGYLabel.Name = "AVGYLabel";
            this.AVGYLabel.Size = new System.Drawing.Size(57, 21);
            this.AVGYLabel.TabIndex = 0;
            this.AVGYLabel.Text = "AVG: ";
            // 
            // cartesianChart
            // 
            this.tableLayoutPanel.SetColumnSpan(this.cartesianChart, 3);
            this.cartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart.Location = new System.Drawing.Point(3, 3);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(755, 497);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // ValueXGroupBox
            // 
            this.ValueXGroupBox.Controls.Add(this.VarianceXLabel);
            this.ValueXGroupBox.Controls.Add(this.SAXLabel);
            this.ValueXGroupBox.Controls.Add(this.MedianXLabel);
            this.ValueXGroupBox.Controls.Add(this.AVGXLabel);
            this.ValueXGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueXGroupBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ValueXGroupBox.Location = new System.Drawing.Point(3, 506);
            this.ValueXGroupBox.Name = "ValueXGroupBox";
            this.ValueXGroupBox.Size = new System.Drawing.Size(298, 90);
            this.ValueXGroupBox.TabIndex = 1;
            this.ValueXGroupBox.TabStop = false;
            this.ValueXGroupBox.Text = "Value X";
            // 
            // VarianceXLabel
            // 
            this.VarianceXLabel.AutoSize = true;
            this.VarianceXLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.VarianceXLabel.Location = new System.Drawing.Point(153, 54);
            this.VarianceXLabel.Name = "VarianceXLabel";
            this.VarianceXLabel.Size = new System.Drawing.Size(82, 21);
            this.VarianceXLabel.TabIndex = 3;
            this.VarianceXLabel.Text = "Variance: ";
            // 
            // SAXLabel
            // 
            this.SAXLabel.AutoSize = true;
            this.SAXLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.SAXLabel.Location = new System.Drawing.Point(6, 54);
            this.SAXLabel.Name = "SAXLabel";
            this.SAXLabel.Size = new System.Drawing.Size(43, 21);
            this.SAXLabel.TabIndex = 2;
            this.SAXLabel.Text = "SA: ";
            // 
            // MedianXLabel
            // 
            this.MedianXLabel.AutoSize = true;
            this.MedianXLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.MedianXLabel.Location = new System.Drawing.Point(153, 22);
            this.MedianXLabel.Name = "MedianXLabel";
            this.MedianXLabel.Size = new System.Drawing.Size(74, 21);
            this.MedianXLabel.TabIndex = 1;
            this.MedianXLabel.Text = "Median: ";
            // 
            // AVGXLabel
            // 
            this.AVGXLabel.AutoSize = true;
            this.AVGXLabel.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.AVGXLabel.Location = new System.Drawing.Point(6, 22);
            this.AVGXLabel.Name = "AVGXLabel";
            this.AVGXLabel.Size = new System.Drawing.Size(57, 21);
            this.AVGXLabel.TabIndex = 0;
            this.AVGXLabel.Text = "AVG: ";
            // 
            // SaveAsImageButton
            // 
            this.SaveAsImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveAsImageButton.FlatAppearance.BorderSize = 0;
            this.SaveAsImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsImageButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.SaveAsImageButton.Location = new System.Drawing.Point(611, 506);
            this.SaveAsImageButton.Name = "SaveAsImageButton";
            this.SaveAsImageButton.Size = new System.Drawing.Size(147, 90);
            this.SaveAsImageButton.TabIndex = 5;
            this.SaveAsImageButton.Text = "Save as Image";
            this.SaveAsImageButton.UseVisualStyleBackColor = true;
            this.SaveAsImageButton.Click += new System.EventHandler(this.SaveAsImageButton_Click);
            // 
            // GraphChartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "GraphChartUserControl";
            this.Size = new System.Drawing.Size(761, 599);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ValueYGroupBox.ResumeLayout(false);
            this.ValueYGroupBox.PerformLayout();
            this.ValueXGroupBox.ResumeLayout(false);
            this.ValueXGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.GroupBox ValueXGroupBox;
        private System.Windows.Forms.Label AVGXLabel;
        private System.Windows.Forms.Label MedianXLabel;
        private System.Windows.Forms.GroupBox ValueYGroupBox;
        private System.Windows.Forms.Label VarianceYLabel;
        private System.Windows.Forms.Label SAYLabel;
        private System.Windows.Forms.Label MedianYLabel;
        private System.Windows.Forms.Label AVGYLabel;
        private System.Windows.Forms.Label VarianceXLabel;
        private System.Windows.Forms.Label SAXLabel;
        private System.Windows.Forms.Button SaveAsImageButton;
    }
}
