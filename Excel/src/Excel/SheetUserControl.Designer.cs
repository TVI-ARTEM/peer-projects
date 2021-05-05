
namespace Excel
{
    partial class SheetUserControl
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SecondFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.LegendGroupBox = new System.Windows.Forms.GroupBox();
            this.LegendLabel = new System.Windows.Forms.Label();
            this.LegendComboBox = new System.Windows.Forms.ComboBox();
            this.CreateChartButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.FirstFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ValueXGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueXLabel = new System.Windows.Forms.Label();
            this.ValueXComboBox = new System.Windows.Forms.ComboBox();
            this.ValueYGroupBox = new System.Windows.Forms.GroupBox();
            this.ValueYLabel = new System.Windows.Forms.Label();
            this.ValueYComboBox = new System.Windows.Forms.ComboBox();
            this.ChartTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.ChartTypeLabel = new System.Windows.Forms.Label();
            this.ChartTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SortDataCheckBox = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel.SuspendLayout();
            this.SecondFlowLayoutPanel.SuspendLayout();
            this.ValuesGroupBox.SuspendLayout();
            this.LegendGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.FirstFlowLayoutPanel.SuspendLayout();
            this.ValueXGroupBox.SuspendLayout();
            this.ValueYGroupBox.SuspendLayout();
            this.ChartTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.AutoScroll = true;
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(112)))), ((int)(((byte)(108)))));
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.SecondFlowLayoutPanel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.dataGridView, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.FirstFlowLayoutPanel, 0, 1);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 768);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // SecondFlowLayoutPanel
            // 
            this.SecondFlowLayoutPanel.Controls.Add(this.ValuesGroupBox);
            this.SecondFlowLayoutPanel.Controls.Add(this.LegendGroupBox);
            this.SecondFlowLayoutPanel.Controls.Add(this.CreateChartButton);
            this.SecondFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondFlowLayoutPanel.Location = new System.Drawing.Point(3, 677);
            this.SecondFlowLayoutPanel.Name = "SecondFlowLayoutPanel";
            this.SecondFlowLayoutPanel.Size = new System.Drawing.Size(794, 109);
            this.SecondFlowLayoutPanel.TabIndex = 0;
            // 
            // ValuesGroupBox
            // 
            this.ValuesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValuesGroupBox.Controls.Add(this.ValuesListBox);
            this.ValuesGroupBox.Controls.Add(this.ValuesLabel);
            this.ValuesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValuesGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValuesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ValuesGroupBox.Name = "ValuesGroupBox";
            this.ValuesGroupBox.Size = new System.Drawing.Size(217, 94);
            this.ValuesGroupBox.TabIndex = 31;
            this.ValuesGroupBox.TabStop = false;
            this.ValuesGroupBox.Text = "Values";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ValuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(94, 16);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ValuesListBox.Size = new System.Drawing.Size(120, 75);
            this.ValuesListBox.TabIndex = 2;
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ValuesLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValuesLabel.Location = new System.Drawing.Point(27, 38);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(59, 20);
            this.ValuesLabel.TabIndex = 0;
            this.ValuesLabel.Text = "Values:";
            // 
            // LegendGroupBox
            // 
            this.LegendGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LegendGroupBox.Controls.Add(this.LegendLabel);
            this.LegendGroupBox.Controls.Add(this.LegendComboBox);
            this.LegendGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LegendGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LegendGroupBox.Location = new System.Drawing.Point(226, 3);
            this.LegendGroupBox.Name = "LegendGroupBox";
            this.LegendGroupBox.Size = new System.Drawing.Size(217, 94);
            this.LegendGroupBox.TabIndex = 28;
            this.LegendGroupBox.TabStop = false;
            this.LegendGroupBox.Text = "Legend";
            // 
            // LegendLabel
            // 
            this.LegendLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendLabel.AutoSize = true;
            this.LegendLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.LegendLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LegendLabel.Location = new System.Drawing.Point(13, 38);
            this.LegendLabel.Name = "LegendLabel";
            this.LegendLabel.Size = new System.Drawing.Size(66, 20);
            this.LegendLabel.TabIndex = 0;
            this.LegendLabel.Text = "Legend:";
            // 
            // LegendComboBox
            // 
            this.LegendComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LegendComboBox.FormattingEnabled = true;
            this.LegendComboBox.Location = new System.Drawing.Point(103, 40);
            this.LegendComboBox.Name = "LegendComboBox";
            this.LegendComboBox.Size = new System.Drawing.Size(97, 21);
            this.LegendComboBox.TabIndex = 1;
            this.LegendComboBox.DropDown += new System.EventHandler(this.LegendComboBox_DropDown);
            // 
            // CreateChartButton
            // 
            this.CreateChartButton.FlatAppearance.BorderSize = 0;
            this.CreateChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateChartButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.CreateChartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CreateChartButton.Location = new System.Drawing.Point(449, 3);
            this.CreateChartButton.Name = "CreateChartButton";
            this.CreateChartButton.Size = new System.Drawing.Size(225, 94);
            this.CreateChartButton.TabIndex = 32;
            this.CreateChartButton.Text = "Create Chart";
            this.CreateChartButton.UseVisualStyleBackColor = true;
            this.CreateChartButton.Click += new System.EventHandler(this.CreateChartButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(794, 562);
            this.dataGridView.TabIndex = 33;
            // 
            // FirstFlowLayoutPanel
            // 
            this.FirstFlowLayoutPanel.Controls.Add(this.ValueXGroupBox);
            this.FirstFlowLayoutPanel.Controls.Add(this.ValueYGroupBox);
            this.FirstFlowLayoutPanel.Controls.Add(this.ChartTypeGroupBox);
            this.FirstFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstFlowLayoutPanel.Location = new System.Drawing.Point(3, 571);
            this.FirstFlowLayoutPanel.Name = "FirstFlowLayoutPanel";
            this.FirstFlowLayoutPanel.Size = new System.Drawing.Size(794, 100);
            this.FirstFlowLayoutPanel.TabIndex = 34;
            // 
            // ValueXGroupBox
            // 
            this.ValueXGroupBox.Controls.Add(this.ValueXLabel);
            this.ValueXGroupBox.Controls.Add(this.ValueXComboBox);
            this.ValueXGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueXGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValueXGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ValueXGroupBox.Name = "ValueXGroupBox";
            this.ValueXGroupBox.Size = new System.Drawing.Size(217, 94);
            this.ValueXGroupBox.TabIndex = 30;
            this.ValueXGroupBox.TabStop = false;
            this.ValueXGroupBox.Text = "Value X";
            // 
            // ValueXLabel
            // 
            this.ValueXLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueXLabel.AutoSize = true;
            this.ValueXLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ValueXLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValueXLabel.Location = new System.Drawing.Point(20, 37);
            this.ValueXLabel.Name = "ValueXLabel";
            this.ValueXLabel.Size = new System.Drawing.Size(70, 20);
            this.ValueXLabel.TabIndex = 0;
            this.ValueXLabel.Text = "Value X:";
            // 
            // ValueXComboBox
            // 
            this.ValueXComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueXComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueXComboBox.FormattingEnabled = true;
            this.ValueXComboBox.Location = new System.Drawing.Point(94, 39);
            this.ValueXComboBox.Name = "ValueXComboBox";
            this.ValueXComboBox.Size = new System.Drawing.Size(97, 21);
            this.ValueXComboBox.TabIndex = 1;
            this.ValueXComboBox.DropDown += new System.EventHandler(this.ValueXComboBox_DropDown);
            // 
            // ValueYGroupBox
            // 
            this.ValueYGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ValueYGroupBox.Controls.Add(this.SortDataCheckBox);
            this.ValueYGroupBox.Controls.Add(this.ValueYLabel);
            this.ValueYGroupBox.Controls.Add(this.ValueYComboBox);
            this.ValueYGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValueYGroupBox.Location = new System.Drawing.Point(226, 3);
            this.ValueYGroupBox.Name = "ValueYGroupBox";
            this.ValueYGroupBox.Size = new System.Drawing.Size(217, 94);
            this.ValueYGroupBox.TabIndex = 29;
            this.ValueYGroupBox.TabStop = false;
            this.ValueYGroupBox.Text = "Value Y";
            // 
            // ValueYLabel
            // 
            this.ValueYLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueYLabel.AutoSize = true;
            this.ValueYLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ValueYLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ValueYLabel.Location = new System.Drawing.Point(23, 21);
            this.ValueYLabel.Name = "ValueYLabel";
            this.ValueYLabel.Size = new System.Drawing.Size(67, 20);
            this.ValueYLabel.TabIndex = 0;
            this.ValueYLabel.Text = "Value Y:";
            // 
            // ValueYComboBox
            // 
            this.ValueYComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueYComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueYComboBox.FormattingEnabled = true;
            this.ValueYComboBox.Location = new System.Drawing.Point(96, 22);
            this.ValueYComboBox.Name = "ValueYComboBox";
            this.ValueYComboBox.Size = new System.Drawing.Size(97, 21);
            this.ValueYComboBox.TabIndex = 1;
            this.ValueYComboBox.DropDown += new System.EventHandler(this.ValueYComboBox_DropDown);
            // 
            // ChartTypeGroupBox
            // 
            this.ChartTypeGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChartTypeGroupBox.Controls.Add(this.ChartTypeLabel);
            this.ChartTypeGroupBox.Controls.Add(this.ChartTypeComboBox);
            this.ChartTypeGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChartTypeGroupBox.Location = new System.Drawing.Point(449, 3);
            this.ChartTypeGroupBox.Name = "ChartTypeGroupBox";
            this.ChartTypeGroupBox.Size = new System.Drawing.Size(225, 94);
            this.ChartTypeGroupBox.TabIndex = 27;
            this.ChartTypeGroupBox.TabStop = false;
            this.ChartTypeGroupBox.Text = "Chart Type";
            // 
            // ChartTypeLabel
            // 
            this.ChartTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChartTypeLabel.AutoSize = true;
            this.ChartTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.ChartTypeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChartTypeLabel.Location = new System.Drawing.Point(6, 38);
            this.ChartTypeLabel.Name = "ChartTypeLabel";
            this.ChartTypeLabel.Size = new System.Drawing.Size(95, 20);
            this.ChartTypeLabel.TabIndex = 0;
            this.ChartTypeLabel.Text = "Chart Type:";
            // 
            // ChartTypeComboBox
            // 
            this.ChartTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartTypeComboBox.FormattingEnabled = true;
            this.ChartTypeComboBox.Location = new System.Drawing.Point(104, 37);
            this.ChartTypeComboBox.Name = "ChartTypeComboBox";
            this.ChartTypeComboBox.Size = new System.Drawing.Size(97, 21);
            this.ChartTypeComboBox.TabIndex = 1;
            this.ChartTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ChartTypeComboBox_SelectedIndexChanged);
            // 
            // SortDataCheckBox
            // 
            this.SortDataCheckBox.AutoSize = true;
            this.SortDataCheckBox.Checked = true;
            this.SortDataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SortDataCheckBox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.SortDataCheckBox.Location = new System.Drawing.Point(27, 49);
            this.SortDataCheckBox.Name = "SortDataCheckBox";
            this.SortDataCheckBox.Size = new System.Drawing.Size(115, 29);
            this.SortDataCheckBox.TabIndex = 2;
            this.SortDataCheckBox.Text = "Sort Data";
            this.SortDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // SheetUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TableLayoutPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SheetUserControl";
            this.Size = new System.Drawing.Size(800, 768);
            this.TableLayoutPanel.ResumeLayout(false);
            this.SecondFlowLayoutPanel.ResumeLayout(false);
            this.ValuesGroupBox.ResumeLayout(false);
            this.ValuesGroupBox.PerformLayout();
            this.LegendGroupBox.ResumeLayout(false);
            this.LegendGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.FirstFlowLayoutPanel.ResumeLayout(false);
            this.ValueXGroupBox.ResumeLayout(false);
            this.ValueXGroupBox.PerformLayout();
            this.ValueYGroupBox.ResumeLayout(false);
            this.ValueYGroupBox.PerformLayout();
            this.ChartTypeGroupBox.ResumeLayout(false);
            this.ChartTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel SecondFlowLayoutPanel;
        private System.Windows.Forms.GroupBox ValuesGroupBox;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.GroupBox LegendGroupBox;
        private System.Windows.Forms.Label LegendLabel;
        private System.Windows.Forms.ComboBox LegendComboBox;
        private System.Windows.Forms.Button CreateChartButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.FlowLayoutPanel FirstFlowLayoutPanel;
        private System.Windows.Forms.GroupBox ValueYGroupBox;
        private System.Windows.Forms.Label ValueYLabel;
        private System.Windows.Forms.ComboBox ValueYComboBox;
        private System.Windows.Forms.GroupBox ChartTypeGroupBox;
        private System.Windows.Forms.Label ChartTypeLabel;
        private System.Windows.Forms.ComboBox ChartTypeComboBox;
        private System.Windows.Forms.GroupBox ValueXGroupBox;
        private System.Windows.Forms.Label ValueXLabel;
        private System.Windows.Forms.ComboBox ValueXComboBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.CheckBox SortDataCheckBox;
    }
}
