using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using BunifuGradientPanel = Bunifu.UI.WinForms.BunifuGradientPanel;
using WareHouse.AppResources;


namespace WareHouse.Forms
{
    partial class CompanyCreatorForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyCreatorForm));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.CancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.OKButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CompanyPage = new Bunifu.UI.WinForms.BunifuPages();
            this.GeneralSettingsPage = new System.Windows.Forms.TabPage();
            this.ChangeImgButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CompanyImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ImageLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DescriptionLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.CompanyDescriptionTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CompanyPhoneNumberLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CompanyPhoneNumberTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CompanyChiefLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CompanyChiefTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CompanyAdressLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CompanyAddressTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CompanyNameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.CompanyNameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.DragControlToolPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlMainPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ToolPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.CompanyPage.SuspendLayout();
            this.GeneralSettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyImage)).BeginInit();
            this.DescriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.BorderRadius = 1;
            this.MainPanel.Controls.Add(this.CancelButton);
            this.MainPanel.Controls.Add(this.OKButton);
            this.MainPanel.Controls.Add(this.CompanyPage);
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.AllowAnimations = true;
            this.CancelButton.AllowMouseEffects = true;
            this.CancelButton.AllowToggling = false;
            this.CancelButton.AnimationSpeed = 200;
            this.CancelButton.AutoGenerateColors = false;
            this.CancelButton.AutoRoundBorders = false;
            this.CancelButton.AutoSizeLeftIcon = true;
            this.CancelButton.AutoSizeRightIcon = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelButton.ButtonText = "Cancel";
            this.CancelButton.ButtonTextMarginLeft = 0;
            this.CancelButton.ColorContrastOnClick = 45;
            this.CancelButton.ColorContrastOnHover = 45;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.CancelButton.CustomizableEdges = borderEdges1;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CancelButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CancelButton.IconMarginLeft = 11;
            this.CancelButton.IconPadding = 10;
            this.CancelButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CancelButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CancelButton.IconSize = 25;
            this.CancelButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.CancelButton.IdleBorderRadius = 30;
            this.CancelButton.IdleBorderThickness = 2;
            this.CancelButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CancelButton.IdleIconLeftImage = null;
            this.CancelButton.IdleIconRightImage = null;
            this.CancelButton.IndicateFocus = false;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CancelButton.OnDisabledState.BorderRadius = 30;
            this.CancelButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelButton.OnDisabledState.BorderThickness = 2;
            this.CancelButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CancelButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CancelButton.OnDisabledState.IconLeftImage = null;
            this.CancelButton.OnDisabledState.IconRightImage = null;
            this.CancelButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CancelButton.onHoverState.BorderRadius = 30;
            this.CancelButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelButton.onHoverState.BorderThickness = 2;
            this.CancelButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CancelButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CancelButton.onHoverState.IconLeftImage = null;
            this.CancelButton.onHoverState.IconRightImage = null;
            this.CancelButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.CancelButton.OnIdleState.BorderRadius = 30;
            this.CancelButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelButton.OnIdleState.BorderThickness = 2;
            this.CancelButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.CancelButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CancelButton.OnIdleState.IconLeftImage = null;
            this.CancelButton.OnIdleState.IconRightImage = null;
            this.CancelButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CancelButton.OnPressedState.BorderRadius = 30;
            this.CancelButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CancelButton.OnPressedState.BorderThickness = 2;
            this.CancelButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CancelButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CancelButton.OnPressedState.IconLeftImage = null;
            this.CancelButton.OnPressedState.IconRightImage = null;
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.TextMarginLeft = 0;
            this.CancelButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CancelButton.UseDefaultRadiusAndThickness = true;
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
            // CompanyPage
            // 
            resources.ApplyResources(this.CompanyPage, "CompanyPage");
            this.CompanyPage.AllowTransitions = true;
            this.CompanyPage.Controls.Add(this.GeneralSettingsPage);
            this.CompanyPage.Multiline = true;
            this.CompanyPage.Name = "CompanyPage";
            this.CompanyPage.Page = this.GeneralSettingsPage;
            this.CompanyPage.PageIndex = 0;
            this.CompanyPage.PageName = "GeneralSettingsPage";
            this.CompanyPage.PageTitle = "General";
            this.CompanyPage.SelectedIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.CompanyPage.Transition = animation1;
            this.CompanyPage.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // GeneralSettingsPage
            // 
            this.GeneralSettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.GeneralSettingsPage.Controls.Add(this.ChangeImgButton);
            this.GeneralSettingsPage.Controls.Add(this.CompanyImage);
            this.GeneralSettingsPage.Controls.Add(this.ImageLabel);
            this.GeneralSettingsPage.Controls.Add(this.DescriptionLabel);
            this.GeneralSettingsPage.Controls.Add(this.DescriptionPanel);
            this.GeneralSettingsPage.Controls.Add(this.CompanyPhoneNumberLabel);
            this.GeneralSettingsPage.Controls.Add(this.CompanyPhoneNumberTextBox);
            this.GeneralSettingsPage.Controls.Add(this.CompanyChiefLabel);
            this.GeneralSettingsPage.Controls.Add(this.CompanyChiefTextBox);
            this.GeneralSettingsPage.Controls.Add(this.CompanyAdressLabel);
            this.GeneralSettingsPage.Controls.Add(this.CompanyAddressTextBox);
            this.GeneralSettingsPage.Controls.Add(this.CompanyNameLabel);
            this.GeneralSettingsPage.Controls.Add(this.CompanyNameTextBox);
            resources.ApplyResources(this.GeneralSettingsPage, "GeneralSettingsPage");
            this.GeneralSettingsPage.Name = "GeneralSettingsPage";
            // 
            // ChangeImgButton
            // 
            this.ChangeImgButton.AllowAnimations = true;
            this.ChangeImgButton.AllowMouseEffects = true;
            this.ChangeImgButton.AllowToggling = false;
            this.ChangeImgButton.AnimationSpeed = 200;
            this.ChangeImgButton.AutoGenerateColors = false;
            this.ChangeImgButton.AutoRoundBorders = false;
            this.ChangeImgButton.AutoSizeLeftIcon = true;
            this.ChangeImgButton.AutoSizeRightIcon = true;
            this.ChangeImgButton.BackColor = System.Drawing.Color.Transparent;
            this.ChangeImgButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            resources.ApplyResources(this.ChangeImgButton, "ChangeImgButton");
            this.ChangeImgButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeImgButton.ButtonText = "Change";
            this.ChangeImgButton.ButtonTextMarginLeft = 0;
            this.ChangeImgButton.ColorContrastOnClick = 45;
            this.ChangeImgButton.ColorContrastOnHover = 45;
            this.ChangeImgButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ChangeImgButton.CustomizableEdges = borderEdges3;
            this.ChangeImgButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChangeImgButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeImgButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeImgButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeImgButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ChangeImgButton.ForeColor = System.Drawing.Color.White;
            this.ChangeImgButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeImgButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeImgButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ChangeImgButton.IconMarginLeft = 11;
            this.ChangeImgButton.IconPadding = 10;
            this.ChangeImgButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeImgButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ChangeImgButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ChangeImgButton.IconSize = 25;
            this.ChangeImgButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ChangeImgButton.IdleBorderRadius = 30;
            this.ChangeImgButton.IdleBorderThickness = 2;
            this.ChangeImgButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ChangeImgButton.IdleIconLeftImage = null;
            this.ChangeImgButton.IdleIconRightImage = null;
            this.ChangeImgButton.IndicateFocus = false;
            this.ChangeImgButton.Name = "ChangeImgButton";
            this.ChangeImgButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ChangeImgButton.OnDisabledState.BorderRadius = 30;
            this.ChangeImgButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeImgButton.OnDisabledState.BorderThickness = 2;
            this.ChangeImgButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ChangeImgButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ChangeImgButton.OnDisabledState.IconLeftImage = null;
            this.ChangeImgButton.OnDisabledState.IconRightImage = null;
            this.ChangeImgButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeImgButton.onHoverState.BorderRadius = 30;
            this.ChangeImgButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeImgButton.onHoverState.BorderThickness = 2;
            this.ChangeImgButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ChangeImgButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ChangeImgButton.onHoverState.IconLeftImage = null;
            this.ChangeImgButton.onHoverState.IconRightImage = null;
            this.ChangeImgButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ChangeImgButton.OnIdleState.BorderRadius = 30;
            this.ChangeImgButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeImgButton.OnIdleState.BorderThickness = 2;
            this.ChangeImgButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.ChangeImgButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ChangeImgButton.OnIdleState.IconLeftImage = null;
            this.ChangeImgButton.OnIdleState.IconRightImage = null;
            this.ChangeImgButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeImgButton.OnPressedState.BorderRadius = 30;
            this.ChangeImgButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ChangeImgButton.OnPressedState.BorderThickness = 2;
            this.ChangeImgButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ChangeImgButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ChangeImgButton.OnPressedState.IconLeftImage = null;
            this.ChangeImgButton.OnPressedState.IconRightImage = null;
            this.ChangeImgButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeImgButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangeImgButton.TextMarginLeft = 0;
            this.ChangeImgButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ChangeImgButton.UseDefaultRadiusAndThickness = true;
            this.ChangeImgButton.Click += new System.EventHandler(this.ChangeImgButton_Click);
            // 
            // CompanyImage
            // 
            this.CompanyImage.AllowFocused = false;
            resources.ApplyResources(this.CompanyImage, "CompanyImage");
            this.CompanyImage.AutoSizeHeight = true;
            this.CompanyImage.BorderRadius = 91;
            this.CompanyImage.Image = global::WareHouse.Properties.Resources.Company___default;
            this.CompanyImage.IsCircle = true;
            this.CompanyImage.Name = "CompanyImage";
            this.CompanyImage.TabStop = false;
            this.CompanyImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AllowParentOverrides = false;
            this.ImageLabel.AutoEllipsis = false;
            this.ImageLabel.CursorType = null;
            resources.ApplyResources(this.ImageLabel, "ImageLabel");
            this.ImageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ImageLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AllowParentOverrides = false;
            this.DescriptionLabel.AutoEllipsis = false;
            this.DescriptionLabel.CursorType = null;
            resources.ApplyResources(this.DescriptionLabel, "DescriptionLabel");
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DescriptionLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.Controls.Add(this.CompanyDescriptionTextBox);
            resources.ApplyResources(this.DescriptionPanel, "DescriptionPanel");
            this.DescriptionPanel.Name = "DescriptionPanel";
            // 
            // CompanyDescriptionTextBox
            // 
            this.CompanyDescriptionTextBox.AcceptsReturn = false;
            this.CompanyDescriptionTextBox.AcceptsTab = false;
            this.CompanyDescriptionTextBox.AnimationSpeed = 200;
            this.CompanyDescriptionTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyDescriptionTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyDescriptionTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CompanyDescriptionTextBox, "CompanyDescriptionTextBox");
            this.CompanyDescriptionTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CompanyDescriptionTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompanyDescriptionTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CompanyDescriptionTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CompanyDescriptionTextBox.BorderRadius = 10;
            this.CompanyDescriptionTextBox.BorderThickness = 3;
            this.CompanyDescriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyDescriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyDescriptionTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyDescriptionTextBox.DefaultText = "";
            this.CompanyDescriptionTextBox.FillColor = System.Drawing.Color.White;
            this.CompanyDescriptionTextBox.HideSelection = true;
            this.CompanyDescriptionTextBox.IconLeft = null;
            this.CompanyDescriptionTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyDescriptionTextBox.IconPadding = 10;
            this.CompanyDescriptionTextBox.IconRight = null;
            this.CompanyDescriptionTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyDescriptionTextBox.Lines = new string[0];
            this.CompanyDescriptionTextBox.MaxLength = 32767;
            this.CompanyDescriptionTextBox.Modified = false;
            this.CompanyDescriptionTextBox.Multiline = true;
            this.CompanyDescriptionTextBox.Name = "CompanyDescriptionTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyDescriptionTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CompanyDescriptionTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyDescriptionTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyDescriptionTextBox.OnIdleState = stateProperties4;
            this.CompanyDescriptionTextBox.PasswordChar = '\0';
            this.CompanyDescriptionTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CompanyDescriptionTextBox.PlaceholderText = "Enter text";
            this.CompanyDescriptionTextBox.ReadOnly = false;
            this.CompanyDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CompanyDescriptionTextBox.SelectedText = "";
            this.CompanyDescriptionTextBox.SelectionLength = 0;
            this.CompanyDescriptionTextBox.SelectionStart = 0;
            this.CompanyDescriptionTextBox.ShortcutsEnabled = true;
            this.CompanyDescriptionTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CompanyDescriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyDescriptionTextBox.TextMarginBottom = 0;
            this.CompanyDescriptionTextBox.TextMarginLeft = 10;
            this.CompanyDescriptionTextBox.TextMarginTop = 10;
            this.CompanyDescriptionTextBox.TextPlaceholder = "Enter text";
            this.CompanyDescriptionTextBox.UseSystemPasswordChar = false;
            this.CompanyDescriptionTextBox.WordWrap = true;
            // 
            // CompanyPhoneNumberLabel
            // 
            this.CompanyPhoneNumberLabel.AllowParentOverrides = false;
            this.CompanyPhoneNumberLabel.AutoEllipsis = false;
            this.CompanyPhoneNumberLabel.CursorType = null;
            resources.ApplyResources(this.CompanyPhoneNumberLabel, "CompanyPhoneNumberLabel");
            this.CompanyPhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyPhoneNumberLabel.Name = "CompanyPhoneNumberLabel";
            this.CompanyPhoneNumberLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CompanyPhoneNumberLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CompanyPhoneNumberTextBox
            // 
            this.CompanyPhoneNumberTextBox.AcceptsReturn = false;
            this.CompanyPhoneNumberTextBox.AcceptsTab = false;
            this.CompanyPhoneNumberTextBox.AnimationSpeed = 200;
            this.CompanyPhoneNumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyPhoneNumberTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyPhoneNumberTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CompanyPhoneNumberTextBox, "CompanyPhoneNumberTextBox");
            this.CompanyPhoneNumberTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CompanyPhoneNumberTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompanyPhoneNumberTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CompanyPhoneNumberTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CompanyPhoneNumberTextBox.BorderRadius = 1;
            this.CompanyPhoneNumberTextBox.BorderThickness = 1;
            this.CompanyPhoneNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyPhoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyPhoneNumberTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyPhoneNumberTextBox.DefaultText = "";
            this.CompanyPhoneNumberTextBox.FillColor = System.Drawing.Color.White;
            this.CompanyPhoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyPhoneNumberTextBox.HideSelection = true;
            this.CompanyPhoneNumberTextBox.IconLeft = null;
            this.CompanyPhoneNumberTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyPhoneNumberTextBox.IconPadding = 10;
            this.CompanyPhoneNumberTextBox.IconRight = null;
            this.CompanyPhoneNumberTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyPhoneNumberTextBox.Lines = new string[0];
            this.CompanyPhoneNumberTextBox.MaxLength = 32767;
            this.CompanyPhoneNumberTextBox.Modified = false;
            this.CompanyPhoneNumberTextBox.Multiline = false;
            this.CompanyPhoneNumberTextBox.Name = "CompanyPhoneNumberTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyPhoneNumberTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CompanyPhoneNumberTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyPhoneNumberTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyPhoneNumberTextBox.OnIdleState = stateProperties8;
            this.CompanyPhoneNumberTextBox.PasswordChar = '\0';
            this.CompanyPhoneNumberTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CompanyPhoneNumberTextBox.PlaceholderText = "Enter phone number";
            this.CompanyPhoneNumberTextBox.ReadOnly = false;
            this.CompanyPhoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyPhoneNumberTextBox.SelectedText = "";
            this.CompanyPhoneNumberTextBox.SelectionLength = 0;
            this.CompanyPhoneNumberTextBox.SelectionStart = 0;
            this.CompanyPhoneNumberTextBox.ShortcutsEnabled = true;
            this.CompanyPhoneNumberTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CompanyPhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyPhoneNumberTextBox.TextMarginBottom = 0;
            this.CompanyPhoneNumberTextBox.TextMarginLeft = 3;
            this.CompanyPhoneNumberTextBox.TextMarginTop = 0;
            this.CompanyPhoneNumberTextBox.TextPlaceholder = "Enter phone number";
            this.CompanyPhoneNumberTextBox.UseSystemPasswordChar = false;
            this.CompanyPhoneNumberTextBox.WordWrap = true;
            // 
            // CompanyChiefLabel
            // 
            this.CompanyChiefLabel.AllowParentOverrides = false;
            this.CompanyChiefLabel.AutoEllipsis = false;
            this.CompanyChiefLabel.CursorType = null;
            resources.ApplyResources(this.CompanyChiefLabel, "CompanyChiefLabel");
            this.CompanyChiefLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyChiefLabel.Name = "CompanyChiefLabel";
            this.CompanyChiefLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CompanyChiefLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CompanyChiefTextBox
            // 
            this.CompanyChiefTextBox.AcceptsReturn = false;
            this.CompanyChiefTextBox.AcceptsTab = false;
            this.CompanyChiefTextBox.AnimationSpeed = 200;
            this.CompanyChiefTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyChiefTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyChiefTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CompanyChiefTextBox, "CompanyChiefTextBox");
            this.CompanyChiefTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CompanyChiefTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompanyChiefTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CompanyChiefTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CompanyChiefTextBox.BorderRadius = 1;
            this.CompanyChiefTextBox.BorderThickness = 1;
            this.CompanyChiefTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyChiefTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyChiefTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyChiefTextBox.DefaultText = "";
            this.CompanyChiefTextBox.FillColor = System.Drawing.Color.White;
            this.CompanyChiefTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyChiefTextBox.HideSelection = true;
            this.CompanyChiefTextBox.IconLeft = null;
            this.CompanyChiefTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyChiefTextBox.IconPadding = 10;
            this.CompanyChiefTextBox.IconRight = null;
            this.CompanyChiefTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyChiefTextBox.Lines = new string[0];
            this.CompanyChiefTextBox.MaxLength = 32767;
            this.CompanyChiefTextBox.Modified = false;
            this.CompanyChiefTextBox.Multiline = false;
            this.CompanyChiefTextBox.Name = "CompanyChiefTextBox";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyChiefTextBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CompanyChiefTextBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyChiefTextBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyChiefTextBox.OnIdleState = stateProperties12;
            this.CompanyChiefTextBox.PasswordChar = '\0';
            this.CompanyChiefTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CompanyChiefTextBox.PlaceholderText = "Enter company chief name";
            this.CompanyChiefTextBox.ReadOnly = false;
            this.CompanyChiefTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyChiefTextBox.SelectedText = "";
            this.CompanyChiefTextBox.SelectionLength = 0;
            this.CompanyChiefTextBox.SelectionStart = 0;
            this.CompanyChiefTextBox.ShortcutsEnabled = true;
            this.CompanyChiefTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CompanyChiefTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyChiefTextBox.TextMarginBottom = 0;
            this.CompanyChiefTextBox.TextMarginLeft = 3;
            this.CompanyChiefTextBox.TextMarginTop = 0;
            this.CompanyChiefTextBox.TextPlaceholder = "Enter company chief name";
            this.CompanyChiefTextBox.UseSystemPasswordChar = false;
            this.CompanyChiefTextBox.WordWrap = true;
            // 
            // CompanyAdressLabel
            // 
            this.CompanyAdressLabel.AllowParentOverrides = false;
            this.CompanyAdressLabel.AutoEllipsis = false;
            this.CompanyAdressLabel.CursorType = null;
            resources.ApplyResources(this.CompanyAdressLabel, "CompanyAdressLabel");
            this.CompanyAdressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyAdressLabel.Name = "CompanyAdressLabel";
            this.CompanyAdressLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CompanyAdressLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CompanyAddressTextBox
            // 
            this.CompanyAddressTextBox.AcceptsReturn = false;
            this.CompanyAddressTextBox.AcceptsTab = false;
            this.CompanyAddressTextBox.AnimationSpeed = 200;
            this.CompanyAddressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyAddressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyAddressTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CompanyAddressTextBox, "CompanyAddressTextBox");
            this.CompanyAddressTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CompanyAddressTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompanyAddressTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CompanyAddressTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CompanyAddressTextBox.BorderRadius = 1;
            this.CompanyAddressTextBox.BorderThickness = 1;
            this.CompanyAddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyAddressTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyAddressTextBox.DefaultText = "";
            this.CompanyAddressTextBox.FillColor = System.Drawing.Color.White;
            this.CompanyAddressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyAddressTextBox.HideSelection = true;
            this.CompanyAddressTextBox.IconLeft = null;
            this.CompanyAddressTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyAddressTextBox.IconPadding = 10;
            this.CompanyAddressTextBox.IconRight = null;
            this.CompanyAddressTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyAddressTextBox.Lines = new string[0];
            this.CompanyAddressTextBox.MaxLength = 32767;
            this.CompanyAddressTextBox.Modified = false;
            this.CompanyAddressTextBox.Multiline = false;
            this.CompanyAddressTextBox.Name = "CompanyAddressTextBox";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyAddressTextBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CompanyAddressTextBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyAddressTextBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyAddressTextBox.OnIdleState = stateProperties16;
            this.CompanyAddressTextBox.PasswordChar = '\0';
            this.CompanyAddressTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CompanyAddressTextBox.PlaceholderText = "Enter company adress";
            this.CompanyAddressTextBox.ReadOnly = false;
            this.CompanyAddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyAddressTextBox.SelectedText = "";
            this.CompanyAddressTextBox.SelectionLength = 0;
            this.CompanyAddressTextBox.SelectionStart = 0;
            this.CompanyAddressTextBox.ShortcutsEnabled = true;
            this.CompanyAddressTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CompanyAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyAddressTextBox.TextMarginBottom = 0;
            this.CompanyAddressTextBox.TextMarginLeft = 3;
            this.CompanyAddressTextBox.TextMarginTop = 0;
            this.CompanyAddressTextBox.TextPlaceholder = "Enter company adress";
            this.CompanyAddressTextBox.UseSystemPasswordChar = false;
            this.CompanyAddressTextBox.WordWrap = true;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AllowParentOverrides = false;
            this.CompanyNameLabel.AutoEllipsis = false;
            this.CompanyNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CompanyNameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.CompanyNameLabel, "CompanyNameLabel");
            this.CompanyNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CompanyNameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.AcceptsReturn = false;
            this.CompanyNameTextBox.AcceptsTab = false;
            this.CompanyNameTextBox.AnimationSpeed = 200;
            this.CompanyNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CompanyNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CompanyNameTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CompanyNameTextBox, "CompanyNameTextBox");
            this.CompanyNameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CompanyNameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CompanyNameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CompanyNameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.CompanyNameTextBox.BorderRadius = 1;
            this.CompanyNameTextBox.BorderThickness = 1;
            this.CompanyNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CompanyNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyNameTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameTextBox.DefaultText = "";
            this.CompanyNameTextBox.FillColor = System.Drawing.Color.White;
            this.CompanyNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.CompanyNameTextBox.HideSelection = true;
            this.CompanyNameTextBox.IconLeft = null;
            this.CompanyNameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyNameTextBox.IconPadding = 10;
            this.CompanyNameTextBox.IconRight = null;
            this.CompanyNameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyNameTextBox.Lines = new string[0];
            this.CompanyNameTextBox.MaxLength = 32767;
            this.CompanyNameTextBox.Modified = false;
            this.CompanyNameTextBox.Multiline = false;
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyNameTextBox.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CompanyNameTextBox.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyNameTextBox.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CompanyNameTextBox.OnIdleState = stateProperties20;
            this.CompanyNameTextBox.PasswordChar = '\0';
            this.CompanyNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CompanyNameTextBox.PlaceholderText = ApplicationStrings.CompanyNamePlaceholder;
            this.CompanyNameTextBox.ReadOnly = false;
            this.CompanyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompanyNameTextBox.SelectedText = "";
            this.CompanyNameTextBox.SelectionLength = 0;
            this.CompanyNameTextBox.SelectionStart = 0;
            this.CompanyNameTextBox.ShortcutsEnabled = true;
            this.CompanyNameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CompanyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CompanyNameTextBox.TextMarginBottom = 0;
            this.CompanyNameTextBox.TextMarginLeft = 3;
            this.CompanyNameTextBox.TextMarginTop = 0;
            this.CompanyNameTextBox.TextPlaceholder = ApplicationStrings.CompanyNamePlaceholder;
            this.CompanyNameTextBox.UseSystemPasswordChar = false;
            this.CompanyNameTextBox.WordWrap = true;
            // 
            // DragControlToolPanel
            // 
            this.DragControlToolPanel.Fixed = true;
            this.DragControlToolPanel.Horizontal = true;
            this.DragControlToolPanel.TargetControl = this.ToolPanel;
            this.DragControlToolPanel.Vertical = true;
            // 
            // DragControlMainPanel
            // 
            this.DragControlMainPanel.Fixed = true;
            this.DragControlMainPanel.Horizontal = true;
            this.DragControlMainPanel.TargetControl = this.MainPanel;
            this.DragControlMainPanel.Vertical = true;
            // 
            // DragControlTitle
            // 
            this.DragControlTitle.Fixed = true;
            this.DragControlTitle.Horizontal = true;
            this.DragControlTitle.TargetControl = this.TitleLabel;
            this.DragControlTitle.Vertical = true;
            // 
            // CompanyCreatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyCreatorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompanyCreatorForm_FormClosing);
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.CompanyPage.ResumeLayout(false);
            this.GeneralSettingsPage.ResumeLayout(false);
            this.GeneralSettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyImage)).EndInit();
            this.DescriptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuElipse Elipse;
        private BunifuGradientPanel ToolPanel;
        private BunifuLabel TitleLabel;
        private BunifuGradientPanel MainPanel;
        private BunifuPages CompanyPage;
        private TabPage GeneralSettingsPage;
        private BunifuLabel CompanyChiefLabel;
        private BunifuTextBox CompanyChiefTextBox;
        private BunifuLabel CompanyAdressLabel;
        private BunifuTextBox CompanyAddressTextBox;
        private BunifuLabel CompanyNameLabel;
        private BunifuTextBox CompanyNameTextBox;
        private BunifuLabel DescriptionLabel;
        private Panel DescriptionPanel;
        private BunifuTextBox CompanyDescriptionTextBox;
        private BunifuLabel CompanyPhoneNumberLabel;
        private BunifuTextBox CompanyPhoneNumberTextBox;
        private BunifuButton ChangeImgButton;
        private BunifuPictureBox CompanyImage;
        private BunifuLabel ImageLabel;
        private new BunifuButton CancelButton;
        private BunifuButton OKButton;
        private BunifuDragControl DragControlToolPanel;
        private BunifuDragControl DragControlMainPanel;
        private BunifuDragControl DragControlTitle;
    }
}