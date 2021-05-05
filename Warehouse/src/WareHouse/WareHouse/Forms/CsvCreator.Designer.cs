
namespace WareHouse.Forms
{
    partial class CsvCreator
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CsvCreator));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.FormCancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainCards = new Bunifu.Framework.UI.BunifuCards();
            this.ProductQuantityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ProductQuantityTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.OKButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DragControlTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlMainPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlToolPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ToolPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ToolPanel, "ToolPanel");
            this.ToolPanel.BorderRadius = 1;
            this.ToolPanel.Controls.Add(this.TitleLabel);
            this.ToolPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Quality = 10;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BorderRadius = 1;
            this.MainPanel.Controls.Add(this.FormCancelButton);
            this.MainPanel.Controls.Add(this.MainCards);
            this.MainPanel.Controls.Add(this.OKButton);
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.AllowAnimations = true;
            this.FormCancelButton.AllowMouseEffects = true;
            this.FormCancelButton.AllowToggling = false;
            this.FormCancelButton.AnimationSpeed = 200;
            this.FormCancelButton.AutoGenerateColors = false;
            this.FormCancelButton.AutoRoundBorders = false;
            this.FormCancelButton.AutoSizeLeftIcon = true;
            this.FormCancelButton.AutoSizeRightIcon = true;
            this.FormCancelButton.BackColor = System.Drawing.Color.Transparent;
            this.FormCancelButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.FormCancelButton, "FormCancelButton");
            this.FormCancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.ButtonText = "Cancel";
            this.FormCancelButton.ButtonTextMarginLeft = 0;
            this.FormCancelButton.ColorContrastOnClick = 45;
            this.FormCancelButton.ColorContrastOnHover = 45;
            this.FormCancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.FormCancelButton.CustomizableEdges = borderEdges1;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FormCancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormCancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FormCancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.FormCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.FormCancelButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FormCancelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.FormCancelButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.FormCancelButton.IconMarginLeft = 11;
            this.FormCancelButton.IconPadding = 10;
            this.FormCancelButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FormCancelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.FormCancelButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.FormCancelButton.IconSize = 25;
            this.FormCancelButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.FormCancelButton.IdleBorderRadius = 30;
            this.FormCancelButton.IdleBorderThickness = 2;
            this.FormCancelButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.FormCancelButton.IdleIconLeftImage = null;
            this.FormCancelButton.IdleIconRightImage = null;
            this.FormCancelButton.IndicateFocus = false;
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FormCancelButton.OnDisabledState.BorderRadius = 30;
            this.FormCancelButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.OnDisabledState.BorderThickness = 2;
            this.FormCancelButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormCancelButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FormCancelButton.OnDisabledState.IconLeftImage = null;
            this.FormCancelButton.OnDisabledState.IconRightImage = null;
            this.FormCancelButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FormCancelButton.onHoverState.BorderRadius = 30;
            this.FormCancelButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.onHoverState.BorderThickness = 2;
            this.FormCancelButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FormCancelButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.FormCancelButton.onHoverState.IconLeftImage = null;
            this.FormCancelButton.onHoverState.IconRightImage = null;
            this.FormCancelButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.FormCancelButton.OnIdleState.BorderRadius = 30;
            this.FormCancelButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.OnIdleState.BorderThickness = 2;
            this.FormCancelButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.FormCancelButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.FormCancelButton.OnIdleState.IconLeftImage = null;
            this.FormCancelButton.OnIdleState.IconRightImage = null;
            this.FormCancelButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FormCancelButton.OnPressedState.BorderRadius = 30;
            this.FormCancelButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.OnPressedState.BorderThickness = 2;
            this.FormCancelButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.FormCancelButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.FormCancelButton.OnPressedState.IconLeftImage = null;
            this.FormCancelButton.OnPressedState.IconRightImage = null;
            this.FormCancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormCancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.FormCancelButton.TextMarginLeft = 0;
            this.FormCancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.FormCancelButton.UseDefaultRadiusAndThickness = true;
            // 
            // MainCards
            // 
            this.MainCards.BackColor = System.Drawing.Color.White;
            this.MainCards.BorderRadius = 5;
            this.MainCards.BottomSahddow = true;
            this.MainCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.MainCards.Controls.Add(this.ProductQuantityLabel);
            this.MainCards.Controls.Add(this.ProductQuantityTextBox);
            this.MainCards.LeftSahddow = false;
            resources.ApplyResources(this.MainCards, "MainCards");
            this.MainCards.Name = "MainCards";
            this.MainCards.RightSahddow = true;
            this.MainCards.ShadowDepth = 20;
            // 
            // ProductQuantityLabel
            // 
            this.ProductQuantityLabel.AllowParentOverrides = false;
            this.ProductQuantityLabel.AutoEllipsis = false;
            this.ProductQuantityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductQuantityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ProductQuantityLabel, "ProductQuantityLabel");
            this.ProductQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ProductQuantityLabel.Name = "ProductQuantityLabel";
            this.ProductQuantityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ProductQuantityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProductQuantityTextBox
            // 
            this.ProductQuantityTextBox.AcceptsReturn = false;
            this.ProductQuantityTextBox.AcceptsTab = false;
            this.ProductQuantityTextBox.AnimationSpeed = 200;
            this.ProductQuantityTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProductQuantityTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProductQuantityTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ProductQuantityTextBox, "ProductQuantityTextBox");
            this.ProductQuantityTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.ProductQuantityTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProductQuantityTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ProductQuantityTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.ProductQuantityTextBox.BorderRadius = 1;
            this.ProductQuantityTextBox.BorderThickness = 1;
            this.ProductQuantityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProductQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantityTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductQuantityTextBox.DefaultText = "";
            this.ProductQuantityTextBox.FillColor = System.Drawing.Color.White;
            this.ProductQuantityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ProductQuantityTextBox.HideSelection = true;
            this.ProductQuantityTextBox.IconLeft = null;
            this.ProductQuantityTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantityTextBox.IconPadding = 10;
            this.ProductQuantityTextBox.IconRight = null;
            this.ProductQuantityTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantityTextBox.Lines = new string[0];
            this.ProductQuantityTextBox.MaxLength = 32767;
            this.ProductQuantityTextBox.Modified = false;
            this.ProductQuantityTextBox.Multiline = false;
            this.ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductQuantityTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ProductQuantityTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductQuantityTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProductQuantityTextBox.OnIdleState = stateProperties4;
            this.ProductQuantityTextBox.PasswordChar = '\0';
            this.ProductQuantityTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ProductQuantityTextBox.PlaceholderText = "Enter minimum quantity";
            this.ProductQuantityTextBox.ReadOnly = false;
            this.ProductQuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductQuantityTextBox.SelectedText = "";
            this.ProductQuantityTextBox.SelectionLength = 0;
            this.ProductQuantityTextBox.SelectionStart = 0;
            this.ProductQuantityTextBox.ShortcutsEnabled = true;
            this.ProductQuantityTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ProductQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductQuantityTextBox.TextMarginBottom = 0;
            this.ProductQuantityTextBox.TextMarginLeft = 3;
            this.ProductQuantityTextBox.TextMarginTop = 0;
            this.ProductQuantityTextBox.TextPlaceholder = "Enter minimum quantity";
            this.ProductQuantityTextBox.UseSystemPasswordChar = false;
            this.ProductQuantityTextBox.WordWrap = true;
            this.ProductQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductQuantityTextBox_KeyPress);
            // 
            // OKButton
            // 
            this.OKButton.AllowAnimations = true;
            this.OKButton.AllowMouseEffects = true;
            this.OKButton.AllowToggling = false;
            this.OKButton.AnimationSpeed = 200;
            this.OKButton.AutoGenerateColors = false;
            this.OKButton.AutoRoundBorders = false;
            this.OKButton.AutoSizeLeftIcon = true;
            this.OKButton.AutoSizeRightIcon = true;
            this.OKButton.BackColor = System.Drawing.Color.Transparent;
            this.OKButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.OKButton, "OKButton");
            this.OKButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OKButton.ButtonText = "OK";
            this.OKButton.ButtonTextMarginLeft = 0;
            this.OKButton.ColorContrastOnClick = 45;
            this.OKButton.ColorContrastOnHover = 45;
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.OKButton.CustomizableEdges = borderEdges2;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.OKButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OKButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.OKButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.OKButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.OKButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OKButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.OKButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.OKButton.IconMarginLeft = 11;
            this.OKButton.IconPadding = 10;
            this.OKButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.OKButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.OKButton.IconSize = 25;
            this.OKButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.OKButton.IdleBorderRadius = 30;
            this.OKButton.IdleBorderThickness = 2;
            this.OKButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.OKButton.IdleIconLeftImage = null;
            this.OKButton.IdleIconRightImage = null;
            this.OKButton.IndicateFocus = false;
            this.OKButton.Name = "OKButton";
            this.OKButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.OKButton.OnDisabledState.BorderRadius = 30;
            this.OKButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OKButton.OnDisabledState.BorderThickness = 2;
            this.OKButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OKButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.OKButton.OnDisabledState.IconLeftImage = null;
            this.OKButton.OnDisabledState.IconRightImage = null;
            this.OKButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.OKButton.onHoverState.BorderRadius = 30;
            this.OKButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OKButton.onHoverState.BorderThickness = 2;
            this.OKButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.OKButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.OKButton.onHoverState.IconLeftImage = null;
            this.OKButton.onHoverState.IconRightImage = null;
            this.OKButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.OKButton.OnIdleState.BorderRadius = 30;
            this.OKButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OKButton.OnIdleState.BorderThickness = 2;
            this.OKButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.OKButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.OKButton.OnIdleState.IconLeftImage = null;
            this.OKButton.OnIdleState.IconRightImage = null;
            this.OKButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.OKButton.OnPressedState.BorderRadius = 30;
            this.OKButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OKButton.OnPressedState.BorderThickness = 2;
            this.OKButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.OKButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.OKButton.OnPressedState.IconLeftImage = null;
            this.OKButton.OnPressedState.IconRightImage = null;
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.OKButton.TextMarginLeft = 0;
            this.OKButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.OKButton.UseDefaultRadiusAndThickness = true;
            // 
            // DragControlTitle
            // 
            this.DragControlTitle.Fixed = true;
            this.DragControlTitle.Horizontal = true;
            this.DragControlTitle.TargetControl = this.TitleLabel;
            this.DragControlTitle.Vertical = true;
            // 
            // DragControlMainPanel
            // 
            this.DragControlMainPanel.Fixed = true;
            this.DragControlMainPanel.Horizontal = true;
            this.DragControlMainPanel.TargetControl = this.MainPanel;
            this.DragControlMainPanel.Vertical = true;
            // 
            // DragControlToolPanel
            // 
            this.DragControlToolPanel.Fixed = true;
            this.DragControlToolPanel.Horizontal = true;
            this.DragControlToolPanel.TargetControl = this.ToolPanel;
            this.DragControlToolPanel.Vertical = true;
            // 
            // CsvCreator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CsvCreator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsvCreator_FormClosing);
            this.Load += new System.EventHandler(this.CsvCreator_Load);
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainCards.ResumeLayout(false);
            this.MainCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuGradientPanel ToolPanel;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuGradientPanel MainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton FormCancelButton;
        private Bunifu.Framework.UI.BunifuCards MainCards;
        private Bunifu.UI.WinForms.BunifuLabel ProductQuantityLabel;
        private Bunifu.UI.WinForms.BunifuTextBox ProductQuantityTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton OKButton;
        private Bunifu.Framework.UI.BunifuDragControl DragControlTitle;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMainPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControlToolPanel;
    }
}