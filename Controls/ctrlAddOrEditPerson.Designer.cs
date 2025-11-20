namespace DVLD_System_Version2
{
    partial class ctrlAddOrEditPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlAddOrEditPerson));
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblFirstName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblSecondName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblThirdName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblLastName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblNationalNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSecondName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbThirdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ulblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbNationalNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.ulblDOT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDOT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ulblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.ulblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblCountry = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ulblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.llblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAddressDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddressWarning = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmailValidating = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(50)))), ((int)(((byte)(160)))));
            this.lblTitle.Location = new System.Drawing.Point(415, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "Add New Person";
            // 
            // ulblID
            // 
            this.ulblID.BackColor = System.Drawing.Color.Transparent;
            this.ulblID.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblID.Location = new System.Drawing.Point(100, 129);
            this.ulblID.Name = "ulblID";
            this.ulblID.Size = new System.Drawing.Size(38, 29);
            this.ulblID.TabIndex = 1;
            this.ulblID.TabStop = false;
            this.ulblID.Text = "ID :";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(190, 129);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 29);
            this.lblID.TabIndex = 2;
            this.lblID.TabStop = false;
            this.lblID.Text = "???";
            // 
            // ulblFirstName
            // 
            this.ulblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.ulblFirstName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.ulblFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulblFirstName.Location = new System.Drawing.Point(190, 188);
            this.ulblFirstName.Name = "ulblFirstName";
            this.ulblFirstName.Size = new System.Drawing.Size(74, 24);
            this.ulblFirstName.TabIndex = 3;
            this.ulblFirstName.TabStop = false;
            this.ulblFirstName.Text = "FirstName";
            // 
            // ulblSecondName
            // 
            this.ulblSecondName.BackColor = System.Drawing.Color.Transparent;
            this.ulblSecondName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.ulblSecondName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulblSecondName.Location = new System.Drawing.Point(344, 188);
            this.ulblSecondName.Name = "ulblSecondName";
            this.ulblSecondName.Size = new System.Drawing.Size(94, 24);
            this.ulblSecondName.TabIndex = 4;
            this.ulblSecondName.TabStop = false;
            this.ulblSecondName.Text = "SecondName";
            // 
            // ulblThirdName
            // 
            this.ulblThirdName.BackColor = System.Drawing.Color.Transparent;
            this.ulblThirdName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.ulblThirdName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulblThirdName.Location = new System.Drawing.Point(517, 188);
            this.ulblThirdName.Name = "ulblThirdName";
            this.ulblThirdName.Size = new System.Drawing.Size(81, 24);
            this.ulblThirdName.TabIndex = 5;
            this.ulblThirdName.TabStop = false;
            this.ulblThirdName.Text = "ThirdName";
            // 
            // ulblLastName
            // 
            this.ulblLastName.BackColor = System.Drawing.Color.Transparent;
            this.ulblLastName.Font = new System.Drawing.Font("Trebuchet MS", 12.25F);
            this.ulblLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ulblLastName.Location = new System.Drawing.Point(686, 188);
            this.ulblLastName.Name = "ulblLastName";
            this.ulblLastName.Size = new System.Drawing.Size(71, 24);
            this.ulblLastName.TabIndex = 6;
            this.ulblLastName.TabStop = false;
            this.ulblLastName.Text = "LastName";
            // 
            // ulblNationalNo
            // 
            this.ulblNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.ulblNationalNo.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblNationalNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblNationalNo.Location = new System.Drawing.Point(3, 282);
            this.ulblNationalNo.Name = "ulblNationalNo";
            this.ulblNationalNo.Size = new System.Drawing.Size(135, 29);
            this.ulblNationalNo.TabIndex = 7;
            this.ulblNationalNo.TabStop = false;
            this.ulblNationalNo.Text = "NationalNo. :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Animated = true;
            this.tbFirstName.AutoRoundedCorners = true;
            this.tbFirstName.BorderRadius = 15;
            this.tbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFirstName.DefaultText = "";
            this.tbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFirstName.Location = new System.Drawing.Point(156, 214);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.Size = new System.Drawing.Size(157, 32);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Animated = true;
            this.tbSecondName.AutoRoundedCorners = true;
            this.tbSecondName.BorderRadius = 15;
            this.tbSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSecondName.DefaultText = "";
            this.tbSecondName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSecondName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSecondName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSecondName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSecondName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSecondName.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSecondName.Location = new System.Drawing.Point(321, 214);
            this.tbSecondName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.PasswordChar = '\0';
            this.tbSecondName.PlaceholderText = "";
            this.tbSecondName.SelectedText = "";
            this.tbSecondName.Size = new System.Drawing.Size(157, 32);
            this.tbSecondName.TabIndex = 1;
            this.tbSecondName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Animated = true;
            this.tbThirdName.AutoRoundedCorners = true;
            this.tbThirdName.BorderRadius = 15;
            this.tbThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbThirdName.DefaultText = "";
            this.tbThirdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbThirdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbThirdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThirdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbThirdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThirdName.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThirdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbThirdName.Location = new System.Drawing.Point(486, 214);
            this.tbThirdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.PasswordChar = '\0';
            this.tbThirdName.PlaceholderText = "";
            this.tbThirdName.SelectedText = "";
            this.tbThirdName.Size = new System.Drawing.Size(157, 32);
            this.tbThirdName.TabIndex = 2;
            this.tbThirdName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Animated = true;
            this.tbLastName.AutoRoundedCorners = true;
            this.tbLastName.BorderRadius = 15;
            this.tbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLastName.DefaultText = "";
            this.tbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLastName.Location = new System.Drawing.Point(651, 214);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PasswordChar = '\0';
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.SelectedText = "";
            this.tbLastName.Size = new System.Drawing.Size(157, 32);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // ulblName
            // 
            this.ulblName.BackColor = System.Drawing.Color.Transparent;
            this.ulblName.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblName.Location = new System.Drawing.Point(64, 214);
            this.ulblName.Name = "ulblName";
            this.ulblName.Size = new System.Drawing.Size(74, 29);
            this.ulblName.TabIndex = 12;
            this.ulblName.TabStop = false;
            this.ulblName.Text = "Name :";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Animated = true;
            this.tbNationalNo.AutoRoundedCorners = true;
            this.tbNationalNo.BorderRadius = 15;
            this.tbNationalNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNationalNo.DefaultText = "";
            this.tbNationalNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNationalNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNationalNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNationalNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalNo.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNationalNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNationalNo.Location = new System.Drawing.Point(156, 282);
            this.tbNationalNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.PasswordChar = '\0';
            this.tbNationalNo.PlaceholderText = "";
            this.tbNationalNo.SelectedText = "";
            this.tbNationalNo.Size = new System.Drawing.Size(157, 32);
            this.tbNationalNo.TabIndex = 4;
            this.tbNationalNo.TextChanged += new System.EventHandler(this.tbNationaNo_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.AutoRoundedCorners = true;
            this.tbEmail.BorderRadius = 15;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(156, 416);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(157, 32);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // ulblDOT
            // 
            this.ulblDOT.BackColor = System.Drawing.Color.Transparent;
            this.ulblDOT.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblDOT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblDOT.Location = new System.Drawing.Point(339, 278);
            this.ulblDOT.Name = "ulblDOT";
            this.ulblDOT.Size = new System.Drawing.Size(120, 29);
            this.ulblDOT.TabIndex = 15;
            this.ulblDOT.TabStop = false;
            this.ulblDOT.Text = "Birth Date :";
            // 
            // dtpDOT
            // 
            this.dtpDOT.Animated = true;
            this.dtpDOT.AutoRoundedCorners = true;
            this.dtpDOT.BorderRadius = 15;
            this.dtpDOT.Checked = true;
            this.dtpDOT.FillColor = System.Drawing.Color.LightGray;
            this.dtpDOT.Font = new System.Drawing.Font("Traditional Arabic", 11.25F);
            this.dtpDOT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpDOT.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpDOT.IndicateFocus = true;
            this.dtpDOT.Location = new System.Drawing.Point(486, 281);
            this.dtpDOT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOT.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOT.Name = "dtpDOT";
            this.dtpDOT.Size = new System.Drawing.Size(157, 32);
            this.dtpDOT.TabIndex = 5;
            this.dtpDOT.Value = new System.DateTime(2025, 2, 20, 15, 10, 23, 143);
            // 
            // ulblEmail
            // 
            this.ulblEmail.BackColor = System.Drawing.Color.Transparent;
            this.ulblEmail.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblEmail.Location = new System.Drawing.Point(66, 418);
            this.ulblEmail.Name = "ulblEmail";
            this.ulblEmail.Size = new System.Drawing.Size(72, 29);
            this.ulblEmail.TabIndex = 17;
            this.ulblEmail.TabStop = false;
            this.ulblEmail.Text = "Email :";
            // 
            // ulblGender
            // 
            this.ulblGender.BackColor = System.Drawing.Color.Transparent;
            this.ulblGender.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblGender.Location = new System.Drawing.Point(48, 350);
            this.ulblGender.Name = "ulblGender";
            this.ulblGender.Size = new System.Drawing.Size(90, 29);
            this.ulblGender.TabIndex = 18;
            this.ulblGender.TabStop = false;
            this.ulblGender.Text = "Gender :";
            // 
            // rbMale
            // 
            this.rbMale.Animated = true;
            this.rbMale.AutoSize = true;
            this.rbMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.BorderThickness = 0;
            this.rbMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMale.CheckedState.InnerOffset = -4;
            this.rbMale.Font = new System.Drawing.Font("Traditional Arabic", 14F);
            this.rbMale.Location = new System.Drawing.Point(156, 350);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(70, 35);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMale.UncheckedState.BorderThickness = 2;
            this.rbMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.Animated = true;
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.BorderThickness = 0;
            this.rbFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFemale.CheckedState.InnerOffset = -4;
            this.rbFemale.Font = new System.Drawing.Font("Traditional Arabic", 14F);
            this.rbFemale.Location = new System.Drawing.Point(227, 350);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(86, 35);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFemale.UncheckedState.BorderThickness = 2;
            this.rbFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // ulblPhone
            // 
            this.ulblPhone.BackColor = System.Drawing.Color.Transparent;
            this.ulblPhone.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblPhone.Location = new System.Drawing.Point(381, 350);
            this.ulblPhone.Name = "ulblPhone";
            this.ulblPhone.Size = new System.Drawing.Size(78, 29);
            this.ulblPhone.TabIndex = 21;
            this.ulblPhone.TabStop = false;
            this.ulblPhone.Text = "Phone :";
            // 
            // ulblCountry
            // 
            this.ulblCountry.BackColor = System.Drawing.Color.Transparent;
            this.ulblCountry.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblCountry.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblCountry.Location = new System.Drawing.Point(363, 418);
            this.ulblCountry.Name = "ulblCountry";
            this.ulblCountry.Size = new System.Drawing.Size(96, 29);
            this.ulblCountry.TabIndex = 22;
            this.ulblCountry.TabStop = false;
            this.ulblCountry.Text = "Country :";
            // 
            // tbPhone
            // 
            this.tbPhone.Animated = true;
            this.tbPhone.AutoRoundedCorners = true;
            this.tbPhone.BorderRadius = 15;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.DefaultText = "";
            this.tbPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Font = new System.Drawing.Font("Traditional Arabic", 11.25F);
            this.tbPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPhone.Location = new System.Drawing.Point(486, 348);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.PasswordChar = '\0';
            this.tbPhone.PlaceholderText = "";
            this.tbPhone.SelectedText = "";
            this.tbPhone.Size = new System.Drawing.Size(157, 32);
            this.tbPhone.TabIndex = 8;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // cbCountries
            // 
            this.cbCountries.AutoRoundedCorners = true;
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderRadius = 17;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Traditional Arabic", 11.25F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(486, 416);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(157, 36);
            this.cbCountries.TabIndex = 10;
            // 
            // ulblAddress
            // 
            this.ulblAddress.BackColor = System.Drawing.Color.Transparent;
            this.ulblAddress.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.ulblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ulblAddress.Location = new System.Drawing.Point(44, 485);
            this.ulblAddress.Name = "ulblAddress";
            this.ulblAddress.Size = new System.Drawing.Size(94, 29);
            this.ulblAddress.TabIndex = 25;
            this.ulblAddress.TabStop = false;
            this.ulblAddress.Text = "Address :";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(27, 595);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(803, 10);
            this.guna2Separator1.TabIndex = 27;
            this.guna2Separator1.TabStop = false;
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Font = new System.Drawing.Font("Traditional Arabic", 16F);
            this.llblSetImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.llblSetImage.Location = new System.Drawing.Point(883, 487);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(100, 35);
            this.llblSetImage.TabIndex = 12;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // llblRemoveImage
            // 
            this.llblRemoveImage.AutoSize = true;
            this.llblRemoveImage.Font = new System.Drawing.Font("Traditional Arabic", 16F);
            this.llblRemoveImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.llblRemoveImage.Location = new System.Drawing.Point(887, 527);
            this.llblRemoveImage.Name = "llblRemoveImage";
            this.llblRemoveImage.Size = new System.Drawing.Size(92, 35);
            this.llblRemoveImage.TabIndex = 13;
            this.llblRemoveImage.TabStop = true;
            this.llblRemoveImage.Text = "Remove";
            this.llblRemoveImage.Visible = false;
            this.llblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemoveImage_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BorderRadius = 16;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(962, 663);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 16;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Trebuchet MS", 16.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(836, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            this.ofdImage.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff;*.webp\"";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.FillColor = System.Drawing.Color.Transparent;
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(836, 282);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 28;
            this.pbImage.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 150;
            this.errorProvider.ContainerControl = this;
            // 
            // lblAddressDescription
            // 
            this.lblAddressDescription.AutoSize = false;
            this.lblAddressDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressDescription.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblAddressDescription.Location = new System.Drawing.Point(48, 525);
            this.lblAddressDescription.Name = "lblAddressDescription";
            this.lblAddressDescription.Size = new System.Drawing.Size(833, 64);
            this.lblAddressDescription.TabIndex = 29;
            this.lblAddressDescription.TabStop = false;
            this.lblAddressDescription.Text = resources.GetString("lblAddressDescription.Text");
            this.lblAddressDescription.Visible = false;
            // 
            // lblAddressWarning
            // 
            this.lblAddressWarning.AutoSize = false;
            this.lblAddressWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressWarning.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAddressWarning.Location = new System.Drawing.Point(156, 525);
            this.lblAddressWarning.Name = "lblAddressWarning";
            this.lblAddressWarning.Size = new System.Drawing.Size(203, 24);
            this.lblAddressWarning.TabIndex = 30;
            this.lblAddressWarning.TabStop = false;
            this.lblAddressWarning.Text = "Address is not valid! ";
            this.lblAddressWarning.Visible = false;
            // 
            // tbAddress
            // 
            this.tbAddress.Animated = true;
            this.tbAddress.AutoRoundedCorners = true;
            this.tbAddress.BorderRadius = 15;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.DefaultText = "";
            this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Font = new System.Drawing.Font("Traditional Arabic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAddress.Location = new System.Drawing.Point(156, 482);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PlaceholderText = "";
            this.tbAddress.SelectedText = "";
            this.tbAddress.Size = new System.Drawing.Size(652, 32);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbAddress.Enter += new System.EventHandler(this.tbAddress_Enter);
            this.tbAddress.Leave += new System.EventHandler(this.tbAddress_Leave);
            // 
            // lblEmailValidating
            // 
            this.lblEmailValidating.AutoSize = false;
            this.lblEmailValidating.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailValidating.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValidating.ForeColor = System.Drawing.Color.Red;
            this.lblEmailValidating.Location = new System.Drawing.Point(156, 450);
            this.lblEmailValidating.Name = "lblEmailValidating";
            this.lblEmailValidating.Size = new System.Drawing.Size(157, 24);
            this.lblEmailValidating.TabIndex = 31;
            this.lblEmailValidating.TabStop = false;
            this.lblEmailValidating.Text = "Email is invalid! ";
            this.lblEmailValidating.Visible = false;
            // 
            // ctrlAddOrEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblEmailValidating);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lblAddressWarning);
            this.Controls.Add(this.lblAddressDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.llblRemoveImage);
            this.Controls.Add(this.llblSetImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ulblAddress);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.ulblCountry);
            this.Controls.Add(this.ulblPhone);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.ulblGender);
            this.Controls.Add(this.ulblEmail);
            this.Controls.Add(this.dtpDOT);
            this.Controls.Add(this.ulblDOT);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNationalNo);
            this.Controls.Add(this.ulblName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.ulblNationalNo);
            this.Controls.Add(this.ulblLastName);
            this.Controls.Add(this.ulblThirdName);
            this.Controls.Add(this.ulblSecondName);
            this.Controls.Add(this.ulblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ulblID);
            this.Controls.Add(this.lblTitle);
            this.Name = "ctrlAddOrEditPerson";
            this.Size = new System.Drawing.Size(1067, 735);
            this.Load += new System.EventHandler(this.ctrlAddOrEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblFirstName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblSecondName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblThirdName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox tbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox tbSecondName;
        private Guna.UI2.WinForms.Guna2TextBox tbThirdName;
        private Guna.UI2.WinForms.Guna2TextBox tbLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblName;
        private Guna.UI2.WinForms.Guna2TextBox tbNationalNo;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblDOT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOT;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblGender;
        private Guna.UI2.WinForms.Guna2RadioButton rbMale;
        private Guna.UI2.WinForms.Guna2RadioButton rbFemale;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblCountry;
        private Guna.UI2.WinForms.Guna2TextBox tbPhone;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblAddress;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.LinkLabel llblSetImage;
        private System.Windows.Forms.LinkLabel llblRemoveImage;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddressDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddressWarning;
        private Guna.UI2.WinForms.Guna2TextBox tbAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmailValidating;
    }
}
