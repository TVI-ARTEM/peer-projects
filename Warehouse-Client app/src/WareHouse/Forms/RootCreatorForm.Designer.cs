using System.ComponentModel;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using BunifuGradientPanel = Bunifu.UI.WinForms.BunifuGradientPanel;
using WareHouse.AppResources;

namespace WareHouse.Forms
{
    partial class RootCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootCreatorForm));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.FormCancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainCards = new Bunifu.Framework.UI.BunifuCards();
            this.RootNameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RootNameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.MainCards.Controls.Add(this.RootNameLabel);
            this.MainCards.Controls.Add(this.RootNameTextBox);
            this.MainCards.LeftSahddow = false;
            resources.ApplyResources(this.MainCards, "MainCards");
            this.MainCards.Name = "MainCards";
            this.MainCards.RightSahddow = true;
            this.MainCards.ShadowDepth = 20;
            // 
            // RootNameLabel
            // 
            this.RootNameLabel.AllowParentOverrides = false;
            this.RootNameLabel.AutoEllipsis = false;
            this.RootNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RootNameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.RootNameLabel, "RootNameLabel");
            this.RootNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RootNameLabel.Name = "RootNameLabel";
            this.RootNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RootNameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RootNameTextBox
            // 
            this.RootNameTextBox.AcceptsReturn = false;
            this.RootNameTextBox.AcceptsTab = false;
            this.RootNameTextBox.AnimationSpeed = 200;
            this.RootNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RootNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RootNameTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.RootNameTextBox, "RootNameTextBox");
            this.RootNameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.RootNameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RootNameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RootNameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.RootNameTextBox.BorderRadius = 1;
            this.RootNameTextBox.BorderThickness = 1;
            this.RootNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RootNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RootNameTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RootNameTextBox.DefaultText = "";
            this.RootNameTextBox.FillColor = System.Drawing.Color.White;
            this.RootNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RootNameTextBox.HideSelection = true;
            this.RootNameTextBox.IconLeft = null;
            this.RootNameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.RootNameTextBox.IconPadding = 10;
            this.RootNameTextBox.IconRight = null;
            this.RootNameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.RootNameTextBox.Lines = new string[0];
            this.RootNameTextBox.MaxLength = 32767;
            this.RootNameTextBox.Modified = false;
            this.RootNameTextBox.Multiline = false;
            this.RootNameTextBox.Name = "RootNameTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RootNameTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.RootNameTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RootNameTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RootNameTextBox.OnIdleState = stateProperties4;
            this.RootNameTextBox.PasswordChar = '\0';
            this.RootNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.RootNameTextBox.PlaceholderText = global::WareHouse.AppResources.ApplicationStrings.RootNamePlaceholder;
            this.RootNameTextBox.ReadOnly = false;
            this.RootNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RootNameTextBox.SelectedText = "";
            this.RootNameTextBox.SelectionLength = 0;
            this.RootNameTextBox.SelectionStart = 0;
            this.RootNameTextBox.ShortcutsEnabled = true;
            this.RootNameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.RootNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RootNameTextBox.TextMarginBottom = 0;
            this.RootNameTextBox.TextMarginLeft = 3;
            this.RootNameTextBox.TextMarginTop = 0;
            this.RootNameTextBox.TextPlaceholder = global::WareHouse.AppResources.ApplicationStrings.RootNamePlaceholder;
            this.RootNameTextBox.UseSystemPasswordChar = false;
            this.RootNameTextBox.WordWrap = true;
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
            // RootCreatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RootCreatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RootCreatorForm_FormClosing);
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainCards.ResumeLayout(false);
            this.MainCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuElipse Elipse;
        private BunifuGradientPanel ToolPanel;
        private BunifuLabel TitleLabel;
        private BunifuGradientPanel MainPanel;
        private BunifuDragControl DragControlTitle;
        private BunifuDragControl DragControlMainPanel;
        private BunifuDragControl DragControlToolPanel;
        private BunifuCards MainCards;
        private BunifuButton FormCancelButton;
        private BunifuButton OKButton;
        private BunifuLabel RootNameLabel;
        private BunifuTextBox RootNameTextBox;
    }
}