
namespace Excel
{
    partial class PieChartUserControl
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
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.SaveAsImageButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pieChart
            // 
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart.Location = new System.Drawing.Point(3, 3);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(374, 497);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "pieChart1";
            this.pieChart.DataClick += new LiveCharts.Events.DataClickHandler(this.PieChart_DataClick);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.SaveAsImageButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pieChart, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.cartesianChart, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.14024F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.85977F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(761, 599);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart.Location = new System.Drawing.Point(383, 3);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(375, 497);
            this.cartesianChart.TabIndex = 1;
            this.cartesianChart.Text = "cartesianChart1";
            this.cartesianChart.DataClick += new LiveCharts.Events.DataClickHandler(this.CartesianChart_DataClick);
            // 
            // SaveAsImageButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.SaveAsImageButton, 2);
            this.SaveAsImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveAsImageButton.FlatAppearance.BorderSize = 0;
            this.SaveAsImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsImageButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.SaveAsImageButton.Location = new System.Drawing.Point(3, 506);
            this.SaveAsImageButton.Name = "SaveAsImageButton";
            this.SaveAsImageButton.Size = new System.Drawing.Size(755, 90);
            this.SaveAsImageButton.TabIndex = 6;
            this.SaveAsImageButton.Text = "Save as Image";
            this.SaveAsImageButton.UseVisualStyleBackColor = true;
            this.SaveAsImageButton.Click += new System.EventHandler(this.SaveAsImageButton_Click);
            // 
            // PieChartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PieChartUserControl";
            this.Size = new System.Drawing.Size(761, 599);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Button SaveAsImageButton;
    }
}
