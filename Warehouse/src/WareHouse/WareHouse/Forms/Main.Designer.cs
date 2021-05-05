using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using BunifuGradientPanel = Bunifu.UI.WinForms.BunifuGradientPanel;

namespace WareHouse.Forms
{
    partial class Main
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ToolCards = new Bunifu.Framework.UI.BunifuCards();
            this.ToolTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SaveLoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ExportCsvButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddSectionButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddRootButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AddProductButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.GenerateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ProductTreeView = new System.Windows.Forms.TreeView();
            this.SectionContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.EngButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.QuantityButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.RusButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PriceButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.WorkCards = new Bunifu.Framework.UI.BunifuCards();
            this.SearchTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.GridVScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.GridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUcn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGuarantee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.ToolPanel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.HideButton = new System.Windows.Forms.Button();
            this.RollButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.ToolCards.SuspendLayout();
            this.ToolTableLayoutPanel.SuspendLayout();
            this.SectionContextMenuStrip.SuspendLayout();
            this.WorkCards.SuspendLayout();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.GridContextMenuStrip.SuspendLayout();
            this.ToolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // MainSplitContainer
            // 
            resources.ApplyResources(this.MainSplitContainer, "MainSplitContainer");
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ToolCards);
            this.ToolTip.SetToolTip(this.MainSplitContainer.Panel1, "");
            this.ToolTip.SetToolTipIcon(this.MainSplitContainer.Panel1, null);
            this.ToolTip.SetToolTipTitle(this.MainSplitContainer.Panel1, "");
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.WorkCards);
            this.ToolTip.SetToolTip(this.MainSplitContainer.Panel2, "");
            this.ToolTip.SetToolTipIcon(this.MainSplitContainer.Panel2, null);
            this.ToolTip.SetToolTipTitle(this.MainSplitContainer.Panel2, "");
            this.ToolTip.SetToolTip(this.MainSplitContainer, "");
            this.ToolTip.SetToolTipIcon(this.MainSplitContainer, null);
            this.ToolTip.SetToolTipTitle(this.MainSplitContainer, "");
            // 
            // ToolCards
            // 
            this.ToolCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(79)))));
            this.ToolCards.BorderRadius = 30;
            this.ToolCards.BottomSahddow = true;
            this.ToolCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(229)))));
            this.ToolCards.Controls.Add(this.ToolTableLayoutPanel);
            resources.ApplyResources(this.ToolCards, "ToolCards");
            this.ToolCards.LeftSahddow = true;
            this.ToolCards.Name = "ToolCards";
            this.ToolCards.RightSahddow = true;
            this.ToolCards.ShadowDepth = 20;
            this.ToolTip.SetToolTip(this.ToolCards, "");
            this.ToolTip.SetToolTipIcon(this.ToolCards, null);
            this.ToolTip.SetToolTipTitle(this.ToolCards, "");
            // 
            // ToolTableLayoutPanel
            // 
            resources.ApplyResources(this.ToolTableLayoutPanel, "ToolTableLayoutPanel");
            this.ToolTableLayoutPanel.Controls.Add(this.SaveLoadButton, 0, 0);
            this.ToolTableLayoutPanel.Controls.Add(this.ExportCsvButton, 0, 2);
            this.ToolTableLayoutPanel.Controls.Add(this.AddSectionButton, 0, 1);
            this.ToolTableLayoutPanel.Controls.Add(this.AddRootButton, 0, 0);
            this.ToolTableLayoutPanel.Controls.Add(this.AddProductButton, 1, 1);
            this.ToolTableLayoutPanel.Controls.Add(this.GenerateButton, 1, 2);
            this.ToolTableLayoutPanel.Controls.Add(this.ProductTreeView, 0, 3);
            this.ToolTableLayoutPanel.Controls.Add(this.EngButton, 0, 5);
            this.ToolTableLayoutPanel.Controls.Add(this.QuantityButton, 0, 4);
            this.ToolTableLayoutPanel.Controls.Add(this.RusButton, 1, 5);
            this.ToolTableLayoutPanel.Controls.Add(this.PriceButton, 1, 4);
            this.ToolTableLayoutPanel.Name = "ToolTableLayoutPanel";
            this.ToolTip.SetToolTip(this.ToolTableLayoutPanel, "");
            this.ToolTip.SetToolTipIcon(this.ToolTableLayoutPanel, null);
            this.ToolTip.SetToolTipTitle(this.ToolTableLayoutPanel, "");
            // 
            // SaveLoadButton
            // 
            this.SaveLoadButton.AllowAnimations = true;
            this.SaveLoadButton.AllowMouseEffects = true;
            this.SaveLoadButton.AllowToggling = false;
            this.SaveLoadButton.AnimationSpeed = 200;
            this.SaveLoadButton.AutoGenerateColors = false;
            this.SaveLoadButton.AutoRoundBorders = false;
            this.SaveLoadButton.AutoSizeLeftIcon = true;
            this.SaveLoadButton.AutoSizeRightIcon = true;
            this.SaveLoadButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveLoadButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.SaveLoadButton, "SaveLoadButton");
            this.SaveLoadButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveLoadButton.ButtonText = "Save/Load";
            this.SaveLoadButton.ButtonTextMarginLeft = 0;
            this.SaveLoadButton.ColorContrastOnClick = 45;
            this.SaveLoadButton.ColorContrastOnHover = 45;
            this.SaveLoadButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SaveLoadButton.CustomizableEdges = borderEdges1;
            this.SaveLoadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveLoadButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveLoadButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveLoadButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveLoadButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveLoadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SaveLoadButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveLoadButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SaveLoadButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SaveLoadButton.IconMarginLeft = 11;
            this.SaveLoadButton.IconPadding = 10;
            this.SaveLoadButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveLoadButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SaveLoadButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SaveLoadButton.IconSize = 25;
            this.SaveLoadButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.SaveLoadButton.IdleBorderRadius = 15;
            this.SaveLoadButton.IdleBorderThickness = 2;
            this.SaveLoadButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SaveLoadButton.IdleIconLeftImage = null;
            this.SaveLoadButton.IdleIconRightImage = null;
            this.SaveLoadButton.IndicateFocus = false;
            this.SaveLoadButton.Name = "SaveLoadButton";
            this.SaveLoadButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SaveLoadButton.OnDisabledState.BorderRadius = 15;
            this.SaveLoadButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveLoadButton.OnDisabledState.BorderThickness = 2;
            this.SaveLoadButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveLoadButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveLoadButton.OnDisabledState.IconLeftImage = null;
            this.SaveLoadButton.OnDisabledState.IconRightImage = null;
            this.SaveLoadButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveLoadButton.onHoverState.BorderRadius = 15;
            this.SaveLoadButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveLoadButton.onHoverState.BorderThickness = 2;
            this.SaveLoadButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SaveLoadButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SaveLoadButton.onHoverState.IconLeftImage = null;
            this.SaveLoadButton.onHoverState.IconRightImage = null;
            this.SaveLoadButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.SaveLoadButton.OnIdleState.BorderRadius = 15;
            this.SaveLoadButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveLoadButton.OnIdleState.BorderThickness = 2;
            this.SaveLoadButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.SaveLoadButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.SaveLoadButton.OnIdleState.IconLeftImage = null;
            this.SaveLoadButton.OnIdleState.IconRightImage = null;
            this.SaveLoadButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveLoadButton.OnPressedState.BorderRadius = 15;
            this.SaveLoadButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveLoadButton.OnPressedState.BorderThickness = 2;
            this.SaveLoadButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SaveLoadButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SaveLoadButton.OnPressedState.IconLeftImage = null;
            this.SaveLoadButton.OnPressedState.IconRightImage = null;
            this.SaveLoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveLoadButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveLoadButton.TextMarginLeft = 0;
            this.SaveLoadButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.SaveLoadButton, "Save or Load");
            this.ToolTip.SetToolTipIcon(this.SaveLoadButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.SaveLoadButton, "SaveLoad");
            this.SaveLoadButton.UseDefaultRadiusAndThickness = true;
            this.SaveLoadButton.Click += new System.EventHandler(this.SaveLoadButton_Click);
            // 
            // ExportCsvButton
            // 
            this.ExportCsvButton.AllowAnimations = true;
            this.ExportCsvButton.AllowMouseEffects = true;
            this.ExportCsvButton.AllowToggling = false;
            this.ExportCsvButton.AnimationSpeed = 200;
            this.ExportCsvButton.AutoGenerateColors = false;
            this.ExportCsvButton.AutoRoundBorders = false;
            this.ExportCsvButton.AutoSizeLeftIcon = true;
            this.ExportCsvButton.AutoSizeRightIcon = true;
            this.ExportCsvButton.BackColor = System.Drawing.Color.Transparent;
            this.ExportCsvButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.ExportCsvButton, "ExportCsvButton");
            this.ExportCsvButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExportCsvButton.ButtonText = "CSV";
            this.ExportCsvButton.ButtonTextMarginLeft = 0;
            this.ExportCsvButton.ColorContrastOnClick = 45;
            this.ExportCsvButton.ColorContrastOnHover = 45;
            this.ExportCsvButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = false;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.ExportCsvButton.CustomizableEdges = borderEdges2;
            this.ExportCsvButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExportCsvButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ExportCsvButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExportCsvButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ExportCsvButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ExportCsvButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ExportCsvButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportCsvButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ExportCsvButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ExportCsvButton.IconMarginLeft = 11;
            this.ExportCsvButton.IconPadding = 10;
            this.ExportCsvButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportCsvButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ExportCsvButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ExportCsvButton.IconSize = 25;
            this.ExportCsvButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ExportCsvButton.IdleBorderRadius = 30;
            this.ExportCsvButton.IdleBorderThickness = 2;
            this.ExportCsvButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ExportCsvButton.IdleIconLeftImage = null;
            this.ExportCsvButton.IdleIconRightImage = null;
            this.ExportCsvButton.IndicateFocus = false;
            this.ExportCsvButton.Name = "ExportCsvButton";
            this.ExportCsvButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ExportCsvButton.OnDisabledState.BorderRadius = 30;
            this.ExportCsvButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExportCsvButton.OnDisabledState.BorderThickness = 2;
            this.ExportCsvButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExportCsvButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ExportCsvButton.OnDisabledState.IconLeftImage = null;
            this.ExportCsvButton.OnDisabledState.IconRightImage = null;
            this.ExportCsvButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ExportCsvButton.onHoverState.BorderRadius = 30;
            this.ExportCsvButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExportCsvButton.onHoverState.BorderThickness = 2;
            this.ExportCsvButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ExportCsvButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ExportCsvButton.onHoverState.IconLeftImage = null;
            this.ExportCsvButton.onHoverState.IconRightImage = null;
            this.ExportCsvButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ExportCsvButton.OnIdleState.BorderRadius = 30;
            this.ExportCsvButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExportCsvButton.OnIdleState.BorderThickness = 2;
            this.ExportCsvButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ExportCsvButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ExportCsvButton.OnIdleState.IconLeftImage = null;
            this.ExportCsvButton.OnIdleState.IconRightImage = null;
            this.ExportCsvButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ExportCsvButton.OnPressedState.BorderRadius = 30;
            this.ExportCsvButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ExportCsvButton.OnPressedState.BorderThickness = 2;
            this.ExportCsvButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ExportCsvButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ExportCsvButton.OnPressedState.IconLeftImage = null;
            this.ExportCsvButton.OnPressedState.IconRightImage = null;
            this.ExportCsvButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExportCsvButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExportCsvButton.TextMarginLeft = 0;
            this.ExportCsvButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.ExportCsvButton, "Create CSV Report");
            this.ToolTip.SetToolTipIcon(this.ExportCsvButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.ExportCsvButton, "CSV Report");
            this.ExportCsvButton.UseDefaultRadiusAndThickness = true;
            this.ExportCsvButton.Click += new System.EventHandler(this.ExportCsvButton_Click);
            // 
            // AddSectionButton
            // 
            this.AddSectionButton.AllowAnimations = true;
            this.AddSectionButton.AllowMouseEffects = true;
            this.AddSectionButton.AllowToggling = false;
            this.AddSectionButton.AnimationSpeed = 200;
            this.AddSectionButton.AutoGenerateColors = false;
            this.AddSectionButton.AutoRoundBorders = false;
            this.AddSectionButton.AutoSizeLeftIcon = true;
            this.AddSectionButton.AutoSizeRightIcon = true;
            this.AddSectionButton.BackColor = System.Drawing.Color.Transparent;
            this.AddSectionButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.AddSectionButton, "AddSectionButton");
            this.AddSectionButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSectionButton.ButtonText = "Section";
            this.AddSectionButton.ButtonTextMarginLeft = 0;
            this.AddSectionButton.ColorContrastOnClick = 45;
            this.AddSectionButton.ColorContrastOnHover = 45;
            this.AddSectionButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.AddSectionButton.CustomizableEdges = borderEdges3;
            this.AddSectionButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddSectionButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddSectionButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddSectionButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddSectionButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddSectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddSectionButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSectionButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddSectionButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddSectionButton.IconMarginLeft = 11;
            this.AddSectionButton.IconPadding = 10;
            this.AddSectionButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddSectionButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddSectionButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddSectionButton.IconSize = 25;
            this.AddSectionButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddSectionButton.IdleBorderRadius = 30;
            this.AddSectionButton.IdleBorderThickness = 2;
            this.AddSectionButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddSectionButton.IdleIconLeftImage = null;
            this.AddSectionButton.IdleIconRightImage = null;
            this.AddSectionButton.IndicateFocus = false;
            this.AddSectionButton.Name = "AddSectionButton";
            this.AddSectionButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddSectionButton.OnDisabledState.BorderRadius = 30;
            this.AddSectionButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSectionButton.OnDisabledState.BorderThickness = 2;
            this.AddSectionButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddSectionButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddSectionButton.OnDisabledState.IconLeftImage = null;
            this.AddSectionButton.OnDisabledState.IconRightImage = null;
            this.AddSectionButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddSectionButton.onHoverState.BorderRadius = 30;
            this.AddSectionButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSectionButton.onHoverState.BorderThickness = 2;
            this.AddSectionButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddSectionButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddSectionButton.onHoverState.IconLeftImage = null;
            this.AddSectionButton.onHoverState.IconRightImage = null;
            this.AddSectionButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddSectionButton.OnIdleState.BorderRadius = 30;
            this.AddSectionButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSectionButton.OnIdleState.BorderThickness = 2;
            this.AddSectionButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddSectionButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddSectionButton.OnIdleState.IconLeftImage = null;
            this.AddSectionButton.OnIdleState.IconRightImage = null;
            this.AddSectionButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddSectionButton.OnPressedState.BorderRadius = 30;
            this.AddSectionButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddSectionButton.OnPressedState.BorderThickness = 2;
            this.AddSectionButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddSectionButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddSectionButton.OnPressedState.IconLeftImage = null;
            this.AddSectionButton.OnPressedState.IconRightImage = null;
            this.AddSectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddSectionButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddSectionButton.TextMarginLeft = 0;
            this.AddSectionButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.AddSectionButton, "Add New Section");
            this.ToolTip.SetToolTipIcon(this.AddSectionButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.AddSectionButton, "Section");
            this.AddSectionButton.UseDefaultRadiusAndThickness = true;
            this.AddSectionButton.Click += new System.EventHandler(this.AddSectionButton_Click);
            // 
            // AddRootButton
            // 
            this.AddRootButton.AllowAnimations = true;
            this.AddRootButton.AllowMouseEffects = true;
            this.AddRootButton.AllowToggling = false;
            this.AddRootButton.AnimationSpeed = 200;
            this.AddRootButton.AutoGenerateColors = false;
            this.AddRootButton.AutoRoundBorders = false;
            this.AddRootButton.AutoSizeLeftIcon = true;
            this.AddRootButton.AutoSizeRightIcon = true;
            this.AddRootButton.BackColor = System.Drawing.Color.Transparent;
            this.AddRootButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.AddRootButton, "AddRootButton");
            this.AddRootButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddRootButton.ButtonText = "Add Root";
            this.AddRootButton.ButtonTextMarginLeft = 0;
            this.AddRootButton.ColorContrastOnClick = 45;
            this.AddRootButton.ColorContrastOnHover = 45;
            this.AddRootButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.AddRootButton.CustomizableEdges = borderEdges4;
            this.AddRootButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddRootButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddRootButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddRootButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddRootButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddRootButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddRootButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRootButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddRootButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddRootButton.IconMarginLeft = 11;
            this.AddRootButton.IconPadding = 10;
            this.AddRootButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRootButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddRootButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddRootButton.IconSize = 25;
            this.AddRootButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddRootButton.IdleBorderRadius = 15;
            this.AddRootButton.IdleBorderThickness = 2;
            this.AddRootButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddRootButton.IdleIconLeftImage = null;
            this.AddRootButton.IdleIconRightImage = null;
            this.AddRootButton.IndicateFocus = false;
            this.AddRootButton.Name = "AddRootButton";
            this.AddRootButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddRootButton.OnDisabledState.BorderRadius = 15;
            this.AddRootButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddRootButton.OnDisabledState.BorderThickness = 2;
            this.AddRootButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddRootButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddRootButton.OnDisabledState.IconLeftImage = null;
            this.AddRootButton.OnDisabledState.IconRightImage = null;
            this.AddRootButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddRootButton.onHoverState.BorderRadius = 15;
            this.AddRootButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddRootButton.onHoverState.BorderThickness = 2;
            this.AddRootButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddRootButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddRootButton.onHoverState.IconLeftImage = null;
            this.AddRootButton.onHoverState.IconRightImage = null;
            this.AddRootButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddRootButton.OnIdleState.BorderRadius = 15;
            this.AddRootButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddRootButton.OnIdleState.BorderThickness = 2;
            this.AddRootButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddRootButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddRootButton.OnIdleState.IconLeftImage = null;
            this.AddRootButton.OnIdleState.IconRightImage = null;
            this.AddRootButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddRootButton.OnPressedState.BorderRadius = 15;
            this.AddRootButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddRootButton.OnPressedState.BorderThickness = 2;
            this.AddRootButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddRootButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddRootButton.OnPressedState.IconLeftImage = null;
            this.AddRootButton.OnPressedState.IconRightImage = null;
            this.AddRootButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddRootButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddRootButton.TextMarginLeft = 0;
            this.AddRootButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.AddRootButton, "Add New Root");
            this.ToolTip.SetToolTipIcon(this.AddRootButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.AddRootButton, "Root");
            this.AddRootButton.UseDefaultRadiusAndThickness = true;
            this.AddRootButton.Click += new System.EventHandler(this.AddRootButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.AllowAnimations = true;
            this.AddProductButton.AllowMouseEffects = true;
            this.AddProductButton.AllowToggling = false;
            this.AddProductButton.AnimationSpeed = 200;
            this.AddProductButton.AutoGenerateColors = false;
            this.AddProductButton.AutoRoundBorders = false;
            this.AddProductButton.AutoSizeLeftIcon = true;
            this.AddProductButton.AutoSizeRightIcon = true;
            this.AddProductButton.BackColor = System.Drawing.Color.Transparent;
            this.AddProductButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.AddProductButton, "AddProductButton");
            this.AddProductButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddProductButton.ButtonText = "Product";
            this.AddProductButton.ButtonTextMarginLeft = 0;
            this.AddProductButton.ColorContrastOnClick = 45;
            this.AddProductButton.ColorContrastOnHover = 45;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = false;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = false;
            borderEdges5.TopRight = true;
            this.AddProductButton.CustomizableEdges = borderEdges5;
            this.AddProductButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddProductButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddProductButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddProductButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddProductButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddProductButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddProductButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddProductButton.IconMarginLeft = 11;
            this.AddProductButton.IconPadding = 10;
            this.AddProductButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddProductButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddProductButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddProductButton.IconSize = 25;
            this.AddProductButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddProductButton.IdleBorderRadius = 30;
            this.AddProductButton.IdleBorderThickness = 2;
            this.AddProductButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddProductButton.IdleIconLeftImage = null;
            this.AddProductButton.IdleIconRightImage = null;
            this.AddProductButton.IndicateFocus = false;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddProductButton.OnDisabledState.BorderRadius = 30;
            this.AddProductButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddProductButton.OnDisabledState.BorderThickness = 2;
            this.AddProductButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddProductButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddProductButton.OnDisabledState.IconLeftImage = null;
            this.AddProductButton.OnDisabledState.IconRightImage = null;
            this.AddProductButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddProductButton.onHoverState.BorderRadius = 30;
            this.AddProductButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddProductButton.onHoverState.BorderThickness = 2;
            this.AddProductButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AddProductButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.onHoverState.IconLeftImage = null;
            this.AddProductButton.onHoverState.IconRightImage = null;
            this.AddProductButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.AddProductButton.OnIdleState.BorderRadius = 30;
            this.AddProductButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddProductButton.OnIdleState.BorderThickness = 2;
            this.AddProductButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.AddProductButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.AddProductButton.OnIdleState.IconLeftImage = null;
            this.AddProductButton.OnIdleState.IconRightImage = null;
            this.AddProductButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddProductButton.OnPressedState.BorderRadius = 30;
            this.AddProductButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddProductButton.OnPressedState.BorderThickness = 2;
            this.AddProductButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.AddProductButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.OnPressedState.IconLeftImage = null;
            this.AddProductButton.OnPressedState.IconRightImage = null;
            this.AddProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddProductButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddProductButton.TextMarginLeft = 0;
            this.AddProductButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.AddProductButton, "Add New Product");
            this.ToolTip.SetToolTipIcon(this.AddProductButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.AddProductButton, "Product");
            this.AddProductButton.UseDefaultRadiusAndThickness = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.AllowAnimations = true;
            this.GenerateButton.AllowMouseEffects = true;
            this.GenerateButton.AllowToggling = false;
            this.GenerateButton.AnimationSpeed = 200;
            this.GenerateButton.AutoGenerateColors = false;
            this.GenerateButton.AutoRoundBorders = false;
            this.GenerateButton.AutoSizeLeftIcon = true;
            this.GenerateButton.AutoSizeRightIcon = true;
            this.GenerateButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.GenerateButton, "GenerateButton");
            this.GenerateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateButton.ButtonText = "Generate";
            this.GenerateButton.ButtonTextMarginLeft = 0;
            this.GenerateButton.ColorContrastOnClick = 45;
            this.GenerateButton.ColorContrastOnHover = 45;
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = false;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = false;
            borderEdges6.TopRight = true;
            this.GenerateButton.CustomizableEdges = borderEdges6;
            this.GenerateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GenerateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GenerateButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenerateButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.GenerateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.GenerateButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.GenerateButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.GenerateButton.IconMarginLeft = 11;
            this.GenerateButton.IconPadding = 10;
            this.GenerateButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerateButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.GenerateButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.GenerateButton.IconSize = 25;
            this.GenerateButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.GenerateButton.IdleBorderRadius = 30;
            this.GenerateButton.IdleBorderThickness = 2;
            this.GenerateButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.GenerateButton.IdleIconLeftImage = null;
            this.GenerateButton.IdleIconRightImage = null;
            this.GenerateButton.IndicateFocus = false;
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.GenerateButton.OnDisabledState.BorderRadius = 30;
            this.GenerateButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateButton.OnDisabledState.BorderThickness = 2;
            this.GenerateButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.GenerateButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.GenerateButton.OnDisabledState.IconLeftImage = null;
            this.GenerateButton.OnDisabledState.IconRightImage = null;
            this.GenerateButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.GenerateButton.onHoverState.BorderRadius = 30;
            this.GenerateButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateButton.onHoverState.BorderThickness = 2;
            this.GenerateButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.GenerateButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.onHoverState.IconLeftImage = null;
            this.GenerateButton.onHoverState.IconRightImage = null;
            this.GenerateButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.GenerateButton.OnIdleState.BorderRadius = 30;
            this.GenerateButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateButton.OnIdleState.BorderThickness = 2;
            this.GenerateButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.GenerateButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.GenerateButton.OnIdleState.IconLeftImage = null;
            this.GenerateButton.OnIdleState.IconRightImage = null;
            this.GenerateButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GenerateButton.OnPressedState.BorderRadius = 30;
            this.GenerateButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.GenerateButton.OnPressedState.BorderThickness = 2;
            this.GenerateButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.GenerateButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.OnPressedState.IconLeftImage = null;
            this.GenerateButton.OnPressedState.IconRightImage = null;
            this.GenerateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.GenerateButton.TextMarginLeft = 0;
            this.GenerateButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.GenerateButton, "Generate New Products");
            this.ToolTip.SetToolTipIcon(this.GenerateButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.GenerateButton, "Generate");
            this.GenerateButton.UseDefaultRadiusAndThickness = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ProductTreeView
            // 
            resources.ApplyResources(this.ProductTreeView, "ProductTreeView");
            this.ProductTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ToolTableLayoutPanel.SetColumnSpan(this.ProductTreeView, 2);
            this.ProductTreeView.ContextMenuStrip = this.SectionContextMenuStrip;
            this.ProductTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ProductTreeView.ImageList = this.ImageList;
            this.ProductTreeView.Name = "ProductTreeView";
            this.ToolTip.SetToolTip(this.ProductTreeView, "");
            this.ToolTip.SetToolTipIcon(this.ProductTreeView, null);
            this.ToolTip.SetToolTipTitle(this.ProductTreeView, "");
            this.ProductTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ProductTreeView_NodeMouseClick);
            // 
            // SectionContextMenuStrip
            // 
            this.SectionContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRootToolStripMenuItem,
            this.AddSectionToolStripMenuItem,
            this.AddProductToolStripMenuItem,
            this.RenameToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.SectionContextMenuStrip.Name = "SectionContextMenuStrip";
            resources.ApplyResources(this.SectionContextMenuStrip, "SectionContextMenuStrip");
            this.ToolTip.SetToolTip(this.SectionContextMenuStrip, "");
            this.ToolTip.SetToolTipIcon(this.SectionContextMenuStrip, null);
            this.ToolTip.SetToolTipTitle(this.SectionContextMenuStrip, "");
            // 
            // AddRootToolStripMenuItem
            // 
            this.AddRootToolStripMenuItem.Name = "AddRootToolStripMenuItem";
            resources.ApplyResources(this.AddRootToolStripMenuItem, "AddRootToolStripMenuItem");
            this.AddRootToolStripMenuItem.Click += new System.EventHandler(this.AddRootToolStripMenuItem_Click);
            // 
            // AddSectionToolStripMenuItem
            // 
            this.AddSectionToolStripMenuItem.Name = "AddSectionToolStripMenuItem";
            resources.ApplyResources(this.AddSectionToolStripMenuItem, "AddSectionToolStripMenuItem");
            this.AddSectionToolStripMenuItem.Click += new System.EventHandler(this.AddSectionToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            resources.ApplyResources(this.AddProductToolStripMenuItem, "AddProductToolStripMenuItem");
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // RenameToolStripMenuItem
            // 
            this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
            resources.ApplyResources(this.RenameToolStripMenuItem, "RenameToolStripMenuItem");
            this.RenameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            resources.ApplyResources(this.DeleteToolStripMenuItem, "DeleteToolStripMenuItem");
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "folderClosed.png");
            this.ImageList.Images.SetKeyName(1, "folderOpen.png");
            // 
            // EngButton
            // 
            this.EngButton.AllowAnimations = true;
            this.EngButton.AllowMouseEffects = true;
            this.EngButton.AllowToggling = false;
            this.EngButton.AnimationSpeed = 200;
            this.EngButton.AutoGenerateColors = false;
            this.EngButton.AutoRoundBorders = false;
            this.EngButton.AutoSizeLeftIcon = true;
            this.EngButton.AutoSizeRightIcon = true;
            this.EngButton.BackColor = System.Drawing.Color.Transparent;
            this.EngButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.EngButton, "EngButton");
            this.EngButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EngButton.ButtonText = "ENG";
            this.EngButton.ButtonTextMarginLeft = 0;
            this.EngButton.ColorContrastOnClick = 45;
            this.EngButton.ColorContrastOnHover = 45;
            this.EngButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = false;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = false;
            this.EngButton.CustomizableEdges = borderEdges7;
            this.EngButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EngButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EngButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EngButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EngButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EngButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.EngButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EngButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EngButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EngButton.IconMarginLeft = 11;
            this.EngButton.IconPadding = 10;
            this.EngButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EngButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EngButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EngButton.IconSize = 25;
            this.EngButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.EngButton.IdleBorderRadius = 30;
            this.EngButton.IdleBorderThickness = 2;
            this.EngButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.EngButton.IdleIconLeftImage = null;
            this.EngButton.IdleIconRightImage = null;
            this.EngButton.IndicateFocus = false;
            this.EngButton.Name = "EngButton";
            this.EngButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.EngButton.OnDisabledState.BorderRadius = 30;
            this.EngButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EngButton.OnDisabledState.BorderThickness = 2;
            this.EngButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EngButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.EngButton.OnDisabledState.IconLeftImage = null;
            this.EngButton.OnDisabledState.IconRightImage = null;
            this.EngButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.EngButton.onHoverState.BorderRadius = 30;
            this.EngButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EngButton.onHoverState.BorderThickness = 2;
            this.EngButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.EngButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.EngButton.onHoverState.IconLeftImage = null;
            this.EngButton.onHoverState.IconRightImage = null;
            this.EngButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.EngButton.OnIdleState.BorderRadius = 30;
            this.EngButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EngButton.OnIdleState.BorderThickness = 2;
            this.EngButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.EngButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.EngButton.OnIdleState.IconLeftImage = null;
            this.EngButton.OnIdleState.IconRightImage = null;
            this.EngButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EngButton.OnPressedState.BorderRadius = 30;
            this.EngButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EngButton.OnPressedState.BorderThickness = 2;
            this.EngButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.EngButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EngButton.OnPressedState.IconLeftImage = null;
            this.EngButton.OnPressedState.IconRightImage = null;
            this.EngButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EngButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EngButton.TextMarginLeft = 0;
            this.EngButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.EngButton, "Change Language Into English");
            this.ToolTip.SetToolTipIcon(this.EngButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.EngButton, "Language");
            this.EngButton.UseDefaultRadiusAndThickness = true;
            this.EngButton.Click += new System.EventHandler(this.EngButton_Click);
            // 
            // QuantityButton
            // 
            this.QuantityButton.AllowAnimations = true;
            this.QuantityButton.AllowMouseEffects = true;
            this.QuantityButton.AllowToggling = false;
            this.QuantityButton.AnimationSpeed = 200;
            this.QuantityButton.AutoGenerateColors = false;
            this.QuantityButton.AutoRoundBorders = false;
            this.QuantityButton.AutoSizeLeftIcon = true;
            this.QuantityButton.AutoSizeRightIcon = true;
            this.QuantityButton.BackColor = System.Drawing.Color.Transparent;
            this.QuantityButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.QuantityButton, "QuantityButton");
            this.QuantityButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.QuantityButton.ButtonText = "Quantity";
            this.QuantityButton.ButtonTextMarginLeft = 0;
            this.QuantityButton.ColorContrastOnClick = 45;
            this.QuantityButton.ColorContrastOnHover = 45;
            this.QuantityButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = false;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = false;
            this.QuantityButton.CustomizableEdges = borderEdges8;
            this.QuantityButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.QuantityButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.QuantityButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.QuantityButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.QuantityButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.QuantityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.QuantityButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuantityButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.QuantityButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.QuantityButton.IconMarginLeft = 11;
            this.QuantityButton.IconPadding = 10;
            this.QuantityButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuantityButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.QuantityButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.QuantityButton.IconSize = 25;
            this.QuantityButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.QuantityButton.IdleBorderRadius = 30;
            this.QuantityButton.IdleBorderThickness = 2;
            this.QuantityButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.QuantityButton.IdleIconLeftImage = null;
            this.QuantityButton.IdleIconRightImage = null;
            this.QuantityButton.IndicateFocus = false;
            this.QuantityButton.Name = "QuantityButton";
            this.QuantityButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.QuantityButton.OnDisabledState.BorderRadius = 30;
            this.QuantityButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.QuantityButton.OnDisabledState.BorderThickness = 2;
            this.QuantityButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.QuantityButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.QuantityButton.OnDisabledState.IconLeftImage = null;
            this.QuantityButton.OnDisabledState.IconRightImage = null;
            this.QuantityButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.QuantityButton.onHoverState.BorderRadius = 30;
            this.QuantityButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.QuantityButton.onHoverState.BorderThickness = 2;
            this.QuantityButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.QuantityButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.QuantityButton.onHoverState.IconLeftImage = null;
            this.QuantityButton.onHoverState.IconRightImage = null;
            this.QuantityButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.QuantityButton.OnIdleState.BorderRadius = 30;
            this.QuantityButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.QuantityButton.OnIdleState.BorderThickness = 2;
            this.QuantityButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.QuantityButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.QuantityButton.OnIdleState.IconLeftImage = null;
            this.QuantityButton.OnIdleState.IconRightImage = null;
            this.QuantityButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.QuantityButton.OnPressedState.BorderRadius = 30;
            this.QuantityButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.QuantityButton.OnPressedState.BorderThickness = 2;
            this.QuantityButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.QuantityButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.QuantityButton.OnPressedState.IconLeftImage = null;
            this.QuantityButton.OnPressedState.IconRightImage = null;
            this.QuantityButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuantityButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityButton.TextMarginLeft = 0;
            this.QuantityButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.QuantityButton, "Sort By Total Quantity");
            this.ToolTip.SetToolTipIcon(this.QuantityButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.QuantityButton, "Quantity");
            this.QuantityButton.UseDefaultRadiusAndThickness = true;
            this.QuantityButton.Click += new System.EventHandler(this.QuantityButton_Click);
            // 
            // RusButton
            // 
            this.RusButton.AllowAnimations = true;
            this.RusButton.AllowMouseEffects = true;
            this.RusButton.AllowToggling = false;
            this.RusButton.AnimationSpeed = 200;
            this.RusButton.AutoGenerateColors = false;
            this.RusButton.AutoRoundBorders = false;
            this.RusButton.AutoSizeLeftIcon = true;
            this.RusButton.AutoSizeRightIcon = true;
            this.RusButton.BackColor = System.Drawing.Color.Transparent;
            this.RusButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.RusButton, "RusButton");
            this.RusButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RusButton.ButtonText = "RUS";
            this.RusButton.ButtonTextMarginLeft = 0;
            this.RusButton.ColorContrastOnClick = 45;
            this.RusButton.ColorContrastOnHover = 45;
            this.RusButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = false;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = false;
            borderEdges9.TopRight = true;
            this.RusButton.CustomizableEdges = borderEdges9;
            this.RusButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RusButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RusButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RusButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RusButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.RusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RusButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RusButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RusButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RusButton.IconMarginLeft = 11;
            this.RusButton.IconPadding = 10;
            this.RusButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RusButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RusButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.RusButton.IconSize = 25;
            this.RusButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.RusButton.IdleBorderRadius = 30;
            this.RusButton.IdleBorderThickness = 2;
            this.RusButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.RusButton.IdleIconLeftImage = null;
            this.RusButton.IdleIconRightImage = null;
            this.RusButton.IndicateFocus = false;
            this.RusButton.Name = "RusButton";
            this.RusButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RusButton.OnDisabledState.BorderRadius = 30;
            this.RusButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RusButton.OnDisabledState.BorderThickness = 2;
            this.RusButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RusButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RusButton.OnDisabledState.IconLeftImage = null;
            this.RusButton.OnDisabledState.IconRightImage = null;
            this.RusButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RusButton.onHoverState.BorderRadius = 30;
            this.RusButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RusButton.onHoverState.BorderThickness = 2;
            this.RusButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RusButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.RusButton.onHoverState.IconLeftImage = null;
            this.RusButton.onHoverState.IconRightImage = null;
            this.RusButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.RusButton.OnIdleState.BorderRadius = 30;
            this.RusButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RusButton.OnIdleState.BorderThickness = 2;
            this.RusButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.RusButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.RusButton.OnIdleState.IconLeftImage = null;
            this.RusButton.OnIdleState.IconRightImage = null;
            this.RusButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RusButton.OnPressedState.BorderRadius = 30;
            this.RusButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RusButton.OnPressedState.BorderThickness = 2;
            this.RusButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.RusButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.RusButton.OnPressedState.IconLeftImage = null;
            this.RusButton.OnPressedState.IconRightImage = null;
            this.RusButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RusButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.RusButton.TextMarginLeft = 0;
            this.RusButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.RusButton, "Change Language Into Russian");
            this.ToolTip.SetToolTipIcon(this.RusButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.RusButton, "Language");
            this.RusButton.UseDefaultRadiusAndThickness = true;
            this.RusButton.Click += new System.EventHandler(this.RusButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.AllowAnimations = true;
            this.PriceButton.AllowMouseEffects = true;
            this.PriceButton.AllowToggling = false;
            this.PriceButton.AnimationSpeed = 200;
            this.PriceButton.AutoGenerateColors = false;
            this.PriceButton.AutoRoundBorders = false;
            this.PriceButton.AutoSizeLeftIcon = true;
            this.PriceButton.AutoSizeRightIcon = true;
            this.PriceButton.BackColor = System.Drawing.Color.Transparent;
            this.PriceButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            resources.ApplyResources(this.PriceButton, "PriceButton");
            this.PriceButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PriceButton.ButtonText = "Price";
            this.PriceButton.ButtonTextMarginLeft = 0;
            this.PriceButton.ColorContrastOnClick = 45;
            this.PriceButton.ColorContrastOnHover = 45;
            this.PriceButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = false;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = false;
            borderEdges10.TopRight = true;
            this.PriceButton.CustomizableEdges = borderEdges10;
            this.PriceButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PriceButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PriceButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PriceButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PriceButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.PriceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PriceButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PriceButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.PriceButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.PriceButton.IconMarginLeft = 11;
            this.PriceButton.IconPadding = 10;
            this.PriceButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PriceButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.PriceButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.PriceButton.IconSize = 25;
            this.PriceButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.PriceButton.IdleBorderRadius = 30;
            this.PriceButton.IdleBorderThickness = 2;
            this.PriceButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.PriceButton.IdleIconLeftImage = null;
            this.PriceButton.IdleIconRightImage = null;
            this.PriceButton.IndicateFocus = false;
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PriceButton.OnDisabledState.BorderRadius = 30;
            this.PriceButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PriceButton.OnDisabledState.BorderThickness = 2;
            this.PriceButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PriceButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PriceButton.OnDisabledState.IconLeftImage = null;
            this.PriceButton.OnDisabledState.IconRightImage = null;
            this.PriceButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PriceButton.onHoverState.BorderRadius = 30;
            this.PriceButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PriceButton.onHoverState.BorderThickness = 2;
            this.PriceButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PriceButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.PriceButton.onHoverState.IconLeftImage = null;
            this.PriceButton.onHoverState.IconRightImage = null;
            this.PriceButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.PriceButton.OnIdleState.BorderRadius = 30;
            this.PriceButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PriceButton.OnIdleState.BorderThickness = 2;
            this.PriceButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.PriceButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.PriceButton.OnIdleState.IconLeftImage = null;
            this.PriceButton.OnIdleState.IconRightImage = null;
            this.PriceButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PriceButton.OnPressedState.BorderRadius = 30;
            this.PriceButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PriceButton.OnPressedState.BorderThickness = 2;
            this.PriceButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PriceButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.PriceButton.OnPressedState.IconLeftImage = null;
            this.PriceButton.OnPressedState.IconRightImage = null;
            this.PriceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceButton.TextMarginLeft = 0;
            this.PriceButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ToolTip.SetToolTip(this.PriceButton, "Sort By Total Price");
            this.ToolTip.SetToolTipIcon(this.PriceButton, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.PriceButton, "Price");
            this.PriceButton.UseDefaultRadiusAndThickness = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // WorkCards
            // 
            this.WorkCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.WorkCards.BorderRadius = 30;
            this.WorkCards.BottomSahddow = true;
            this.WorkCards.color = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(229)))));
            this.WorkCards.Controls.Add(this.SearchTextBox);
            this.WorkCards.Controls.Add(this.GridPanel);
            resources.ApplyResources(this.WorkCards, "WorkCards");
            this.WorkCards.LeftSahddow = true;
            this.WorkCards.Name = "WorkCards";
            this.WorkCards.RightSahddow = true;
            this.WorkCards.ShadowDepth = 20;
            this.ToolTip.SetToolTip(this.WorkCards, "");
            this.ToolTip.SetToolTipIcon(this.WorkCards, null);
            this.ToolTip.SetToolTipTitle(this.WorkCards, "");
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AcceptsReturn = false;
            this.SearchTextBox.AcceptsTab = false;
            this.SearchTextBox.AnimationSpeed = 200;
            this.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SearchTextBox, "SearchTextBox");
            this.SearchTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SearchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(229)))));
            this.SearchTextBox.BorderRadius = 30;
            this.SearchTextBox.BorderThickness = 3;
            this.SearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.FillColor = System.Drawing.Color.White;
            this.SearchTextBox.HideSelection = true;
            this.SearchTextBox.IconLeft = null;
            this.SearchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.IconPadding = 10;
            this.SearchTextBox.IconRight = null;
            this.SearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Modified = false;
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(229)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnIdleState = stateProperties4;
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.SearchTextBox.PlaceholderText = "Enter text";
            this.SearchTextBox.ReadOnly = false;
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTextBox.TextMarginBottom = 0;
            this.SearchTextBox.TextMarginLeft = 10;
            this.SearchTextBox.TextMarginTop = 0;
            this.SearchTextBox.TextPlaceholder = "Enter text";
            this.ToolTip.SetToolTip(this.SearchTextBox, "Filter Products");
            this.ToolTip.SetToolTipIcon(this.SearchTextBox, global::WareHouse.Properties.Resources.message);
            this.ToolTip.SetToolTipTitle(this.SearchTextBox, "Filter");
            this.SearchTextBox.UseSystemPasswordChar = false;
            this.SearchTextBox.WordWrap = true;
            this.SearchTextBox.TextChange += new System.EventHandler(this.SearchTextBox_TextChange);
            // 
            // GridPanel
            // 
            resources.ApplyResources(this.GridPanel, "GridPanel");
            this.GridPanel.Controls.Add(this.GridVScrollBar);
            this.GridPanel.Controls.Add(this.GridView);
            this.GridPanel.Name = "GridPanel";
            this.ToolTip.SetToolTip(this.GridPanel, "");
            this.ToolTip.SetToolTipIcon(this.GridPanel, null);
            this.ToolTip.SetToolTipTitle(this.GridPanel, "");
            // 
            // GridVScrollBar
            // 
            this.GridVScrollBar.AllowCursorChanges = true;
            this.GridVScrollBar.AllowHomeEndKeysDetection = false;
            this.GridVScrollBar.AllowIncrementalClickMoves = true;
            this.GridVScrollBar.AllowMouseDownEffects = true;
            this.GridVScrollBar.AllowMouseHoverEffects = true;
            this.GridVScrollBar.AllowScrollingAnimations = true;
            this.GridVScrollBar.AllowScrollKeysDetection = true;
            this.GridVScrollBar.AllowScrollOptionsMenu = true;
            this.GridVScrollBar.AllowShrinkingOnFocusLost = false;
            resources.ApplyResources(this.GridVScrollBar, "GridVScrollBar");
            this.GridVScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.GridVScrollBar.BindingContainer = null;
            this.GridVScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.GridVScrollBar.BorderRadius = 14;
            this.GridVScrollBar.BorderThickness = 1;
            this.GridVScrollBar.DurationBeforeShrink = 2000;
            this.GridVScrollBar.LargeChange = 10;
            this.GridVScrollBar.Maximum = 100;
            this.GridVScrollBar.Minimum = 0;
            this.GridVScrollBar.MinimumThumbLength = 18;
            this.GridVScrollBar.Name = "GridVScrollBar";
            this.GridVScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.GridVScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.GridVScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.GridVScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.GridVScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.GridVScrollBar.ShrinkSizeLimit = 3;
            this.GridVScrollBar.SmallChange = 1;
            this.GridVScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(141)))), ((int)(((byte)(229)))));
            this.GridVScrollBar.ThumbLength = 47;
            this.GridVScrollBar.ThumbMargin = 1;
            this.GridVScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ToolTip.SetToolTip(this.GridVScrollBar, "");
            this.ToolTip.SetToolTipIcon(this.GridVScrollBar, null);
            this.ToolTip.SetToolTipTitle(this.GridVScrollBar, "");
            this.GridVScrollBar.Value = 0;
            this.GridVScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.GridVScrollBar_Scroll);
            // 
            // GridView
            // 
            this.GridView.AllowCustomTheming = false;
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.GridView, "GridView");
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(62)))));
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Photo,
            this.ProductName,
            this.ProductCode,
            this.ProductQuantity,
            this.productPrice,
            this.ProductDiscount,
            this.ProductUcn,
            this.ProductCountry,
            this.ProductGuarantee,
            this.ProductStatus,
            this.ProductPath});
            this.GridView.ContextMenuStrip = this.GridContextMenuStrip;
            this.GridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.GridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.GridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.GridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridView.CurrentTheme.Name = null;
            this.GridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.GridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.GridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.GridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridView.HeaderForeColor = System.Drawing.Color.White;
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowTemplate.Height = 40;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ToolTip.SetToolTip(this.GridView, "");
            this.ToolTip.SetToolTipIcon(this.GridView, null);
            this.ToolTip.SetToolTipTitle(this.GridView, "");
            // 
            // Photo
            // 
            this.Photo.FillWeight = 40F;
            resources.ApplyResources(this.Photo, "Photo");
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // ProductName
            // 
            resources.ApplyResources(this.ProductName, "ProductName");
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCode
            // 
            resources.ApplyResources(this.ProductCode, "ProductCode");
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            resources.ApplyResources(this.ProductQuantity, "ProductQuantity");
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // productPrice
            // 
            resources.ApplyResources(this.productPrice, "productPrice");
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // ProductDiscount
            // 
            resources.ApplyResources(this.ProductDiscount, "ProductDiscount");
            this.ProductDiscount.Name = "ProductDiscount";
            this.ProductDiscount.ReadOnly = true;
            // 
            // ProductUcn
            // 
            resources.ApplyResources(this.ProductUcn, "ProductUcn");
            this.ProductUcn.Name = "ProductUcn";
            this.ProductUcn.ReadOnly = true;
            // 
            // ProductCountry
            // 
            resources.ApplyResources(this.ProductCountry, "ProductCountry");
            this.ProductCountry.Name = "ProductCountry";
            this.ProductCountry.ReadOnly = true;
            // 
            // ProductGuarantee
            // 
            resources.ApplyResources(this.ProductGuarantee, "ProductGuarantee");
            this.ProductGuarantee.Name = "ProductGuarantee";
            this.ProductGuarantee.ReadOnly = true;
            // 
            // ProductStatus
            // 
            resources.ApplyResources(this.ProductStatus, "ProductStatus");
            this.ProductStatus.Name = "ProductStatus";
            this.ProductStatus.ReadOnly = true;
            // 
            // ProductPath
            // 
            resources.ApplyResources(this.ProductPath, "ProductPath");
            this.ProductPath.Name = "ProductPath";
            this.ProductPath.ReadOnly = true;
            // 
            // GridContextMenuStrip
            // 
            this.GridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteProductToolStripMenuItem});
            this.GridContextMenuStrip.Name = "GridContextMenuStrip";
            resources.ApplyResources(this.GridContextMenuStrip, "GridContextMenuStrip");
            this.ToolTip.SetToolTip(this.GridContextMenuStrip, "");
            this.ToolTip.SetToolTipIcon(this.GridContextMenuStrip, null);
            this.ToolTip.SetToolTipTitle(this.GridContextMenuStrip, "");
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteProductToolStripMenuItem
            // 
            this.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem";
            resources.ApplyResources(this.DeleteProductToolStripMenuItem, "DeleteProductToolStripMenuItem");
            this.DeleteProductToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolStripMenuItem_Click);
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
            this.FormDock.ShowCursorChanges = false;
            this.FormDock.ShowDockingIndicators = false;
            this.FormDock.TitleBarOptions.AllowFormDragging = true;
            this.FormDock.TitleBarOptions.BunifuFormDock = this.FormDock;
            this.FormDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.FormDock.TitleBarOptions.TitleBarControl = null;
            this.FormDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // SaveTimer
            // 
            this.SaveTimer.Enabled = true;
            this.SaveTimer.Interval = 180000;
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
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
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ToolPanel, "ToolPanel");
            this.ToolPanel.BorderRadius = 1;
            this.ToolPanel.Controls.Add(this.HideButton);
            this.ToolPanel.Controls.Add(this.RollButton);
            this.ToolPanel.Controls.Add(this.ExitButton);
            this.ToolPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.ToolPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Quality = 10;
            this.ToolTip.SetToolTip(this.ToolPanel, "");
            this.ToolTip.SetToolTipIcon(this.ToolPanel, null);
            this.ToolTip.SetToolTipTitle(this.ToolPanel, "");
            this.ToolPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ToolPanel_MouseDoubleClick);
            this.ToolPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolPanel_MouseDown);
            // 
            // HideButton
            // 
            this.HideButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HideButton, "HideButton");
            this.HideButton.Image = global::WareHouse.Properties.Resources.hide_button;
            this.HideButton.Name = "HideButton";
            this.ToolTip.SetToolTip(this.HideButton, "");
            this.ToolTip.SetToolTipIcon(this.HideButton, null);
            this.ToolTip.SetToolTipTitle(this.HideButton, "");
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // RollButton
            // 
            this.RollButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.RollButton, "RollButton");
            this.RollButton.Image = global::WareHouse.Properties.Resources.roll_button;
            this.RollButton.Name = "RollButton";
            this.ToolTip.SetToolTip(this.RollButton, "");
            this.ToolTip.SetToolTipIcon(this.RollButton, null);
            this.ToolTip.SetToolTipTitle(this.RollButton, "");
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Image = global::WareHouse.Properties.Resources.exit_button;
            this.ExitButton.Name = "ExitButton";
            this.ToolTip.SetToolTip(this.ExitButton, "");
            this.ToolTip.SetToolTipIcon(this.ExitButton, null);
            this.ToolTip.SetToolTipTitle(this.ExitButton, "");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.ToolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ToolCards.ResumeLayout(false);
            this.ToolTableLayoutPanel.ResumeLayout(false);
            this.SectionContextMenuStrip.ResumeLayout(false);
            this.WorkCards.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.GridContextMenuStrip.ResumeLayout(false);
            this.ToolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuElipse Elipse;
        private BunifuGradientPanel ToolPanel;
        private SplitContainer MainSplitContainer;
        private BunifuFormDock FormDock;
        private Button RollButton;
        private Button ExitButton;
        private Button HideButton;
        private BunifuCards ToolCards;
        private BunifuCards WorkCards;
        private BunifuButton AddSectionButton;
        private BunifuButton AddRootButton;
        private TreeView ProductTreeView;
        private TableLayoutPanel ToolTableLayoutPanel;
        private ContextMenuStrip SectionContextMenuStrip;
        private ToolStripMenuItem RenameToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
        private BunifuVScrollBar GridVScrollBar;
        private BunifuTextBox SearchTextBox;
        private BunifuDataGridView GridView;
        private Panel GridPanel;
        private ToolStripMenuItem AddSectionToolStripMenuItem;
        private ToolStripMenuItem AddProductToolStripMenuItem;
        private ImageList ImageList;
        private ToolStripMenuItem AddRootToolStripMenuItem;
        private ContextMenuStrip GridContextMenuStrip;
        private ToolStripMenuItem EditToolStripMenuItem;
        private BunifuButton EngButton;
        private BunifuButton ExportCsvButton;
        private DataGridViewImageColumn Photo;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn ProductDiscount;
        private DataGridViewTextBoxColumn ProductUcn;
        private DataGridViewTextBoxColumn ProductCountry;
        private DataGridViewTextBoxColumn ProductGuarantee;
        private DataGridViewTextBoxColumn ProductStatus;
        private DataGridViewTextBoxColumn ProductPath;
        private BunifuButton AddProductButton;
        private BunifuButton GenerateButton;
        private BunifuButton RusButton;
        private BunifuButton QuantityButton;
        private BunifuButton PriceButton;
        private ToolStripMenuItem DeleteProductToolStripMenuItem;
        private Timer SaveTimer;
        private BunifuToolTip ToolTip;
        private BunifuButton SaveLoadButton;
    }
}