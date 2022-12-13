namespace TugmaProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btn_minimize = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_maximize = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_close = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_tugma = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_random = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_write = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_rhyme = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pic_Loonie = new System.Windows.Forms.PictureBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loonie)).BeginInit();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.btn_minimize);
            this.panelHeader.Controls.Add(this.btn_maximize);
            this.panelHeader.Controls.Add(this.btn_close);
            this.panelHeader.Controls.Add(this.pic_logo);
            this.panelHeader.Controls.Add(this.lbl_tugma);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1250, 112);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.AllowAnimations = true;
            this.btn_minimize.AllowMouseEffects = true;
            this.btn_minimize.AllowToggling = false;
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.AnimationSpeed = 200;
            this.btn_minimize.AutoGenerateColors = false;
            this.btn_minimize.AutoRoundBorders = false;
            this.btn_minimize.AutoSizeLeftIcon = true;
            this.btn_minimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_minimize.AutoSizeRightIcon = true;
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.BackgroundImage")));
            this.btn_minimize.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_minimize.ButtonText = " ";
            this.btn_minimize.ButtonTextMarginLeft = 0;
            this.btn_minimize.ColorContrastOnClick = 45;
            this.btn_minimize.ColorContrastOnHover = 45;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.btn_minimize.CustomizableEdges = borderEdges13;
            this.btn_minimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_minimize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_minimize.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_minimize.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_minimize.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minimize.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_minimize.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_minimize.IconMarginLeft = 11;
            this.btn_minimize.IconPadding = 3;
            this.btn_minimize.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minimize.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_minimize.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_minimize.IconSize = 25;
            this.btn_minimize.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_minimize.IdleBorderRadius = 1;
            this.btn_minimize.IdleBorderThickness = 1;
            this.btn_minimize.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.IdleIconLeftImage")));
            this.btn_minimize.IdleIconRightImage = null;
            this.btn_minimize.IndicateFocus = false;
            this.btn_minimize.Location = new System.Drawing.Point(1051, 9);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_minimize.OnDisabledState.BorderRadius = 1;
            this.btn_minimize.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_minimize.OnDisabledState.BorderThickness = 1;
            this.btn_minimize.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_minimize.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_minimize.OnDisabledState.IconLeftImage = null;
            this.btn_minimize.OnDisabledState.IconRightImage = null;
            this.btn_minimize.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_minimize.onHoverState.BorderRadius = 1;
            this.btn_minimize.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_minimize.onHoverState.BorderThickness = 1;
            this.btn_minimize.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_minimize.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.onHoverState.IconLeftImage = null;
            this.btn_minimize.onHoverState.IconRightImage = null;
            this.btn_minimize.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minimize.OnIdleState.BorderRadius = 1;
            this.btn_minimize.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_minimize.OnIdleState.BorderThickness = 1;
            this.btn_minimize.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_minimize.OnIdleState.IconLeftImage")));
            this.btn_minimize.OnIdleState.IconRightImage = null;
            this.btn_minimize.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minimize.OnPressedState.BorderRadius = 1;
            this.btn_minimize.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_minimize.OnPressedState.BorderThickness = 1;
            this.btn_minimize.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_minimize.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.OnPressedState.IconLeftImage = null;
            this.btn_minimize.OnPressedState.IconRightImage = null;
            this.btn_minimize.Size = new System.Drawing.Size(62, 45);
            this.btn_minimize.TabIndex = 7;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_minimize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_minimize.TextMarginLeft = 0;
            this.btn_minimize.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_minimize.UseDefaultRadiusAndThickness = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.AllowAnimations = true;
            this.btn_maximize.AllowMouseEffects = true;
            this.btn_maximize.AllowToggling = false;
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.AnimationSpeed = 200;
            this.btn_maximize.AutoGenerateColors = false;
            this.btn_maximize.AutoRoundBorders = false;
            this.btn_maximize.AutoSizeLeftIcon = true;
            this.btn_maximize.AutoSizeRightIcon = true;
            this.btn_maximize.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximize.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.BackgroundImage")));
            this.btn_maximize.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_maximize.ButtonText = " ";
            this.btn_maximize.ButtonTextMarginLeft = 0;
            this.btn_maximize.ColorContrastOnClick = 45;
            this.btn_maximize.ColorContrastOnHover = 45;
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.btn_maximize.CustomizableEdges = borderEdges14;
            this.btn_maximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_maximize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_maximize.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_maximize.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_maximize.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_maximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maximize.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_maximize.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_maximize.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_maximize.IconMarginLeft = 11;
            this.btn_maximize.IconPadding = 3;
            this.btn_maximize.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_maximize.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_maximize.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_maximize.IconSize = 25;
            this.btn_maximize.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_maximize.IdleBorderRadius = 1;
            this.btn_maximize.IdleBorderThickness = 1;
            this.btn_maximize.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_maximize.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.IdleIconLeftImage")));
            this.btn_maximize.IdleIconRightImage = null;
            this.btn_maximize.IndicateFocus = false;
            this.btn_maximize.Location = new System.Drawing.Point(1113, 9);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_maximize.OnDisabledState.BorderRadius = 1;
            this.btn_maximize.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_maximize.OnDisabledState.BorderThickness = 1;
            this.btn_maximize.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_maximize.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_maximize.OnDisabledState.IconLeftImage = null;
            this.btn_maximize.OnDisabledState.IconRightImage = null;
            this.btn_maximize.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_maximize.onHoverState.BorderRadius = 1;
            this.btn_maximize.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_maximize.onHoverState.BorderThickness = 1;
            this.btn_maximize.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_maximize.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.onHoverState.IconLeftImage = null;
            this.btn_maximize.onHoverState.IconRightImage = null;
            this.btn_maximize.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_maximize.OnIdleState.BorderRadius = 1;
            this.btn_maximize.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_maximize.OnIdleState.BorderThickness = 1;
            this.btn_maximize.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_maximize.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_maximize.OnIdleState.IconLeftImage")));
            this.btn_maximize.OnIdleState.IconRightImage = null;
            this.btn_maximize.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_maximize.OnPressedState.BorderRadius = 1;
            this.btn_maximize.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_maximize.OnPressedState.BorderThickness = 1;
            this.btn_maximize.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_maximize.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_maximize.OnPressedState.IconLeftImage = null;
            this.btn_maximize.OnPressedState.IconRightImage = null;
            this.btn_maximize.Size = new System.Drawing.Size(64, 45);
            this.btn_maximize.TabIndex = 6;
            this.btn_maximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_maximize.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_maximize.TextMarginLeft = 0;
            this.btn_maximize.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_maximize.UseDefaultRadiusAndThickness = true;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.AllowAnimations = true;
            this.btn_close.AllowMouseEffects = true;
            this.btn_close.AllowToggling = false;
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AnimationSpeed = 200;
            this.btn_close.AutoGenerateColors = false;
            this.btn_close.AutoRoundBorders = false;
            this.btn_close.AutoSizeLeftIcon = true;
            this.btn_close.AutoSizeRightIcon = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.ButtonText = " ";
            this.btn_close.ButtonTextMarginLeft = 0;
            this.btn_close.ColorContrastOnClick = 45;
            this.btn_close.ColorContrastOnHover = 45;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.btn_close.CustomizableEdges = borderEdges15;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_close.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_close.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_close.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_close.IconMarginLeft = 11;
            this.btn_close.IconPadding = 3;
            this.btn_close.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_close.IconSize = 25;
            this.btn_close.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.IdleBorderRadius = 1;
            this.btn_close.IdleBorderThickness = 1;
            this.btn_close.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_close.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_close.IdleIconLeftImage")));
            this.btn_close.IdleIconRightImage = null;
            this.btn_close.IndicateFocus = false;
            this.btn_close.Location = new System.Drawing.Point(1181, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_close.OnDisabledState.BorderRadius = 1;
            this.btn_close.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnDisabledState.BorderThickness = 1;
            this.btn_close.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_close.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_close.OnDisabledState.IconLeftImage = null;
            this.btn_close.OnDisabledState.IconRightImage = null;
            this.btn_close.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_close.onHoverState.BorderRadius = 1;
            this.btn_close.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.onHoverState.BorderThickness = 1;
            this.btn_close.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_close.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_close.onHoverState.IconLeftImage = null;
            this.btn_close.onHoverState.IconRightImage = null;
            this.btn_close.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnIdleState.BorderRadius = 1;
            this.btn_close.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnIdleState.BorderThickness = 1;
            this.btn_close.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_close.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_close.OnIdleState.IconLeftImage")));
            this.btn_close.OnIdleState.IconRightImage = null;
            this.btn_close.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnPressedState.BorderRadius = 1;
            this.btn_close.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_close.OnPressedState.BorderThickness = 1;
            this.btn_close.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_close.OnPressedState.IconLeftImage = null;
            this.btn_close.OnPressedState.IconRightImage = null;
            this.btn_close.Size = new System.Drawing.Size(63, 45);
            this.btn_close.TabIndex = 5;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.TextMarginLeft = 0;
            this.btn_close.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_close.UseDefaultRadiusAndThickness = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(30, 22);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(69, 66);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            // 
            // lbl_tugma
            // 
            this.lbl_tugma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tugma.AutoSize = true;
            this.lbl_tugma.Font = new System.Drawing.Font("Joan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tugma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(172)))), ((int)(((byte)(72)))));
            this.lbl_tugma.Location = new System.Drawing.Point(105, 28);
            this.lbl_tugma.Name = "lbl_tugma";
            this.lbl_tugma.Size = new System.Drawing.Size(143, 59);
            this.lbl_tugma.TabIndex = 3;
            this.lbl_tugma.Text = "TUGMA";
            this.lbl_tugma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.btn_random);
            this.panel2.Controls.Add(this.btn_write);
            this.panel2.Controls.Add(this.btn_rhyme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 885);
            this.panel2.TabIndex = 1;
            // 
            // btn_random
            // 
            this.btn_random.AllowAnimations = true;
            this.btn_random.AllowMouseEffects = true;
            this.btn_random.AllowToggling = false;
            this.btn_random.AnimationSpeed = 200;
            this.btn_random.AutoGenerateColors = false;
            this.btn_random.AutoRoundBorders = false;
            this.btn_random.AutoSizeLeftIcon = true;
            this.btn_random.AutoSizeRightIcon = true;
            this.btn_random.BackColor = System.Drawing.Color.Transparent;
            this.btn_random.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_random.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_random.BackgroundImage")));
            this.btn_random.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_random.ButtonText = "RANDOM";
            this.btn_random.ButtonTextMarginLeft = 0;
            this.btn_random.ColorContrastOnClick = 45;
            this.btn_random.ColorContrastOnHover = 45;
            this.btn_random.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.btn_random.CustomizableEdges = borderEdges16;
            this.btn_random.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_random.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_random.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_random.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_random.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_random.Font = new System.Drawing.Font("Joan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_random.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_random.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_random.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_random.IconMarginLeft = 11;
            this.btn_random.IconPadding = 10;
            this.btn_random.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_random.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_random.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_random.IconSize = 25;
            this.btn_random.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_random.IdleBorderRadius = 1;
            this.btn_random.IdleBorderThickness = 1;
            this.btn_random.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_random.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_random.IdleIconLeftImage")));
            this.btn_random.IdleIconRightImage = null;
            this.btn_random.IndicateFocus = false;
            this.btn_random.Location = new System.Drawing.Point(0, 287);
            this.btn_random.Name = "btn_random";
            this.btn_random.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_random.OnDisabledState.BorderRadius = 1;
            this.btn_random.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_random.OnDisabledState.BorderThickness = 1;
            this.btn_random.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_random.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_random.OnDisabledState.IconLeftImage = null;
            this.btn_random.OnDisabledState.IconRightImage = null;
            this.btn_random.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_random.onHoverState.BorderRadius = 1;
            this.btn_random.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_random.onHoverState.BorderThickness = 1;
            this.btn_random.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_random.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_random.onHoverState.IconLeftImage = null;
            this.btn_random.onHoverState.IconRightImage = null;
            this.btn_random.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_random.OnIdleState.BorderRadius = 1;
            this.btn_random.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_random.OnIdleState.BorderThickness = 1;
            this.btn_random.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_random.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_random.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_random.OnIdleState.IconLeftImage")));
            this.btn_random.OnIdleState.IconRightImage = null;
            this.btn_random.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_random.OnPressedState.BorderRadius = 1;
            this.btn_random.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_random.OnPressedState.BorderThickness = 1;
            this.btn_random.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_random.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_random.OnPressedState.IconLeftImage = null;
            this.btn_random.OnPressedState.IconRightImage = null;
            this.btn_random.Size = new System.Drawing.Size(228, 96);
            this.btn_random.TabIndex = 2;
            this.btn_random.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_random.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_random.TextMarginLeft = 0;
            this.btn_random.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_random.UseDefaultRadiusAndThickness = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_write
            // 
            this.btn_write.AllowAnimations = true;
            this.btn_write.AllowMouseEffects = true;
            this.btn_write.AllowToggling = false;
            this.btn_write.AnimationSpeed = 200;
            this.btn_write.AutoGenerateColors = false;
            this.btn_write.AutoRoundBorders = false;
            this.btn_write.AutoSizeLeftIcon = true;
            this.btn_write.AutoSizeRightIcon = true;
            this.btn_write.BackColor = System.Drawing.Color.Transparent;
            this.btn_write.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_write.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_write.BackgroundImage")));
            this.btn_write.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_write.ButtonText = "WRITE   ";
            this.btn_write.ButtonTextMarginLeft = 0;
            this.btn_write.ColorContrastOnClick = 45;
            this.btn_write.ColorContrastOnHover = 45;
            this.btn_write.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.btn_write.CustomizableEdges = borderEdges17;
            this.btn_write.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_write.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_write.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_write.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_write.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_write.Font = new System.Drawing.Font("Joan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_write.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_write.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_write.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_write.IconMarginLeft = 11;
            this.btn_write.IconPadding = 10;
            this.btn_write.IconRightAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_write.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_write.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_write.IconSize = 25;
            this.btn_write.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_write.IdleBorderRadius = 1;
            this.btn_write.IdleBorderThickness = 1;
            this.btn_write.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_write.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_write.IdleIconLeftImage")));
            this.btn_write.IdleIconRightImage = null;
            this.btn_write.IndicateFocus = false;
            this.btn_write.Location = new System.Drawing.Point(0, 185);
            this.btn_write.Name = "btn_write";
            this.btn_write.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_write.OnDisabledState.BorderRadius = 1;
            this.btn_write.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_write.OnDisabledState.BorderThickness = 1;
            this.btn_write.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_write.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_write.OnDisabledState.IconLeftImage = null;
            this.btn_write.OnDisabledState.IconRightImage = null;
            this.btn_write.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_write.onHoverState.BorderRadius = 1;
            this.btn_write.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_write.onHoverState.BorderThickness = 1;
            this.btn_write.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_write.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_write.onHoverState.IconLeftImage = null;
            this.btn_write.onHoverState.IconRightImage = null;
            this.btn_write.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_write.OnIdleState.BorderRadius = 1;
            this.btn_write.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_write.OnIdleState.BorderThickness = 1;
            this.btn_write.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_write.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_write.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_write.OnIdleState.IconLeftImage")));
            this.btn_write.OnIdleState.IconRightImage = null;
            this.btn_write.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_write.OnPressedState.BorderRadius = 1;
            this.btn_write.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_write.OnPressedState.BorderThickness = 1;
            this.btn_write.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_write.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_write.OnPressedState.IconLeftImage = null;
            this.btn_write.OnPressedState.IconRightImage = null;
            this.btn_write.Size = new System.Drawing.Size(228, 96);
            this.btn_write.TabIndex = 1;
            this.btn_write.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_write.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_write.TextMarginLeft = 0;
            this.btn_write.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_write.UseDefaultRadiusAndThickness = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_rhyme
            // 
            this.btn_rhyme.AllowAnimations = true;
            this.btn_rhyme.AllowMouseEffects = true;
            this.btn_rhyme.AllowToggling = false;
            this.btn_rhyme.AnimationSpeed = 200;
            this.btn_rhyme.AutoGenerateColors = false;
            this.btn_rhyme.AutoRoundBorders = false;
            this.btn_rhyme.AutoSizeLeftIcon = true;
            this.btn_rhyme.AutoSizeRightIcon = true;
            this.btn_rhyme.BackColor = System.Drawing.Color.Transparent;
            this.btn_rhyme.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_rhyme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rhyme.BackgroundImage")));
            this.btn_rhyme.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_rhyme.ButtonText = "RHYME  ";
            this.btn_rhyme.ButtonTextMarginLeft = 0;
            this.btn_rhyme.ColorContrastOnClick = 45;
            this.btn_rhyme.ColorContrastOnHover = 45;
            this.btn_rhyme.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.btn_rhyme.CustomizableEdges = borderEdges18;
            this.btn_rhyme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_rhyme.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_rhyme.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_rhyme.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_rhyme.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_rhyme.Font = new System.Drawing.Font("Joan", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rhyme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_rhyme.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rhyme.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_rhyme.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_rhyme.IconMarginLeft = 11;
            this.btn_rhyme.IconPadding = 10;
            this.btn_rhyme.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rhyme.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_rhyme.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_rhyme.IconSize = 25;
            this.btn_rhyme.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_rhyme.IdleBorderRadius = 1;
            this.btn_rhyme.IdleBorderThickness = 1;
            this.btn_rhyme.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_rhyme.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_rhyme.IdleIconLeftImage")));
            this.btn_rhyme.IdleIconRightImage = null;
            this.btn_rhyme.IndicateFocus = false;
            this.btn_rhyme.Location = new System.Drawing.Point(0, 83);
            this.btn_rhyme.Name = "btn_rhyme";
            this.btn_rhyme.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_rhyme.OnDisabledState.BorderRadius = 1;
            this.btn_rhyme.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_rhyme.OnDisabledState.BorderThickness = 1;
            this.btn_rhyme.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_rhyme.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_rhyme.OnDisabledState.IconLeftImage = null;
            this.btn_rhyme.OnDisabledState.IconRightImage = null;
            this.btn_rhyme.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_rhyme.onHoverState.BorderRadius = 1;
            this.btn_rhyme.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_rhyme.onHoverState.BorderThickness = 1;
            this.btn_rhyme.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.btn_rhyme.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_rhyme.onHoverState.IconLeftImage = null;
            this.btn_rhyme.onHoverState.IconRightImage = null;
            this.btn_rhyme.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_rhyme.OnIdleState.BorderRadius = 1;
            this.btn_rhyme.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_rhyme.OnIdleState.BorderThickness = 1;
            this.btn_rhyme.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_rhyme.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_rhyme.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_rhyme.OnIdleState.IconLeftImage")));
            this.btn_rhyme.OnIdleState.IconRightImage = null;
            this.btn_rhyme.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_rhyme.OnPressedState.BorderRadius = 1;
            this.btn_rhyme.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_rhyme.OnPressedState.BorderThickness = 1;
            this.btn_rhyme.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(129)))), ((int)(((byte)(64)))));
            this.btn_rhyme.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btn_rhyme.OnPressedState.IconLeftImage = null;
            this.btn_rhyme.OnPressedState.IconRightImage = null;
            this.btn_rhyme.Size = new System.Drawing.Size(228, 96);
            this.btn_rhyme.TabIndex = 0;
            this.btn_rhyme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_rhyme.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_rhyme.TextMarginLeft = 0;
            this.btn_rhyme.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_rhyme.UseDefaultRadiusAndThickness = true;
            this.btn_rhyme.Click += new System.EventHandler(this.btn_rhyme_Click);
            // 
            // pic_Loonie
            // 
            this.pic_Loonie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Loonie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_Loonie.Image = ((System.Drawing.Image)(resources.GetObject("pic_Loonie.Image")));
            this.pic_Loonie.Location = new System.Drawing.Point(272, -26);
            this.pic_Loonie.Name = "pic_Loonie";
            this.pic_Loonie.Size = new System.Drawing.Size(857, 926);
            this.pic_Loonie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Loonie.TabIndex = 2;
            this.pic_Loonie.TabStop = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(172)))), ((int)(((byte)(72)))));
            this.panelDesktopPane.Controls.Add(this.pic_Loonie);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(231, 112);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1019, 885);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1250, 997);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1136, 653);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Loonie)).EndInit();
            this.panelDesktopPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_rhyme;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_random;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_write;
        private System.Windows.Forms.Label lbl_tugma;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.PictureBox pic_Loonie;
        private System.Windows.Forms.Panel panelDesktopPane;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_close;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_minimize;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_maximize;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

