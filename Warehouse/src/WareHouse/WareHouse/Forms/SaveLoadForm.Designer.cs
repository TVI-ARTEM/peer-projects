
namespace WareHouse.Forms
{
    partial class SaveLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveLoadForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MainPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.FormCancelButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainCards = new Bunifu.Framework.UI.BunifuCards();
            this.FolderListBox = new System.Windows.Forms.ListBox();
            this.LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SaveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FolderNameTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.NameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoadLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.SaveLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ToolPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolPanel.BackgroundImage")));
            this.ToolPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolPanel.BorderRadius = 1;
            this.ToolPanel.Controls.Add(this.TitleLabel);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Quality = 10;
            this.ToolPanel.Size = new System.Drawing.Size(800, 40);
            this.ToolPanel.TabIndex = 4;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.TitleLabel.Location = new System.Drawing.Point(13, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(196, 28);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Warehouse Manager";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderRadius = 1;
            this.MainPanel.Controls.Add(this.FormCancelButton);
            this.MainPanel.Controls.Add(this.MainCards);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.MainPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Quality = 10;
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 5;
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
            this.FormCancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FormCancelButton.BackgroundImage")));
            this.FormCancelButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.FormCancelButton.ButtonText = "Cancel";
            this.FormCancelButton.ButtonTextMarginLeft = 0;
            this.FormCancelButton.ColorContrastOnClick = 45;
            this.FormCancelButton.ColorContrastOnHover = 45;
            this.FormCancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.FormCancelButton.CustomizableEdges = borderEdges1;
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.FormCancelButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FormCancelButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.FormCancelButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.FormCancelButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
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
            this.FormCancelButton.Location = new System.Drawing.Point(700, 398);
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
            this.FormCancelButton.Size = new System.Drawing.Size(88, 40);
            this.FormCancelButton.TabIndex = 31;
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
            this.MainCards.Controls.Add(this.FolderListBox);
            this.MainCards.Controls.Add(this.LoadButton);
            this.MainCards.Controls.Add(this.SaveButton);
            this.MainCards.Controls.Add(this.FolderNameTextBox);
            this.MainCards.Controls.Add(this.NameLabel);
            this.MainCards.Controls.Add(this.LoadLabel);
            this.MainCards.Controls.Add(this.SaveLabel);
            this.MainCards.Controls.Add(this.panel1);
            this.MainCards.LeftSahddow = false;
            this.MainCards.Location = new System.Drawing.Point(13, 62);
            this.MainCards.Name = "MainCards";
            this.MainCards.RightSahddow = true;
            this.MainCards.ShadowDepth = 20;
            this.MainCards.Size = new System.Drawing.Size(775, 330);
            this.MainCards.TabIndex = 0;
            // 
            // FolderListBox
            // 
            this.FolderListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.FolderListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderListBox.ForeColor = System.Drawing.Color.White;
            this.FolderListBox.FormattingEnabled = true;
            this.FolderListBox.ItemHeight = 20;
            this.FolderListBox.Location = new System.Drawing.Point(406, 58);
            this.FolderListBox.Name = "FolderListBox";
            this.FolderListBox.Size = new System.Drawing.Size(339, 184);
            this.FolderListBox.TabIndex = 38;
            // 
            // LoadButton
            // 
            this.LoadButton.AllowAnimations = true;
            this.LoadButton.AllowMouseEffects = true;
            this.LoadButton.AllowToggling = false;
            this.LoadButton.AnimationSpeed = 200;
            this.LoadButton.AutoGenerateColors = false;
            this.LoadButton.AutoRoundBorders = false;
            this.LoadButton.AutoSizeLeftIcon = true;
            this.LoadButton.AutoSizeRightIcon = true;
            this.LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadButton.BackgroundImage")));
            this.LoadButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadButton.ButtonText = "Load";
            this.LoadButton.ButtonTextMarginLeft = 0;
            this.LoadButton.ColorContrastOnClick = 45;
            this.LoadButton.ColorContrastOnHover = 45;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LoadButton.CustomizableEdges = borderEdges2;
            this.LoadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoadButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoadButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoadButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoadButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoadButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoadButton.IconMarginLeft = 11;
            this.LoadButton.IconPadding = 10;
            this.LoadButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoadButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoadButton.IconSize = 25;
            this.LoadButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.LoadButton.IdleBorderRadius = 30;
            this.LoadButton.IdleBorderThickness = 2;
            this.LoadButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.LoadButton.IdleIconLeftImage = null;
            this.LoadButton.IdleIconRightImage = null;
            this.LoadButton.IndicateFocus = false;
            this.LoadButton.Location = new System.Drawing.Point(665, 274);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoadButton.OnDisabledState.BorderRadius = 30;
            this.LoadButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadButton.OnDisabledState.BorderThickness = 2;
            this.LoadButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoadButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoadButton.OnDisabledState.IconLeftImage = null;
            this.LoadButton.OnDisabledState.IconRightImage = null;
            this.LoadButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoadButton.onHoverState.BorderRadius = 30;
            this.LoadButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadButton.onHoverState.BorderThickness = 2;
            this.LoadButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoadButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoadButton.onHoverState.IconLeftImage = null;
            this.LoadButton.onHoverState.IconRightImage = null;
            this.LoadButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.LoadButton.OnIdleState.BorderRadius = 30;
            this.LoadButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadButton.OnIdleState.BorderThickness = 2;
            this.LoadButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.LoadButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoadButton.OnIdleState.IconLeftImage = null;
            this.LoadButton.OnIdleState.IconRightImage = null;
            this.LoadButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoadButton.OnPressedState.BorderRadius = 30;
            this.LoadButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadButton.OnPressedState.BorderThickness = 2;
            this.LoadButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoadButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoadButton.OnPressedState.IconLeftImage = null;
            this.LoadButton.OnPressedState.IconRightImage = null;
            this.LoadButton.Size = new System.Drawing.Size(93, 40);
            this.LoadButton.TabIndex = 37;
            this.LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadButton.TextMarginLeft = 0;
            this.LoadButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoadButton.UseDefaultRadiusAndThickness = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
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
            this.SaveButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.ButtonTextMarginLeft = 0;
            this.SaveButton.ColorContrastOnClick = 45;
            this.SaveButton.ColorContrastOnHover = 45;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.SaveButton.CustomizableEdges = borderEdges3;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveButton.IconMarginLeft = 11;
            this.SaveButton.IconPadding = 10;
            this.SaveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveButton.IconSize = 25;
            this.SaveButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.SaveButton.IdleBorderRadius = 30;
            this.SaveButton.IdleBorderThickness = 2;
            this.SaveButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.SaveButton.IdleIconLeftImage = null;
            this.SaveButton.IdleIconRightImage = null;
            this.SaveButton.IndicateFocus = false;
            this.SaveButton.Location = new System.Drawing.Point(287, 104);
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
            this.SaveButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.SaveButton.OnIdleState.BorderRadius = 30;
            this.SaveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveButton.OnIdleState.BorderThickness = 2;
            this.SaveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.SaveButton.OnIdleState.ForeColor = System.Drawing.Color.White;
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
            this.SaveButton.Size = new System.Drawing.Size(93, 40);
            this.SaveButton.TabIndex = 35;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.TextMarginLeft = 0;
            this.SaveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SaveButton.UseDefaultRadiusAndThickness = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.AcceptsReturn = false;
            this.FolderNameTextBox.AcceptsTab = false;
            this.FolderNameTextBox.AnimationSpeed = 200;
            this.FolderNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FolderNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FolderNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FolderNameTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FolderNameTextBox.BackgroundImage")));
            this.FolderNameTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.FolderNameTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FolderNameTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.FolderNameTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.FolderNameTextBox.BorderRadius = 1;
            this.FolderNameTextBox.BorderThickness = 1;
            this.FolderNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FolderNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FolderNameTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FolderNameTextBox.DefaultText = "";
            this.FolderNameTextBox.FillColor = System.Drawing.Color.White;
            this.FolderNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.FolderNameTextBox.HideSelection = true;
            this.FolderNameTextBox.IconLeft = null;
            this.FolderNameTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.FolderNameTextBox.IconPadding = 10;
            this.FolderNameTextBox.IconRight = null;
            this.FolderNameTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.FolderNameTextBox.Lines = new string[0];
            this.FolderNameTextBox.Location = new System.Drawing.Point(80, 58);
            this.FolderNameTextBox.MaxLength = 32767;
            this.FolderNameTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.FolderNameTextBox.Modified = false;
            this.FolderNameTextBox.Multiline = false;
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FolderNameTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FolderNameTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FolderNameTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FolderNameTextBox.OnIdleState = stateProperties4;
            this.FolderNameTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.FolderNameTextBox.PasswordChar = '\0';
            this.FolderNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.FolderNameTextBox.PlaceholderText = "Enter file name";
            this.FolderNameTextBox.ReadOnly = false;
            this.FolderNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FolderNameTextBox.SelectedText = "";
            this.FolderNameTextBox.SelectionLength = 0;
            this.FolderNameTextBox.SelectionStart = 0;
            this.FolderNameTextBox.ShortcutsEnabled = true;
            this.FolderNameTextBox.Size = new System.Drawing.Size(300, 40);
            this.FolderNameTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.FolderNameTextBox.TabIndex = 34;
            this.FolderNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FolderNameTextBox.TextMarginBottom = 0;
            this.FolderNameTextBox.TextMarginLeft = 3;
            this.FolderNameTextBox.TextMarginTop = 0;
            this.FolderNameTextBox.TextPlaceholder = "Enter file name";
            this.FolderNameTextBox.UseSystemPasswordChar = false;
            this.FolderNameTextBox.WordWrap = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AllowParentOverrides = false;
            this.NameLabel.AutoEllipsis = false;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.NameLabel.Location = new System.Drawing.Point(18, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(56, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            this.NameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoadLabel
            // 
            this.LoadLabel.AllowParentOverrides = false;
            this.LoadLabel.AutoEllipsis = false;
            this.LoadLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.LoadLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.LoadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.LoadLabel.Location = new System.Drawing.Point(406, 14);
            this.LoadLabel.Name = "LoadLabel";
            this.LoadLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoadLabel.Size = new System.Drawing.Size(45, 28);
            this.LoadLabel.TabIndex = 2;
            this.LoadLabel.Text = "Load";
            this.LoadLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LoadLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SaveLabel
            // 
            this.SaveLabel.AllowParentOverrides = false;
            this.SaveLabel.AutoEllipsis = false;
            this.SaveLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.SaveLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.SaveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SaveLabel.Location = new System.Drawing.Point(18, 14);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveLabel.Size = new System.Drawing.Size(44, 28);
            this.SaveLabel.TabIndex = 1;
            this.SaveLabel.Text = "Save";
            this.SaveLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SaveLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.panel1.Location = new System.Drawing.Point(386, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 300);
            this.panel1.TabIndex = 1;
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
            // SaveLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolPanel);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveLoadForm";
            this.Text = "SaveLoadForm";
            this.Load += new System.EventHandler(this.SaveLoadForm_Load);
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
        private Bunifu.Framework.UI.BunifuDragControl DragControlTitle;
        private Bunifu.Framework.UI.BunifuDragControl DragControlMainPanel;
        private Bunifu.Framework.UI.BunifuDragControl DragControlToolPanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel SaveLabel;
        private Bunifu.UI.WinForms.BunifuLabel LoadLabel;
        private Bunifu.UI.WinForms.BunifuLabel NameLabel;
        private Bunifu.UI.WinForms.BunifuTextBox FolderNameTextBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoadButton;
        private System.Windows.Forms.ListBox FolderListBox;
    }
}