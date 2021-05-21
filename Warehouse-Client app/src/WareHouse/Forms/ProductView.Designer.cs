
namespace WareHouse.Forms
{
    partial class ProductView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProductBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.PriceLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MoreButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.ColumnCount = 12;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.Controls.Add(this.ProductBox, 1, 0);
            this.MainPanel.Controls.Add(this.TitleLabel, 1, 8);
            this.MainPanel.Controls.Add(this.PriceLabel, 1, 9);
            this.MainPanel.Controls.Add(this.MoreButton, 5, 10);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 12;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.Size = new System.Drawing.Size(238, 238);
            this.MainPanel.TabIndex = 0;
            this.ToolTip.SetToolTip(this.MainPanel, "");
            this.ToolTip.SetToolTipIcon(this.MainPanel, null);
            this.ToolTip.SetToolTipTitle(this.MainPanel, "");
            // 
            // ProductBox
            // 
            this.ProductBox.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.SetColumnSpan(this.ProductBox, 10);
            this.ProductBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductBox.Image = global::WareHouse.Properties.Resources.Product_default;
            this.ProductBox.Location = new System.Drawing.Point(22, 3);
            this.ProductBox.Name = "ProductBox";
            this.MainPanel.SetRowSpan(this.ProductBox, 8);
            this.ProductBox.Size = new System.Drawing.Size(184, 134);
            this.ProductBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductBox.TabIndex = 0;
            this.ProductBox.TabStop = false;
            this.ToolTip.SetToolTip(this.ProductBox, "");
            this.ToolTip.SetToolTipIcon(this.ProductBox, null);
            this.ToolTip.SetToolTipTitle(this.ProductBox, "");
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.AutoEllipsis = true;
            this.TitleLabel.AutoSize = false;
            this.MainPanel.SetColumnSpan(this.TitleLabel, 10);
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.TitleLabel.Location = new System.Drawing.Point(22, 143);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(184, 19);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ToolTip.SetToolTip(this.TitleLabel, "");
            this.ToolTip.SetToolTipIcon(this.TitleLabel, null);
            this.ToolTip.SetToolTipTitle(this.TitleLabel, "");
            // 
            // PriceLabel
            // 
            this.PriceLabel.AllowParentOverrides = false;
            this.PriceLabel.AutoEllipsis = true;
            this.PriceLabel.AutoSize = false;
            this.MainPanel.SetColumnSpan(this.PriceLabel, 10);
            this.PriceLabel.CursorType = null;
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.PriceLabel.Location = new System.Drawing.Point(22, 168);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceLabel.Size = new System.Drawing.Size(184, 19);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price:";
            this.PriceLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PriceLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.ToolTip.SetToolTip(this.PriceLabel, "");
            this.ToolTip.SetToolTipIcon(this.PriceLabel, null);
            this.ToolTip.SetToolTipTitle(this.PriceLabel, "");
            // 
            // MoreButton
            // 
            this.MoreButton.AllowAnimations = true;
            this.MoreButton.AllowMouseEffects = true;
            this.MoreButton.AllowToggling = false;
            this.MoreButton.AnimationSpeed = 200;
            this.MoreButton.AutoGenerateColors = false;
            this.MoreButton.AutoRoundBorders = false;
            this.MoreButton.AutoSizeLeftIcon = true;
            this.MoreButton.AutoSizeRightIcon = true;
            this.MoreButton.BackColor = System.Drawing.Color.Transparent;
            this.MoreButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.MoreButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoreButton.BackgroundImage")));
            this.MoreButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoreButton.ButtonText = "More";
            this.MoreButton.ButtonTextMarginLeft = 0;
            this.MoreButton.ColorContrastOnClick = 45;
            this.MoreButton.ColorContrastOnHover = 45;
            this.MainPanel.SetColumnSpan(this.MoreButton, 7);
            this.MoreButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.MoreButton.CustomizableEdges = borderEdges1;
            this.MoreButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MoreButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MoreButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MoreButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MoreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoreButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.MoreButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.MoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.MoreButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoreButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.MoreButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.MoreButton.IconMarginLeft = 11;
            this.MoreButton.IconPadding = 10;
            this.MoreButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoreButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.MoreButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.MoreButton.IconSize = 25;
            this.MoreButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.MoreButton.IdleBorderRadius = 30;
            this.MoreButton.IdleBorderThickness = 2;
            this.MoreButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.MoreButton.IdleIconLeftImage = null;
            this.MoreButton.IdleIconRightImage = null;
            this.MoreButton.IndicateFocus = false;
            this.MoreButton.Location = new System.Drawing.Point(98, 193);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MoreButton.OnDisabledState.BorderRadius = 30;
            this.MoreButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoreButton.OnDisabledState.BorderThickness = 2;
            this.MoreButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MoreButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MoreButton.OnDisabledState.IconLeftImage = null;
            this.MoreButton.OnDisabledState.IconRightImage = null;
            this.MoreButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.MoreButton.onHoverState.BorderRadius = 30;
            this.MoreButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoreButton.onHoverState.BorderThickness = 2;
            this.MoreButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.MoreButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.MoreButton.onHoverState.IconLeftImage = null;
            this.MoreButton.onHoverState.IconRightImage = null;
            this.MoreButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.MoreButton.OnIdleState.BorderRadius = 30;
            this.MoreButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoreButton.OnIdleState.BorderThickness = 2;
            this.MoreButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.MoreButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.MoreButton.OnIdleState.IconLeftImage = null;
            this.MoreButton.OnIdleState.IconRightImage = null;
            this.MoreButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.MoreButton.OnPressedState.BorderRadius = 30;
            this.MoreButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoreButton.OnPressedState.BorderThickness = 2;
            this.MoreButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.MoreButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.MoreButton.OnPressedState.IconLeftImage = null;
            this.MoreButton.OnPressedState.IconRightImage = null;
            this.MainPanel.SetRowSpan(this.MoreButton, 2);
            this.MoreButton.Size = new System.Drawing.Size(137, 36);
            this.MoreButton.TabIndex = 6;
            this.MoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MoreButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoreButton.TextMarginLeft = 0;
            this.MoreButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.MoreButton, "More info about product");
            this.ToolTip.SetToolTipIcon(this.MoreButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.MoreButton, "More");
            this.MoreButton.UseDefaultRadiusAndThickness = true;
            this.MoreButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.Active = true;
            this.ToolTip.AlignTextWithTitle = false;
            this.ToolTip.AllowAutoClose = false;
            this.ToolTip.AllowFading = true;
            this.ToolTip.AutoCloseDuration = 5000;
            this.ToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.ToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.ToolTip.ClickToShowDisplayControl = false;
            this.ToolTip.ConvertNewlinesToBreakTags = true;
            this.ToolTip.DisplayControl = null;
            this.ToolTip.EntryAnimationSpeed = 350;
            this.ToolTip.ExitAnimationSpeed = 200;
            this.ToolTip.GenerateAutoCloseDuration = false;
            this.ToolTip.IconMargin = 6;
            this.ToolTip.InitialDelay = 0;
            this.ToolTip.Name = "ToolTip";
            this.ToolTip.Opacity = 1D;
            this.ToolTip.OverrideToolTipTitles = false;
            this.ToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ShowAlways = true;
            this.ToolTip.ShowBorders = false;
            this.ToolTip.ShowIcons = true;
            this.ToolTip.ShowShadows = true;
            this.ToolTip.Tag = null;
            this.ToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolTip.TextMargin = 2;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.ToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.ToolTip.ToolTipTitle = "";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(240, 240);
            this.MinimumSize = new System.Drawing.Size(240, 240);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(238, 238);
            this.ToolTip.SetToolTip(this, "");
            this.ToolTip.SetToolTipIcon(this, null);
            this.ToolTip.SetToolTipTitle(this, "");
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.PictureBox ProductBox;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuLabel PriceLabel;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton MoreButton;
        private Bunifu.UI.WinForms.BunifuToolTip ToolTip;
    }
}
