namespace TugmaProject.Forms
{
    partial class FormRhyme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRhyme));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lbl_RhymeGen = new System.Windows.Forms.Label();
            this.tb_SearchBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuRadioButton1 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_ExactRhyme = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.lbl_ExactRhyme = new System.Windows.Forms.Label();
            this.lbl_SlantRhyme = new System.Windows.Forms.Label();
            this.lbl_EndRhyme = new System.Windows.Forms.Label();
            this.rb_SlantRhyme = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.rb_EndRhyme = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.listBox_Results = new System.Windows.Forms.ListBox();
            this.btn_Search = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RhymeGen
            // 
            this.lbl_RhymeGen.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lbl_RhymeGen.AutoSize = true;
            this.lbl_RhymeGen.Font = new System.Drawing.Font("Joan", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RhymeGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.lbl_RhymeGen.Location = new System.Drawing.Point(172, 43);
            this.lbl_RhymeGen.Name = "lbl_RhymeGen";
            this.lbl_RhymeGen.Size = new System.Drawing.Size(719, 116);
            this.lbl_RhymeGen.TabIndex = 1;
            this.lbl_RhymeGen.Text = "RHYME GENERATOR";
            // 
            // tb_SearchBox
            // 
            this.tb_SearchBox.AcceptsReturn = false;
            this.tb_SearchBox.AcceptsTab = false;
            this.tb_SearchBox.AnimationSpeed = 200;
            this.tb_SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_SearchBox.BackColor = System.Drawing.Color.Transparent;
            this.tb_SearchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_SearchBox.BackgroundImage")));
            this.tb_SearchBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.tb_SearchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_SearchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.tb_SearchBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.tb_SearchBox.BorderRadius = 35;
            this.tb_SearchBox.BorderThickness = 1;
            this.tb_SearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchBox.DefaultFont = new System.Drawing.Font("Joan", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchBox.DefaultText = "";
            this.tb_SearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.tb_SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.tb_SearchBox.HideSelection = true;
            this.tb_SearchBox.IconLeft = null;
            this.tb_SearchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchBox.IconPadding = 10;
            this.tb_SearchBox.IconRight = null;
            this.tb_SearchBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_SearchBox.Lines = new string[0];
            this.tb_SearchBox.Location = new System.Drawing.Point(121, 176);
            this.tb_SearchBox.MaxLength = 32767;
            this.tb_SearchBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.tb_SearchBox.Modified = false;
            this.tb_SearchBox.Multiline = false;
            this.tb_SearchBox.Name = "tb_SearchBox";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tb_SearchBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tb_SearchBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tb_SearchBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Transparent;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tb_SearchBox.OnIdleState = stateProperties16;
            this.tb_SearchBox.Padding = new System.Windows.Forms.Padding(3);
            this.tb_SearchBox.PasswordChar = '\0';
            this.tb_SearchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(172)))), ((int)(((byte)(72)))));
            this.tb_SearchBox.PlaceholderText = "ENTER A WORD";
            this.tb_SearchBox.ReadOnly = false;
            this.tb_SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_SearchBox.SelectedText = "";
            this.tb_SearchBox.SelectionLength = 0;
            this.tb_SearchBox.SelectionStart = 0;
            this.tb_SearchBox.ShortcutsEnabled = true;
            this.tb_SearchBox.Size = new System.Drawing.Size(797, 84);
            this.tb_SearchBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tb_SearchBox.TabIndex = 2;
            this.tb_SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_SearchBox.TextMarginBottom = 0;
            this.tb_SearchBox.TextMarginLeft = 3;
            this.tb_SearchBox.TextMarginTop = 0;
            this.tb_SearchBox.TextPlaceholder = "ENTER A WORD";
            this.tb_SearchBox.UseSystemPasswordChar = false;
            this.tb_SearchBox.WordWrap = true;
            this.tb_SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_SearchBox_KeyDown);
            // 
            // bunifuRadioButton1
            // 
            this.bunifuRadioButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuRadioButton1.AllowBindingControlLocation = false;
            this.bunifuRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadioButton1.BindingControl = this.bunifuRadioButton1;
            this.bunifuRadioButton1.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.bunifuRadioButton1.BorderThickness = 2;
            this.bunifuRadioButton1.Checked = true;
            this.bunifuRadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuRadioButton1.Location = new System.Drawing.Point(32723, 32655);
            this.bunifuRadioButton1.Name = "bunifuRadioButton1";
            this.bunifuRadioButton1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.bunifuRadioButton1.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuRadioButton1.OutlineColorUnchecked = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.bunifuRadioButton1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.bunifuRadioButton1.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuRadioButton1.Size = new System.Drawing.Size(21, 21);
            this.bunifuRadioButton1.TabIndex = 3;
            this.bunifuRadioButton1.Text = null;
            // 
            // rb_ExactRhyme
            // 
            this.rb_ExactRhyme.AllowBindingControlLocation = false;
            this.rb_ExactRhyme.BackColor = System.Drawing.Color.Transparent;
            this.rb_ExactRhyme.BindingControl = this.lbl_ExactRhyme;
            this.rb_ExactRhyme.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_ExactRhyme.BorderThickness = 2;
            this.rb_ExactRhyme.Checked = false;
            this.rb_ExactRhyme.Location = new System.Drawing.Point(158, 275);
            this.rb_ExactRhyme.Name = "rb_ExactRhyme";
            this.rb_ExactRhyme.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_ExactRhyme.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_ExactRhyme.OutlineColorUnchecked = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_ExactRhyme.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_ExactRhyme.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_ExactRhyme.Size = new System.Drawing.Size(30, 30);
            this.rb_ExactRhyme.TabIndex = 4;
            this.rb_ExactRhyme.Text = null;
            // 
            // lbl_ExactRhyme
            // 
            this.lbl_ExactRhyme.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lbl_ExactRhyme.AutoSize = true;
            this.lbl_ExactRhyme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ExactRhyme.Font = new System.Drawing.Font("Joan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExactRhyme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.lbl_ExactRhyme.Location = new System.Drawing.Point(188, 272);
            this.lbl_ExactRhyme.Name = "lbl_ExactRhyme";
            this.lbl_ExactRhyme.Size = new System.Drawing.Size(153, 35);
            this.lbl_ExactRhyme.TabIndex = 5;
            this.lbl_ExactRhyme.Text = "EXACT RHYME";
            // 
            // lbl_SlantRhyme
            // 
            this.lbl_SlantRhyme.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lbl_SlantRhyme.AutoSize = true;
            this.lbl_SlantRhyme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_SlantRhyme.Font = new System.Drawing.Font("Joan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SlantRhyme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.lbl_SlantRhyme.Location = new System.Drawing.Point(456, 272);
            this.lbl_SlantRhyme.Name = "lbl_SlantRhyme";
            this.lbl_SlantRhyme.Size = new System.Drawing.Size(153, 35);
            this.lbl_SlantRhyme.TabIndex = 6;
            this.lbl_SlantRhyme.Text = "SLANT RHYME";
            // 
            // lbl_EndRhyme
            // 
            this.lbl_EndRhyme.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.lbl_EndRhyme.AutoSize = true;
            this.lbl_EndRhyme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_EndRhyme.Font = new System.Drawing.Font("Joan", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndRhyme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.lbl_EndRhyme.Location = new System.Drawing.Point(726, 272);
            this.lbl_EndRhyme.Name = "lbl_EndRhyme";
            this.lbl_EndRhyme.Size = new System.Drawing.Size(130, 35);
            this.lbl_EndRhyme.TabIndex = 7;
            this.lbl_EndRhyme.Text = "END RHYME";
            // 
            // rb_SlantRhyme
            // 
            this.rb_SlantRhyme.AllowBindingControlLocation = false;
            this.rb_SlantRhyme.BackColor = System.Drawing.Color.Transparent;
            this.rb_SlantRhyme.BindingControl = this.lbl_SlantRhyme;
            this.rb_SlantRhyme.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_SlantRhyme.BorderThickness = 2;
            this.rb_SlantRhyme.Checked = false;
            this.rb_SlantRhyme.Location = new System.Drawing.Point(426, 274);
            this.rb_SlantRhyme.Name = "rb_SlantRhyme";
            this.rb_SlantRhyme.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_SlantRhyme.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_SlantRhyme.OutlineColorUnchecked = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_SlantRhyme.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_SlantRhyme.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_SlantRhyme.Size = new System.Drawing.Size(30, 30);
            this.rb_SlantRhyme.TabIndex = 8;
            this.rb_SlantRhyme.Text = null;
            // 
            // rb_EndRhyme
            // 
            this.rb_EndRhyme.AllowBindingControlLocation = false;
            this.rb_EndRhyme.BackColor = System.Drawing.Color.Transparent;
            this.rb_EndRhyme.BindingControl = this.lbl_EndRhyme;
            this.rb_EndRhyme.BindingControlPosition = Bunifu.UI.WinForms.BunifuRadioButton.BindingControlPositions.Right;
            this.rb_EndRhyme.BorderThickness = 2;
            this.rb_EndRhyme.Checked = false;
            this.rb_EndRhyme.Location = new System.Drawing.Point(695, 275);
            this.rb_EndRhyme.Name = "rb_EndRhyme";
            this.rb_EndRhyme.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_EndRhyme.OutlineColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_EndRhyme.OutlineColorUnchecked = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_EndRhyme.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.rb_EndRhyme.RadioColorTabFocused = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rb_EndRhyme.Size = new System.Drawing.Size(30, 30);
            this.rb_EndRhyme.TabIndex = 9;
            this.rb_EndRhyme.Text = null;
            // 
            // listBox_Results
            // 
            this.listBox_Results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.listBox_Results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Results.Font = new System.Drawing.Font("Joan", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.listBox_Results.FormattingEnabled = true;
            this.listBox_Results.ItemHeight = 54;
            this.listBox_Results.Location = new System.Drawing.Point(121, 382);
            this.listBox_Results.Name = "listBox_Results";
            this.listBox_Results.Size = new System.Drawing.Size(797, 486);
            this.listBox_Results.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(66)))));
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageActive = null;
            this.btn_Search.Location = new System.Drawing.Point(827, 183);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(73, 69);
            this.btn_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Search.TabIndex = 12;
            this.btn_Search.TabStop = false;
            this.btn_Search.Zoom = 10;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // FormRhyme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(172)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1134, 1023);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.listBox_Results);
            this.Controls.Add(this.rb_EndRhyme);
            this.Controls.Add(this.rb_SlantRhyme);
            this.Controls.Add(this.lbl_EndRhyme);
            this.Controls.Add(this.lbl_SlantRhyme);
            this.Controls.Add(this.lbl_ExactRhyme);
            this.Controls.Add(this.rb_ExactRhyme);
            this.Controls.Add(this.bunifuRadioButton1);
            this.Controls.Add(this.tb_SearchBox);
            this.Controls.Add(this.lbl_RhymeGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRhyme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRhyme";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_RhymeGen;
        private Bunifu.UI.WinForms.BunifuTextBox tb_SearchBox;
        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton1;
        private System.Windows.Forms.Label lbl_SlantRhyme;
        private System.Windows.Forms.Label lbl_EndRhyme;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_SlantRhyme;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_EndRhyme;
        private System.Windows.Forms.ListBox listBox_Results;
        private Bunifu.Framework.UI.BunifuImageButton btn_Search;
        private System.Windows.Forms.Label lbl_ExactRhyme;
        private Bunifu.UI.WinForms.BunifuRadioButton rb_ExactRhyme;
    }
}