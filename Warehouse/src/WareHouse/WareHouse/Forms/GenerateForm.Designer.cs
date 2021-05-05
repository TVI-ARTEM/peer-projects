
namespace WareHouse.Forms
{
    partial class GenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.FormCancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainCards = new Bunifu.Framework.UI.BunifuCards();
            this.RecursionDepthHSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.RecursionDepthLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ProductQuantityHSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.ProductQunatityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SectionQuantiyHSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.SectionQuantityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RootQuantityHSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.RootQuantityLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.OKButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DragControlTitle = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlMainPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControlToolPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainPanel.SuspendLayout();
            this.MainCards.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.MainCards.Controls.Add(this.RecursionDepthHSlider);
            this.MainCards.Controls.Add(this.RecursionDepthLabel);
            this.MainCards.Controls.Add(this.ProductQuantityHSlider);
            this.MainCards.Controls.Add(this.ProductQunatityLabel);
            this.MainCards.Controls.Add(this.SectionQuantiyHSlider);
            this.MainCards.Controls.Add(this.SectionQuantityLabel);
            this.MainCards.Controls.Add(this.RootQuantityHSlider);
            this.MainCards.Controls.Add(this.RootQuantityLabel);
            this.MainCards.LeftSahddow = false;
            resources.ApplyResources(this.MainCards, "MainCards");
            this.MainCards.Name = "MainCards";
            this.MainCards.RightSahddow = true;
            this.MainCards.ShadowDepth = 20;
            // 
            // RecursionDepthHSlider
            // 
            this.RecursionDepthHSlider.AllowCursorChanges = true;
            this.RecursionDepthHSlider.AllowHomeEndKeysDetection = false;
            this.RecursionDepthHSlider.AllowIncrementalClickMoves = true;
            this.RecursionDepthHSlider.AllowMouseDownEffects = false;
            this.RecursionDepthHSlider.AllowMouseHoverEffects = false;
            this.RecursionDepthHSlider.AllowScrollingAnimations = true;
            this.RecursionDepthHSlider.AllowScrollKeysDetection = true;
            this.RecursionDepthHSlider.AllowScrollOptionsMenu = true;
            this.RecursionDepthHSlider.AllowShrinkingOnFocusLost = false;
            this.RecursionDepthHSlider.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.RecursionDepthHSlider, "RecursionDepthHSlider");
            this.RecursionDepthHSlider.BindingContainer = null;
            this.RecursionDepthHSlider.BorderRadius = 2;
            this.RecursionDepthHSlider.BorderThickness = 1;
            this.RecursionDepthHSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecursionDepthHSlider.DrawThickBorder = false;
            this.RecursionDepthHSlider.DurationBeforeShrink = 2000;
            this.RecursionDepthHSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.RecursionDepthHSlider.LargeChange = 10;
            this.RecursionDepthHSlider.Maximum = 3;
            this.RecursionDepthHSlider.Minimum = 0;
            this.RecursionDepthHSlider.MinimumThumbLength = 18;
            this.RecursionDepthHSlider.Name = "RecursionDepthHSlider";
            this.RecursionDepthHSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.RecursionDepthHSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.RecursionDepthHSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.RecursionDepthHSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RecursionDepthHSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RecursionDepthHSlider.ShrinkSizeLimit = 3;
            this.RecursionDepthHSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RecursionDepthHSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.RecursionDepthHSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.RecursionDepthHSlider.SmallChange = 1;
            this.RecursionDepthHSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.RecursionDepthHSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.RecursionDepthHSlider.ThumbLength = 182;
            this.RecursionDepthHSlider.ThumbMargin = 1;
            this.RecursionDepthHSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.RecursionDepthHSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.RecursionDepthHSlider.Value = 1;
            // 
            // RecursionDepthLabel
            // 
            this.RecursionDepthLabel.AllowParentOverrides = false;
            this.RecursionDepthLabel.AutoEllipsis = false;
            this.RecursionDepthLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RecursionDepthLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.RecursionDepthLabel, "RecursionDepthLabel");
            this.RecursionDepthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RecursionDepthLabel.Name = "RecursionDepthLabel";
            this.RecursionDepthLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RecursionDepthLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ProductQuantityHSlider
            // 
            this.ProductQuantityHSlider.AllowCursorChanges = true;
            this.ProductQuantityHSlider.AllowHomeEndKeysDetection = false;
            this.ProductQuantityHSlider.AllowIncrementalClickMoves = true;
            this.ProductQuantityHSlider.AllowMouseDownEffects = false;
            this.ProductQuantityHSlider.AllowMouseHoverEffects = false;
            this.ProductQuantityHSlider.AllowScrollingAnimations = true;
            this.ProductQuantityHSlider.AllowScrollKeysDetection = true;
            this.ProductQuantityHSlider.AllowScrollOptionsMenu = true;
            this.ProductQuantityHSlider.AllowShrinkingOnFocusLost = false;
            this.ProductQuantityHSlider.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ProductQuantityHSlider, "ProductQuantityHSlider");
            this.ProductQuantityHSlider.BindingContainer = null;
            this.ProductQuantityHSlider.BorderRadius = 2;
            this.ProductQuantityHSlider.BorderThickness = 1;
            this.ProductQuantityHSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductQuantityHSlider.DrawThickBorder = false;
            this.ProductQuantityHSlider.DurationBeforeShrink = 2000;
            this.ProductQuantityHSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.ProductQuantityHSlider.LargeChange = 10;
            this.ProductQuantityHSlider.Maximum = 10;
            this.ProductQuantityHSlider.Minimum = 0;
            this.ProductQuantityHSlider.MinimumThumbLength = 18;
            this.ProductQuantityHSlider.Name = "ProductQuantityHSlider";
            this.ProductQuantityHSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ProductQuantityHSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ProductQuantityHSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ProductQuantityHSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ProductQuantityHSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ProductQuantityHSlider.ShrinkSizeLimit = 3;
            this.ProductQuantityHSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ProductQuantityHSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.ProductQuantityHSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.ProductQuantityHSlider.SmallChange = 1;
            this.ProductQuantityHSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.ProductQuantityHSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.ProductQuantityHSlider.ThumbLength = 182;
            this.ProductQuantityHSlider.ThumbMargin = 1;
            this.ProductQuantityHSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.ProductQuantityHSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.ProductQuantityHSlider.Value = 5;
            // 
            // ProductQunatityLabel
            // 
            this.ProductQunatityLabel.AllowParentOverrides = false;
            this.ProductQunatityLabel.AutoEllipsis = false;
            this.ProductQunatityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductQunatityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ProductQunatityLabel, "ProductQunatityLabel");
            this.ProductQunatityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ProductQunatityLabel.Name = "ProductQunatityLabel";
            this.ProductQunatityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ProductQunatityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SectionQuantiyHSlider
            // 
            this.SectionQuantiyHSlider.AllowCursorChanges = true;
            this.SectionQuantiyHSlider.AllowHomeEndKeysDetection = false;
            this.SectionQuantiyHSlider.AllowIncrementalClickMoves = true;
            this.SectionQuantiyHSlider.AllowMouseDownEffects = false;
            this.SectionQuantiyHSlider.AllowMouseHoverEffects = false;
            this.SectionQuantiyHSlider.AllowScrollingAnimations = true;
            this.SectionQuantiyHSlider.AllowScrollKeysDetection = true;
            this.SectionQuantiyHSlider.AllowScrollOptionsMenu = true;
            this.SectionQuantiyHSlider.AllowShrinkingOnFocusLost = false;
            this.SectionQuantiyHSlider.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SectionQuantiyHSlider, "SectionQuantiyHSlider");
            this.SectionQuantiyHSlider.BindingContainer = null;
            this.SectionQuantiyHSlider.BorderRadius = 2;
            this.SectionQuantiyHSlider.BorderThickness = 1;
            this.SectionQuantiyHSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SectionQuantiyHSlider.DrawThickBorder = false;
            this.SectionQuantiyHSlider.DurationBeforeShrink = 2000;
            this.SectionQuantiyHSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.SectionQuantiyHSlider.LargeChange = 10;
            this.SectionQuantiyHSlider.Maximum = 3;
            this.SectionQuantiyHSlider.Minimum = 0;
            this.SectionQuantiyHSlider.MinimumThumbLength = 18;
            this.SectionQuantiyHSlider.Name = "SectionQuantiyHSlider";
            this.SectionQuantiyHSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.SectionQuantiyHSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.SectionQuantiyHSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.SectionQuantiyHSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SectionQuantiyHSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SectionQuantiyHSlider.ShrinkSizeLimit = 3;
            this.SectionQuantiyHSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SectionQuantiyHSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.SectionQuantiyHSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.SectionQuantiyHSlider.SmallChange = 1;
            this.SectionQuantiyHSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.SectionQuantiyHSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.SectionQuantiyHSlider.ThumbLength = 182;
            this.SectionQuantiyHSlider.ThumbMargin = 1;
            this.SectionQuantiyHSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.SectionQuantiyHSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.SectionQuantiyHSlider.Value = 1;
            // 
            // SectionQuantityLabel
            // 
            this.SectionQuantityLabel.AllowParentOverrides = false;
            this.SectionQuantityLabel.AutoEllipsis = false;
            this.SectionQuantityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionQuantityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.SectionQuantityLabel, "SectionQuantityLabel");
            this.SectionQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SectionQuantityLabel.Name = "SectionQuantityLabel";
            this.SectionQuantityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SectionQuantityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RootQuantityHSlider
            // 
            this.RootQuantityHSlider.AllowCursorChanges = true;
            this.RootQuantityHSlider.AllowHomeEndKeysDetection = false;
            this.RootQuantityHSlider.AllowIncrementalClickMoves = true;
            this.RootQuantityHSlider.AllowMouseDownEffects = false;
            this.RootQuantityHSlider.AllowMouseHoverEffects = false;
            this.RootQuantityHSlider.AllowScrollingAnimations = true;
            this.RootQuantityHSlider.AllowScrollKeysDetection = true;
            this.RootQuantityHSlider.AllowScrollOptionsMenu = true;
            this.RootQuantityHSlider.AllowShrinkingOnFocusLost = false;
            this.RootQuantityHSlider.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.RootQuantityHSlider, "RootQuantityHSlider");
            this.RootQuantityHSlider.BindingContainer = null;
            this.RootQuantityHSlider.BorderRadius = 2;
            this.RootQuantityHSlider.BorderThickness = 1;
            this.RootQuantityHSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RootQuantityHSlider.DrawThickBorder = false;
            this.RootQuantityHSlider.DurationBeforeShrink = 2000;
            this.RootQuantityHSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.RootQuantityHSlider.LargeChange = 10;
            this.RootQuantityHSlider.Maximum = 5;
            this.RootQuantityHSlider.Minimum = 1;
            this.RootQuantityHSlider.MinimumThumbLength = 18;
            this.RootQuantityHSlider.Name = "RootQuantityHSlider";
            this.RootQuantityHSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.RootQuantityHSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.RootQuantityHSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.RootQuantityHSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RootQuantityHSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RootQuantityHSlider.ShrinkSizeLimit = 3;
            this.RootQuantityHSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.RootQuantityHSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.RootQuantityHSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.RootQuantityHSlider.SmallChange = 1;
            this.RootQuantityHSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.RootQuantityHSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.RootQuantityHSlider.ThumbLength = 182;
            this.RootQuantityHSlider.ThumbMargin = 1;
            this.RootQuantityHSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.RootQuantityHSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.RootQuantityHSlider.Value = 2;
            // 
            // RootQuantityLabel
            // 
            this.RootQuantityLabel.AllowParentOverrides = false;
            this.RootQuantityLabel.AutoEllipsis = false;
            this.RootQuantityLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RootQuantityLabel.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.RootQuantityLabel, "RootQuantityLabel");
            this.RootQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RootQuantityLabel.Name = "RootQuantityLabel";
            this.RootQuantityLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RootQuantityLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            // GenerateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateForm_FormClosing);
            this.MainPanel.ResumeLayout(false);
            this.MainCards.ResumeLayout(false);
            this.MainCards.PerformLayout();
            this.ToolPanel.ResumeLayout(false);
            this.ToolPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel MainPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton FormCancelButton;
        private Bunifu.Framework.UI.BunifuCards MainCards;
        private Bunifu.UI.WinForms.BunifuLabel RootQuantityLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton OKButton;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuGradientPanel ToolPanel;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.Framework.UI.BunifuDragControl DragControlTitle;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMainPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControlToolPanel;
        private Bunifu.UI.WinForms.BunifuHSlider RootQuantityHSlider;
        private Bunifu.UI.WinForms.BunifuHSlider SectionQuantiyHSlider;
        private Bunifu.UI.WinForms.BunifuLabel SectionQuantityLabel;
        private Bunifu.UI.WinForms.BunifuHSlider ProductQuantityHSlider;
        private Bunifu.UI.WinForms.BunifuLabel ProductQunatityLabel;
        private Bunifu.UI.WinForms.BunifuHSlider RecursionDepthHSlider;
        private Bunifu.UI.WinForms.BunifuLabel RecursionDepthLabel;
    }
}