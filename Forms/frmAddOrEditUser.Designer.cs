namespace DVLD_System_Version2
{
    partial class frmAddOrEditUser
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
            DVLD_Business.clsPerson clsPerson1 = new DVLD_Business.clsPerson();
            DVLD_Business.clsPerson clsPerson2 = new DVLD_Business.clsPerson();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonDetails = new System.Windows.Forms.TabPage();
            this.lblTitle1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlPersonFilter1 = new DVLD_System_Version2.ctrlPersonFilter();
            this.ctrlPersonDetails1 = new DVLD_System_Version2.ctrlPersonDetails();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.tpUserDetails = new System.Windows.Forms.TabPage();
            this.chbIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblTitle2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ulblConfirmPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2CircleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpPersonDetails.SuspendLayout();
            this.tpUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonDetails);
            this.tabControl1.Controls.Add(this.tpUserDetails);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1048, 760);
            this.tabControl1.TabIndex = 1;
            // 
            // tpPersonDetails
            // 
            this.tpPersonDetails.Controls.Add(this.lblTitle1);
            this.tpPersonDetails.Controls.Add(this.ctrlPersonFilter1);
            this.tpPersonDetails.Controls.Add(this.ctrlPersonDetails1);
            this.tpPersonDetails.Controls.Add(this.btnNext);
            this.tpPersonDetails.Controls.Add(this.guna2Separator1);
            this.tpPersonDetails.Location = new System.Drawing.Point(4, 22);
            this.tpPersonDetails.Name = "tpPersonDetails";
            this.tpPersonDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonDetails.Size = new System.Drawing.Size(1040, 734);
            this.tpPersonDetails.TabIndex = 1;
            this.tpPersonDetails.Text = "Person Details";
            this.tpPersonDetails.UseVisualStyleBackColor = true;
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.lblTitle1.Location = new System.Drawing.Point(365, 6);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(202, 42);
            this.lblTitle1.TabIndex = 17;
            this.lblTitle1.TabStop = false;
            this.lblTitle1.Text = "Add New User";
            // 
            // ctrlPersonFilter1
            // 
            this.ctrlPersonFilter1.Location = new System.Drawing.Point(8, 84);
            this.ctrlPersonFilter1.Name = "ctrlPersonFilter1";
            clsPerson1.Address = "";
            clsPerson1.DateOfBirth = new System.DateTime(2007, 3, 17, 0, 0, 0, 0);
            clsPerson1.Email = "";
            clsPerson1.FirstName = "";
            clsPerson1.Gendor = ((byte)(2));
            clsPerson1.ImagePath = "";
            clsPerson1.LastName = "";
            clsPerson1.NationalityCountryID = -1;
            clsPerson1.NationalNo = "";
            clsPerson1.PersonID = -1;
            clsPerson1.Phone = "";
            clsPerson1.SecondName = "";
            clsPerson1.ThirdName = "";
            this.ctrlPersonFilter1.Person = clsPerson1;
            this.ctrlPersonFilter1.Size = new System.Drawing.Size(597, 68);
            this.ctrlPersonFilter1.TabIndex = 0;
            this.ctrlPersonFilter1.PersonFoundOnSearch += new System.EventHandler(this.ctrlPersonFilter1_PersonFoundOnSearch);
            this.ctrlPersonFilter1.PersonNotFoundOnSearch += new System.EventHandler(this.ctrlPersonFilter1_PersonNotFoundOnSearch);
            this.ctrlPersonFilter1.PersonAdded += new System.EventHandler(this.ctrlPersonFilter1_PersonAdded);
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(-4, 168);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            clsPerson2.Address = "";
            clsPerson2.DateOfBirth = new System.DateTime(2007, 3, 17, 0, 0, 0, 0);
            clsPerson2.Email = "";
            clsPerson2.FirstName = "";
            clsPerson2.Gendor = ((byte)(2));
            clsPerson2.ImagePath = "";
            clsPerson2.LastName = "";
            clsPerson2.NationalityCountryID = -1;
            clsPerson2.NationalNo = "";
            clsPerson2.PersonID = -1;
            clsPerson2.Phone = "";
            clsPerson2.SecondName = "";
            clsPerson2.ThirdName = "";
            this.ctrlPersonDetails1.Person = clsPerson2;
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(1030, 566);
            this.ctrlPersonDetails1.TabIndex = 1;
            this.ctrlPersonDetails1.InfoEdited += new System.EventHandler(this.ctrlPersonDetails1_InfoEdited);
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.SystemColors.Control;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::DVLD_System_Version2.Properties.Resources.arrow_right2;
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(978, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 2;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(83, 158);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(867, 16);
            this.guna2Separator1.TabIndex = 2;
            // 
            // tpUserDetails
            // 
            this.tpUserDetails.Controls.Add(this.chbIsActive);
            this.tpUserDetails.Controls.Add(this.lblTitle2);
            this.tpUserDetails.Controls.Add(this.btnAddUser);
            this.tpUserDetails.Controls.Add(this.tbConfirmPassword);
            this.tpUserDetails.Controls.Add(this.tbPassword);
            this.tpUserDetails.Controls.Add(this.ulblConfirmPassword);
            this.tpUserDetails.Controls.Add(this.ulblPassword);
            this.tpUserDetails.Controls.Add(this.ulblUserName);
            this.tpUserDetails.Controls.Add(this.tbUserName);
            this.tpUserDetails.Controls.Add(this.lblID);
            this.tpUserDetails.Controls.Add(this.ulblID);
            this.tpUserDetails.Controls.Add(this.btnPrevious);
            this.tpUserDetails.Location = new System.Drawing.Point(4, 22);
            this.tpUserDetails.Name = "tpUserDetails";
            this.tpUserDetails.Size = new System.Drawing.Size(1040, 734);
            this.tpUserDetails.TabIndex = 2;
            this.tpUserDetails.Text = "UserDetails";
            this.tpUserDetails.UseVisualStyleBackColor = true;
            // 
            // chbIsActive
            // 
            this.chbIsActive.Animated = true;
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckedState.BorderRadius = 6;
            this.chbIsActive.CheckedState.BorderThickness = 0;
            this.chbIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chbIsActive.Location = new System.Drawing.Point(212, 404);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(71, 25);
            this.chbIsActive.TabIndex = 17;
            this.chbIsActive.Text = "Active";
            this.chbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.chbIsActive.UncheckedState.BorderRadius = 6;
            this.chbIsActive.UncheckedState.BorderThickness = 0;
            this.chbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.lblTitle2.Location = new System.Drawing.Point(365, 6);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(202, 42);
            this.lblTitle2.TabIndex = 16;
            this.lblTitle2.TabStop = false;
            this.lblTitle2.Text = "Add New User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Animated = true;
            this.btnAddUser.AnimatedGIF = true;
            this.btnAddUser.AutoRoundedCorners = true;
            this.btnAddUser.BorderRadius = 22;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(826, 516);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(146, 47);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Save";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Animated = true;
            this.tbConfirmPassword.AutoRoundedCorners = true;
            this.tbConfirmPassword.BorderRadius = 17;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(198, 339);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.PlaceholderText = "";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.tbConfirmPassword.TabIndex = 6;
            this.tbConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbConfirmPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.AutoRoundedCorners = true;
            this.tbPassword.BorderRadius = 17;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(198, 262);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(200, 36);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // ulblConfirmPassword
            // 
            this.ulblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.ulblConfirmPassword.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulblConfirmPassword.Location = new System.Drawing.Point(8, 344);
            this.ulblConfirmPassword.Name = "ulblConfirmPassword";
            this.ulblConfirmPassword.Size = new System.Drawing.Size(168, 26);
            this.ulblConfirmPassword.TabIndex = 10;
            this.ulblConfirmPassword.TabStop = false;
            this.ulblConfirmPassword.Text = "Confirm Password :";
            // 
            // ulblPassword
            // 
            this.ulblPassword.BackColor = System.Drawing.Color.Transparent;
            this.ulblPassword.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulblPassword.Location = new System.Drawing.Point(8, 267);
            this.ulblPassword.Name = "ulblPassword";
            this.ulblPassword.Size = new System.Drawing.Size(96, 26);
            this.ulblPassword.TabIndex = 9;
            this.ulblPassword.TabStop = false;
            this.ulblPassword.Text = "Password :";
            // 
            // ulblUserName
            // 
            this.ulblUserName.BackColor = System.Drawing.Color.Transparent;
            this.ulblUserName.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulblUserName.Location = new System.Drawing.Point(3, 190);
            this.ulblUserName.Name = "ulblUserName";
            this.ulblUserName.Size = new System.Drawing.Size(101, 26);
            this.ulblUserName.TabIndex = 8;
            this.ulblUserName.TabStop = false;
            this.ulblUserName.Text = "UserName :";
            // 
            // tbUserName
            // 
            this.tbUserName.Animated = true;
            this.tbUserName.AutoRoundedCorners = true;
            this.tbUserName.BorderRadius = 17;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.DefaultText = "";
            this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUserName.Location = new System.Drawing.Point(198, 185);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.PasswordChar = '\0';
            this.tbUserName.PlaceholderText = "";
            this.tbUserName.SelectedText = "";
            this.tbUserName.Size = new System.Drawing.Size(200, 36);
            this.tbUserName.TabIndex = 4;
            this.tbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserName_KeyPress);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(72, 102);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 26);
            this.lblID.TabIndex = 6;
            this.lblID.TabStop = false;
            this.lblID.Text = "[????]";
            // 
            // ulblID
            // 
            this.ulblID.BackColor = System.Drawing.Color.Transparent;
            this.ulblID.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulblID.Location = new System.Drawing.Point(8, 102);
            this.ulblID.Name = "ulblID";
            this.ulblID.Size = new System.Drawing.Size(33, 26);
            this.ulblID.TabIndex = 5;
            this.ulblID.TabStop = false;
            this.ulblID.Text = "ID :";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Animated = true;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.SystemColors.Control;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::DVLD_System_Version2.Properties.Resources.arrow_left2;
            this.btnPrevious.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrevious.Size = new System.Drawing.Size(60, 60);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 760);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddOrEditUser";
            this.Text = "Add Or Edit User";
            this.Load += new System.EventHandler(this.frmAddOrEditUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonDetails.ResumeLayout(false);
            this.tpPersonDetails.PerformLayout();
            this.tpUserDetails.ResumeLayout(false);
            this.tpUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonDetails;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TabPage tpUserDetails;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblUserName;
        private Guna.UI2.WinForms.Guna2TextBox tbUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblID;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrevious;
        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlPersonFilter ctrlPersonFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle1;
        private Guna.UI2.WinForms.Guna2CheckBox chbIsActive;
    }
}