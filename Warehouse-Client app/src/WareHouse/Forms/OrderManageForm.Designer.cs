
namespace WareHouse.Forms
{
    partial class OrderManageForm
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
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManageForm));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.ToolsPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.CreateCSVButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.OnlyActiveOrdersToggle = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.ActiveLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.OrdersButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ClientsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LogoLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RollButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.ClientsPage = new System.Windows.Forms.TabPage();
            this.ClientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ToolsPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Pages.SuspendLayout();
            this.ClientsPage.SuspendLayout();
            this.OrdersPage.SuspendLayout();
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
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolsPanel.BackgroundImage")));
            this.ToolsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsPanel.BorderRadius = 1;
            this.ToolsPanel.Controls.Add(this.CreateCSVButton);
            this.ToolsPanel.Controls.Add(this.OnlyActiveOrdersToggle);
            this.ToolsPanel.Controls.Add(this.ActiveLabel);
            this.ToolsPanel.Controls.Add(this.OrdersButton);
            this.ToolsPanel.Controls.Add(this.ClientsButton);
            this.ToolsPanel.Controls.Add(this.LogoLabel);
            this.ToolsPanel.Controls.Add(this.RollButton);
            this.ToolsPanel.Controls.Add(this.ExitButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ToolsPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.ToolsPanel.GradientTopLeft = System.Drawing.Color.White;
            this.ToolsPanel.GradientTopRight = System.Drawing.Color.White;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Quality = 10;
            this.ToolsPanel.Size = new System.Drawing.Size(225, 600);
            this.ToolsPanel.TabIndex = 0;
            // 
            // CreateCSVButton
            // 
            this.CreateCSVButton.AllowAnimations = true;
            this.CreateCSVButton.AllowMouseEffects = true;
            this.CreateCSVButton.AllowToggling = false;
            this.CreateCSVButton.AnimationSpeed = 200;
            this.CreateCSVButton.AutoGenerateColors = false;
            this.CreateCSVButton.AutoRoundBorders = false;
            this.CreateCSVButton.AutoSizeLeftIcon = true;
            this.CreateCSVButton.AutoSizeRightIcon = true;
            this.CreateCSVButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateCSVButton.BackColor1 = System.Drawing.Color.Transparent;
            this.CreateCSVButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateCSVButton.BackgroundImage")));
            this.CreateCSVButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateCSVButton.ButtonText = "";
            this.CreateCSVButton.ButtonTextMarginLeft = 0;
            this.CreateCSVButton.ColorContrastOnClick = 45;
            this.CreateCSVButton.ColorContrastOnHover = 45;
            this.CreateCSVButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.CreateCSVButton.CustomizableEdges = borderEdges1;
            this.CreateCSVButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateCSVButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CreateCSVButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CreateCSVButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CreateCSVButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CreateCSVButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.CreateCSVButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.CreateCSVButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateCSVButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CreateCSVButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.CreateCSVButton.IconMarginLeft = 11;
            this.CreateCSVButton.IconPadding = 10;
            this.CreateCSVButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateCSVButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CreateCSVButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.CreateCSVButton.IconSize = 25;
            this.CreateCSVButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.CreateCSVButton.IdleBorderRadius = 10;
            this.CreateCSVButton.IdleBorderThickness = 1;
            this.CreateCSVButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.CreateCSVButton.IdleIconLeftImage = global::WareHouse.Properties.Resources.csv_outline;
            this.CreateCSVButton.IdleIconRightImage = null;
            this.CreateCSVButton.IndicateFocus = false;
            this.CreateCSVButton.Location = new System.Drawing.Point(3, 525);
            this.CreateCSVButton.Name = "CreateCSVButton";
            this.CreateCSVButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CreateCSVButton.OnDisabledState.BorderRadius = 10;
            this.CreateCSVButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateCSVButton.OnDisabledState.BorderThickness = 1;
            this.CreateCSVButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CreateCSVButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CreateCSVButton.OnDisabledState.IconLeftImage = null;
            this.CreateCSVButton.OnDisabledState.IconRightImage = null;
            this.CreateCSVButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CreateCSVButton.onHoverState.BorderRadius = 10;
            this.CreateCSVButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateCSVButton.onHoverState.BorderThickness = 1;
            this.CreateCSVButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CreateCSVButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.CreateCSVButton.onHoverState.IconLeftImage = null;
            this.CreateCSVButton.onHoverState.IconRightImage = null;
            this.CreateCSVButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.CreateCSVButton.OnIdleState.BorderRadius = 10;
            this.CreateCSVButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateCSVButton.OnIdleState.BorderThickness = 1;
            this.CreateCSVButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.CreateCSVButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.CreateCSVButton.OnIdleState.IconLeftImage = global::WareHouse.Properties.Resources.csv_outline;
            this.CreateCSVButton.OnIdleState.IconRightImage = null;
            this.CreateCSVButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CreateCSVButton.OnPressedState.BorderRadius = 10;
            this.CreateCSVButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateCSVButton.OnPressedState.BorderThickness = 1;
            this.CreateCSVButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.CreateCSVButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.CreateCSVButton.OnPressedState.IconLeftImage = null;
            this.CreateCSVButton.OnPressedState.IconRightImage = null;
            this.CreateCSVButton.Size = new System.Drawing.Size(78, 72);
            this.CreateCSVButton.TabIndex = 42;
            this.CreateCSVButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateCSVButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreateCSVButton.TextMarginLeft = 0;
            this.CreateCSVButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.CreateCSVButton.UseDefaultRadiusAndThickness = true;
            this.CreateCSVButton.Click += new System.EventHandler(this.CreateCSVButton_Click);
            // 
            // OnlyActiveOrdersToggle
            // 
            this.OnlyActiveOrdersToggle.Animation = 5;
            this.OnlyActiveOrdersToggle.BackColor = System.Drawing.Color.Transparent;
            this.OnlyActiveOrdersToggle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OnlyActiveOrdersToggle.BackgroundImage")));
            this.OnlyActiveOrdersToggle.Checked = false;
            this.OnlyActiveOrdersToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnlyActiveOrdersToggle.InnerCirclePadding = 3;
            this.OnlyActiveOrdersToggle.Location = new System.Drawing.Point(184, 244);
            this.OnlyActiveOrdersToggle.Name = "OnlyActiveOrdersToggle";
            this.OnlyActiveOrdersToggle.Size = new System.Drawing.Size(32, 18);
            this.OnlyActiveOrdersToggle.TabIndex = 40;
            this.OnlyActiveOrdersToggle.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.OnlyActiveOrdersToggle.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BackColorInner = System.Drawing.Color.White;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            toggleState2.BorderColorInner = System.Drawing.Color.White;
            toggleState2.BorderRadius = 17;
            toggleState2.BorderRadiusInner = 11;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.OnlyActiveOrdersToggle.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.OnlyActiveOrdersToggle.ToggleStateOn = toggleState3;
            this.OnlyActiveOrdersToggle.Value = false;
            this.OnlyActiveOrdersToggle.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs>(this.OnlyActiveOrdersToggle_CheckedChanged);
            // 
            // ActiveLabel
            // 
            this.ActiveLabel.AllowParentOverrides = false;
            this.ActiveLabel.AutoEllipsis = true;
            this.ActiveLabel.AutoSize = false;
            this.ActiveLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActiveLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.ActiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.ActiveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ActiveLabel.Location = new System.Drawing.Point(5, 242);
            this.ActiveLabel.Name = "ActiveLabel";
            this.ActiveLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActiveLabel.Size = new System.Drawing.Size(195, 32);
            this.ActiveLabel.TabIndex = 41;
            this.ActiveLabel.Text = "Show Active Orders:";
            this.ActiveLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.ActiveLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OrdersButton
            // 
            this.OrdersButton.AllowAnimations = true;
            this.OrdersButton.AllowMouseEffects = true;
            this.OrdersButton.AllowToggling = false;
            this.OrdersButton.AnimationSpeed = 200;
            this.OrdersButton.AutoGenerateColors = false;
            this.OrdersButton.AutoRoundBorders = false;
            this.OrdersButton.AutoSizeLeftIcon = true;
            this.OrdersButton.AutoSizeRightIcon = true;
            this.OrdersButton.BackColor = System.Drawing.Color.Transparent;
            this.OrdersButton.BackColor1 = System.Drawing.Color.Transparent;
            this.OrdersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrdersButton.BackgroundImage")));
            this.OrdersButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OrdersButton.ButtonText = "Orders";
            this.OrdersButton.ButtonTextMarginLeft = 0;
            this.OrdersButton.ColorContrastOnClick = 45;
            this.OrdersButton.ColorContrastOnHover = 45;
            this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.OrdersButton.CustomizableEdges = borderEdges2;
            this.OrdersButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OrdersButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.OrdersButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OrdersButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.OrdersButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.OrdersButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.OrdersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.OrdersButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.OrdersButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.OrdersButton.IconMarginLeft = 11;
            this.OrdersButton.IconPadding = 10;
            this.OrdersButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OrdersButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.OrdersButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.OrdersButton.IconSize = 25;
            this.OrdersButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.OrdersButton.IdleBorderRadius = 10;
            this.OrdersButton.IdleBorderThickness = 1;
            this.OrdersButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.OrdersButton.IdleIconLeftImage = global::WareHouse.Properties.Resources.basket_cart;
            this.OrdersButton.IdleIconRightImage = null;
            this.OrdersButton.IndicateFocus = false;
            this.OrdersButton.Location = new System.Drawing.Point(0, 196);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.OrdersButton.OnDisabledState.BorderRadius = 10;
            this.OrdersButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OrdersButton.OnDisabledState.BorderThickness = 1;
            this.OrdersButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OrdersButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.OrdersButton.OnDisabledState.IconLeftImage = null;
            this.OrdersButton.OnDisabledState.IconRightImage = null;
            this.OrdersButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.OrdersButton.onHoverState.BorderRadius = 10;
            this.OrdersButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OrdersButton.onHoverState.BorderThickness = 1;
            this.OrdersButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.OrdersButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.onHoverState.IconLeftImage = null;
            this.OrdersButton.onHoverState.IconRightImage = null;
            this.OrdersButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.OrdersButton.OnIdleState.BorderRadius = 10;
            this.OrdersButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OrdersButton.OnIdleState.BorderThickness = 1;
            this.OrdersButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.OrdersButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.OrdersButton.OnIdleState.IconLeftImage = global::WareHouse.Properties.Resources.basket_cart;
            this.OrdersButton.OnIdleState.IconRightImage = null;
            this.OrdersButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.OrdersButton.OnPressedState.BorderRadius = 10;
            this.OrdersButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.OrdersButton.OnPressedState.BorderThickness = 1;
            this.OrdersButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.OrdersButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.OnPressedState.IconLeftImage = null;
            this.OrdersButton.OnPressedState.IconRightImage = null;
            this.OrdersButton.Size = new System.Drawing.Size(225, 40);
            this.OrdersButton.TabIndex = 39;
            this.OrdersButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrdersButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrdersButton.TextMarginLeft = 0;
            this.OrdersButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.OrdersButton.UseDefaultRadiusAndThickness = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.AllowAnimations = true;
            this.ClientsButton.AllowMouseEffects = true;
            this.ClientsButton.AllowToggling = false;
            this.ClientsButton.AnimationSpeed = 200;
            this.ClientsButton.AutoGenerateColors = false;
            this.ClientsButton.AutoRoundBorders = false;
            this.ClientsButton.AutoSizeLeftIcon = true;
            this.ClientsButton.AutoSizeRightIcon = true;
            this.ClientsButton.BackColor = System.Drawing.Color.Transparent;
            this.ClientsButton.BackColor1 = System.Drawing.Color.Transparent;
            this.ClientsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClientsButton.BackgroundImage")));
            this.ClientsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ClientsButton.ButtonText = "Clients";
            this.ClientsButton.ButtonTextMarginLeft = 0;
            this.ClientsButton.ColorContrastOnClick = 45;
            this.ClientsButton.ColorContrastOnHover = 45;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ClientsButton.CustomizableEdges = borderEdges3;
            this.ClientsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ClientsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ClientsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ClientsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ClientsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ClientsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ClientsButton.IconMarginLeft = 11;
            this.ClientsButton.IconPadding = 10;
            this.ClientsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ClientsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ClientsButton.IconSize = 25;
            this.ClientsButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientsButton.IdleBorderRadius = 10;
            this.ClientsButton.IdleBorderThickness = 1;
            this.ClientsButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.ClientsButton.IdleIconLeftImage = global::WareHouse.Properties.Resources.user;
            this.ClientsButton.IdleIconRightImage = null;
            this.ClientsButton.IndicateFocus = false;
            this.ClientsButton.Location = new System.Drawing.Point(0, 157);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientsButton.OnDisabledState.BorderRadius = 10;
            this.ClientsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ClientsButton.OnDisabledState.BorderThickness = 1;
            this.ClientsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ClientsButton.OnDisabledState.IconLeftImage = null;
            this.ClientsButton.OnDisabledState.IconRightImage = null;
            this.ClientsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientsButton.onHoverState.BorderRadius = 10;
            this.ClientsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ClientsButton.onHoverState.BorderThickness = 1;
            this.ClientsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ClientsButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.onHoverState.IconLeftImage = null;
            this.ClientsButton.onHoverState.IconRightImage = null;
            this.ClientsButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ClientsButton.OnIdleState.BorderRadius = 10;
            this.ClientsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ClientsButton.OnIdleState.BorderThickness = 1;
            this.ClientsButton.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.ClientsButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientsButton.OnIdleState.IconLeftImage = global::WareHouse.Properties.Resources.user;
            this.ClientsButton.OnIdleState.IconRightImage = null;
            this.ClientsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ClientsButton.OnPressedState.BorderRadius = 10;
            this.ClientsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ClientsButton.OnPressedState.BorderThickness = 1;
            this.ClientsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ClientsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.OnPressedState.IconLeftImage = null;
            this.ClientsButton.OnPressedState.IconRightImage = null;
            this.ClientsButton.Size = new System.Drawing.Size(225, 40);
            this.ClientsButton.TabIndex = 38;
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClientsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClientsButton.TextMarginLeft = 0;
            this.ClientsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ClientsButton.UseDefaultRadiusAndThickness = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
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
            this.LogoLabel.Location = new System.Drawing.Point(52, 3);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoLabel.Size = new System.Drawing.Size(164, 31);
            this.LogoLabel.TabIndex = 37;
            this.LogoLabel.Text = "Orders";
            this.LogoLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.LogoLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // RollButton
            // 
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.Image = global::WareHouse.Properties.Resources.roll_button;
            this.RollButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RollButton.Location = new System.Drawing.Point(28, 3);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(18, 18);
            this.RollButton.TabIndex = 36;
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Image = global::WareHouse.Properties.Resources.exit_button;
            this.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitButton.Location = new System.Drawing.Point(4, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 18);
            this.ExitButton.TabIndex = 35;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderRadius = 1;
            this.MainPanel.Controls.Add(this.Pages);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.White;
            this.MainPanel.GradientTopRight = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(225, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(925, 600);
            this.MainPanel.TabIndex = 1;
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = true;
            this.Pages.Controls.Add(this.ClientsPage);
            this.Pages.Controls.Add(this.OrdersPage);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.OrdersPage;
            this.Pages.PageIndex = 1;
            this.Pages.PageName = "OrdersPage";
            this.Pages.PageTitle = "OrdersPage";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(925, 600);
            this.Pages.TabIndex = 0;
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
            this.Pages.Transition = animation1;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // ClientsPage
            // 
            this.ClientsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.ClientsPage.Controls.Add(this.ClientsPanel);
            this.ClientsPage.Location = new System.Drawing.Point(4, 4);
            this.ClientsPage.Name = "ClientsPage";
            this.ClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsPage.Size = new System.Drawing.Size(917, 574);
            this.ClientsPage.TabIndex = 0;
            this.ClientsPage.Text = "ClientsPage";
            // 
            // ClientsPanel
            // 
            this.ClientsPanel.AutoScroll = true;
            this.ClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsPanel.Location = new System.Drawing.Point(3, 3);
            this.ClientsPanel.Name = "ClientsPanel";
            this.ClientsPanel.Size = new System.Drawing.Size(911, 568);
            this.ClientsPanel.TabIndex = 0;
            // 
            // OrdersPage
            // 
            this.OrdersPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.OrdersPage.Controls.Add(this.OrdersPanel);
            this.OrdersPage.Location = new System.Drawing.Point(4, 4);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(917, 574);
            this.OrdersPage.TabIndex = 1;
            this.OrdersPage.Text = "OrdersPage";
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.AutoScroll = true;
            this.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersPanel.Location = new System.Drawing.Point(3, 3);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(911, 568);
            this.OrdersPanel.TabIndex = 0;
            // 
            // OrderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ToolsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1150, 600);
            this.MinimumSize = new System.Drawing.Size(1150, 600);
            this.Name = "OrderManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderManageForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderManageForm_Load);
            this.ToolsPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.Pages.ResumeLayout(false);
            this.ClientsPage.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.UI.WinForms.BunifuFormDock FormDock;
        private Bunifu.UI.WinForms.BunifuGradientPanel ToolsPanel;
        private Bunifu.UI.WinForms.BunifuGradientPanel MainPanel;
        private Bunifu.UI.WinForms.BunifuLabel LogoLabel;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button ExitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ClientsButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton OrdersButton;
        private Bunifu.UI.WinForms.BunifuPages Pages;
        private System.Windows.Forms.TabPage ClientsPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private Bunifu.UI.WinForms.BunifuLabel ActiveLabel;
        private Bunifu.UI.WinForms.BunifuToggleSwitch OnlyActiveOrdersToggle;
        private System.Windows.Forms.FlowLayoutPanel ClientsPanel;
        private System.Windows.Forms.FlowLayoutPanel OrdersPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CreateCSVButton;
    }
}