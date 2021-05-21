
namespace WareHouse.Forms
{
    partial class ClientCSVReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCSVReportForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.SaveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ProductPriceTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LogoLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // FormDock
            // 
            this.FormDock.AllowFormDragging = true;
            this.FormDock.AllowFormDropShadow = true;
            this.FormDock.AllowFormResizing = true;
            this.FormDock.AllowHidingBottomRegion = true;
            this.FormDock.AllowOpacityChangesWhileDragging = false;
            this.FormDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.FormDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.FormDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.FormDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.FormDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.FormDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.FormDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.FormDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.FormDock.BorderOptions.RightBorder.ShowBorder = true;
            this.FormDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.FormDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.FormDock.BorderOptions.TopBorder.ShowBorder = true;
            this.FormDock.ContainerControl = this;
            this.FormDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.FormDock.DockingIndicatorsOpacity = 0.5D;
            this.FormDock.DockingOptions.DockAll = true;
            this.FormDock.DockingOptions.DockBottomLeft = true;
            this.FormDock.DockingOptions.DockBottomRight = true;
            this.FormDock.DockingOptions.DockFullScreen = true;
            this.FormDock.DockingOptions.DockLeft = true;
            this.FormDock.DockingOptions.DockRight = true;
            this.FormDock.DockingOptions.DockTopLeft = true;
            this.FormDock.DockingOptions.DockTopRight = true;
            this.FormDock.FormDraggingOpacity = 0.9D;
            this.FormDock.ParentForm = this;
            this.FormDock.ShowCursorChanges = true;
            this.FormDock.ShowDockingIndicators = true;
            this.FormDock.TitleBarOptions.AllowFormDragging = true;
            this.FormDock.TitleBarOptions.BunifuFormDock = this.FormDock;
            this.FormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.FormDock.TitleBarOptions.TitleBarControl = null;
            this.FormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderRadius = 1;
            this.MainPanel.Controls.Add(this.SaveButton);
            this.MainPanel.Controls.Add(this.ProductPriceTextBox);
            this.MainPanel.Controls.Add(this.LogoLabel);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.MainPanel.GradientTopRight = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(400, 150);
            this.MainPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.AllowAnimations = true;
            this.SaveButton.AllowMouseEffects = true;
            this.SaveButton.AllowToggling = false;
            this.SaveButton.AnimationSpeed = 200;
            this.SaveButton.AutoGenerateColors = false;
            this.SaveButton.AutoRoundBorders = false;
            this.SaveButton.AutoSizeLeftIcon = true;
            this.SaveButton.AutoSizeRightIcon = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.ButtonTextMarginLeft = 0;
            this.SaveButton.ColorContrastOnClick = 45;
            this.SaveButton.ColorContrastOnHover = 45;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SaveButton.CustomizableEdges = borderEdges1;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SaveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveButton.IconMarginLeft = 11;
            this.SaveButton.IconPadding = 10;
            this.SaveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveButton.IconSize = 25;
            this.SaveButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.SaveButton.IdleBorderRadius = 30;
            this.SaveButton.IdleBorderThickness = 2;
            this.SaveButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.SaveButton.IdleIconLeftImage = null;
            this.SaveButton.IdleIconRightImage = null;
            this.SaveButton.IndicateFocus = false;
            this.SaveButton.Location = new System.Drawing.Point(284, 108);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveButton.OnDisabledState.BorderRadius = 30;
            this.SaveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnDisabledState.BorderThickness = 2;
            this.SaveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveButton.OnDisabledState.IconLeftImage = null;
            this.SaveButton.OnDisabledState.IconRightImage = null;
            this.SaveButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveButton.onHoverState.BorderRadius = 30;
            this.SaveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.onHoverState.BorderThickness = 2;
            this.SaveButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.onHoverState.IconLeftImage = null;
            this.SaveButton.onHoverState.IconRightImage = null;
            this.SaveButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.SaveButton.OnIdleState.BorderRadius = 30;
            this.SaveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnIdleState.BorderThickness = 2;
            this.SaveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.SaveButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SaveButton.OnIdleState.IconLeftImage = null;
            this.SaveButton.OnIdleState.IconRightImage = null;
            this.SaveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveButton.OnPressedState.BorderRadius = 30;
            this.SaveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnPressedState.BorderThickness = 2;
            this.SaveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.OnPressedState.IconLeftImage = null;
            this.SaveButton.OnPressedState.IconRightImage = null;
            this.SaveButton.Size = new System.Drawing.Size(104, 38);
            this.SaveButton.TabIndex = 50;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.TextMarginLeft = 0;
            this.SaveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveButton.UseDefaultRadiusAndThickness = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.AcceptsReturn = false;
            this.ProductPriceTextBox.AcceptsTab = false;
            this.ProductPriceTextBox.AnimationSpeed = 200;
            this.ProductPriceTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductPriceTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductPriceTextBox.BackColor = System.Drawing.Color.Transparent;
            this.ProductPriceTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductPriceTextBox.BackgroundImage")));
            this.ProductPriceTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.ProductPriceTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProductPriceTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ProductPriceTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ProductPriceTextBox.BorderRadius = 25;
            this.ProductPriceTextBox.BorderThickness = 1;
            this.ProductPriceTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductPriceTextBox.DefaultText = "";
            this.ProductPriceTextBox.FillColor = System.Drawing.Color.White;
            this.ProductPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ProductPriceTextBox.HideSelection = true;
            this.ProductPriceTextBox.IconLeft = global::WareHouse.Properties.Resources.price_tag;
            this.ProductPriceTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTextBox.IconPadding = 10;
            this.ProductPriceTextBox.IconRight = null;
            this.ProductPriceTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTextBox.Lines = new string[0];
            this.ProductPriceTextBox.Location = new System.Drawing.Point(12, 51);
            this.ProductPriceTextBox.MaxLength = 32767;
            this.ProductPriceTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.ProductPriceTextBox.Modified = false;
            this.ProductPriceTextBox.Multiline = false;
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductPriceTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ProductPriceTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductPriceTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductPriceTextBox.OnIdleState = stateProperties4;
            this.ProductPriceTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPriceTextBox.PasswordChar = '\0';
            this.ProductPriceTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ProductPriceTextBox.PlaceholderText = "Price";
            this.ProductPriceTextBox.ReadOnly = false;
            this.ProductPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductPriceTextBox.SelectedText = "";
            this.ProductPriceTextBox.SelectionLength = 0;
            this.ProductPriceTextBox.SelectionStart = 0;
            this.ProductPriceTextBox.ShortcutsEnabled = true;
            this.ProductPriceTextBox.Size = new System.Drawing.Size(376, 51);
            this.ProductPriceTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ProductPriceTextBox.TabIndex = 42;
            this.ProductPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductPriceTextBox.TextMarginBottom = 0;
            this.ProductPriceTextBox.TextMarginLeft = 10;
            this.ProductPriceTextBox.TextMarginTop = 0;
            this.ProductPriceTextBox.TextPlaceholder = "Price";
            this.ProductPriceTextBox.UseSystemPasswordChar = false;
            this.ProductPriceTextBox.WordWrap = true;
            this.ProductPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductPriceTextBox_KeyPress);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AllowParentOverrides = false;
            this.LogoLabel.AutoEllipsis = false;
            this.LogoLabel.AutoSize = false;
            this.LogoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.LogoLabel.Location = new System.Drawing.Point(115, 3);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoLabel.Size = new System.Drawing.Size(164, 31);
            this.LogoLabel.TabIndex = 38;
            this.LogoLabel.Text = "CSV Report";
            this.LogoLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.LogoLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::WareHouse.Properties.Resources.exit_button;
            this.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitButton.Location = new System.Drawing.Point(12, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 18);
            this.ExitButton.TabIndex = 36;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClientCSVReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientCSVReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Report";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuFormDock FormDock;
        private Bunifu.UI.WinForms.BunifuGradientPanel MainPanel;
        private System.Windows.Forms.Button ExitButton;
        private Bunifu.UI.WinForms.BunifuLabel LogoLabel;
        private Bunifu.UI.WinForms.BunifuTextBox ProductPriceTextBox;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveButton;
    }
}