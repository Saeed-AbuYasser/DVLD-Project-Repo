namespace DVLD_System_Version2
{
    partial class frmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCall = new System.Windows.Forms.ToolStripMenuItem();
            this.upnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.rbInactive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbActive = new Guna.UI2.WinForms.Guna2RadioButton();
            this.upnlAdd = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZoomOut = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnZoomIn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ulblFilter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblManageUsers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.upnlbottom = new Guna.UI2.WinForms.Guna2Panel();
            this.upnlClose = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordsNum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.upnlTitle.SuspendLayout();
            this.upnlAdd.SuspendLayout();
            this.upnlbottom.SuspendLayout();
            this.upnlClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 20;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 159);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsers.Size = new System.Drawing.Size(1584, 539);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.TabStop = false;
            this.dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsers.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvUsers.ThemeStyle.ReadOnly = true;
            this.dgvUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsUsers
            // 
            this.cmsUsers.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.toolStripSeparator1,
            this.tsmAddNew,
            this.tsmEdit,
            this.tsmDelete,
            this.toolStripSeparator2,
            this.tsmSendEmail,
            this.tsmCall});
            this.cmsUsers.Name = "cmsPeople";
            this.cmsUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.ColorTable = null;
            this.cmsUsers.RenderStyle.RoundedEdges = true;
            this.cmsUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsers.Size = new System.Drawing.Size(217, 206);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(216, 28);
            this.tsmShowDetails.Text = "Show Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmAddNew
            // 
            this.tsmAddNew.Name = "tsmAddNew";
            this.tsmAddNew.Size = new System.Drawing.Size(216, 28);
            this.tsmAddNew.Text = "Add new _Person";
            this.tsmAddNew.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(216, 28);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(216, 28);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(216, 28);
            this.tsmSendEmail.Text = "Send Email";
            // 
            // tsmCall
            // 
            this.tsmCall.Name = "tsmCall";
            this.tsmCall.Size = new System.Drawing.Size(216, 28);
            this.tsmCall.Text = "Phone Call";
            // 
            // upnlTitle
            // 
            this.upnlTitle.Controls.Add(this.rbInactive);
            this.upnlTitle.Controls.Add(this.rbActive);
            this.upnlTitle.Controls.Add(this.upnlAdd);
            this.upnlTitle.Controls.Add(this.tbFilter);
            this.upnlTitle.Controls.Add(this.cbFilter);
            this.upnlTitle.Controls.Add(this.ulblFilter);
            this.upnlTitle.Controls.Add(this.ulblManageUsers);
            this.upnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.upnlTitle.Location = new System.Drawing.Point(0, 0);
            this.upnlTitle.Name = "upnlTitle";
            this.upnlTitle.Size = new System.Drawing.Size(1584, 159);
            this.upnlTitle.TabIndex = 2;
            // 
            // rbInactive
            // 
            this.rbInactive.Animated = true;
            this.rbInactive.AutoSize = true;
            this.rbInactive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactive.CheckedState.BorderThickness = 0;
            this.rbInactive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInactive.CheckedState.InnerOffset = -4;
            this.rbInactive.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.rbInactive.Location = new System.Drawing.Point(348, 125);
            this.rbInactive.Name = "rbInactive";
            this.rbInactive.Size = new System.Drawing.Size(92, 27);
            this.rbInactive.TabIndex = 3;
            this.rbInactive.TabStop = true;
            this.rbInactive.Text = "Inactive";
            this.rbInactive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInactive.UncheckedState.BorderThickness = 2;
            this.rbInactive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInactive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbInactive.Visible = false;
            this.rbInactive.CheckedChanged += new System.EventHandler(this.rbActivation_Changed);
            // 
            // rbActive
            // 
            this.rbActive.Animated = true;
            this.rbActive.AutoSize = true;
            this.rbActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActive.CheckedState.BorderThickness = 0;
            this.rbActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActive.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbActive.CheckedState.InnerOffset = -4;
            this.rbActive.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.rbActive.Location = new System.Drawing.Point(265, 125);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(79, 27);
            this.rbActive.TabIndex = 2;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbActive.UncheckedState.BorderThickness = 2;
            this.rbActive.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbActive.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbActive.Visible = false;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActivation_Changed);
            // 
            // upnlAdd
            // 
            this.upnlAdd.Controls.Add(this.btnZoomOut);
            this.upnlAdd.Controls.Add(this.btnZoomIn);
            this.upnlAdd.Controls.Add(this.btnAddUser);
            this.upnlAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.upnlAdd.Location = new System.Drawing.Point(1365, 0);
            this.upnlAdd.Name = "upnlAdd";
            this.upnlAdd.Size = new System.Drawing.Size(219, 159);
            this.upnlAdd.TabIndex = 0;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Animated = true;
            this.btnZoomOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnZoomOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZoomOut.FillColor = System.Drawing.Color.Silver;
            this.btnZoomOut.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnZoomOut.ForeColor = System.Drawing.Color.Black;
            this.btnZoomOut.Location = new System.Drawing.Point(77, 107);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnZoomOut.Size = new System.Drawing.Size(68, 45);
            this.btnZoomOut.TabIndex = 9;
            this.btnZoomOut.Text = "Zoom out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Animated = true;
            this.btnZoomIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnZoomIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZoomIn.FillColor = System.Drawing.Color.Silver;
            this.btnZoomIn.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnZoomIn.ForeColor = System.Drawing.Color.Black;
            this.btnZoomIn.Location = new System.Drawing.Point(3, 107);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnZoomIn.Size = new System.Drawing.Size(68, 45);
            this.btnZoomIn.TabIndex = 8;
            this.btnZoomIn.Text = "Zoom in";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Animated = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BackgroundImage = global::DVLD_System_Version2.Properties.Resources.person_man_Add;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddUser.BorderRadius = 5;
            this.btnAddUser.BorderThickness = 1;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.SystemColors.Control;
            this.btnAddUser.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Image = global::DVLD_System_Version2.Properties.Resources.person_man_Add1;
            this.btnAddUser.ImageSize = new System.Drawing.Size(52, 52);
            this.btnAddUser.Location = new System.Drawing.Point(164, 104);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(52, 52);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.BorderRadius = 5;
            this.tbFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilter.DefaultText = "";
            this.tbFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilter.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.tbFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilter.Location = new System.Drawing.Point(265, 120);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(6);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PasswordChar = '\0';
            this.tbFilter.PlaceholderText = "";
            this.tbFilter.SelectedText = "";
            this.tbFilter.Size = new System.Drawing.Size(199, 36);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.Visible = false;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 5;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Trebuchet MS", 13F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "UserName",
            "IsActive"});
            this.cbFilter.Location = new System.Drawing.Point(113, 120);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(143, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 0;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // ulblFilter
            // 
            this.ulblFilter.BackColor = System.Drawing.Color.Transparent;
            this.ulblFilter.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.ulblFilter.Location = new System.Drawing.Point(3, 123);
            this.ulblFilter.Name = "ulblFilter";
            this.ulblFilter.Size = new System.Drawing.Size(95, 31);
            this.ulblFilter.TabIndex = 4;
            this.ulblFilter.Text = "Filter By";
            // 
            // ulblManageUsers
            // 
            this.ulblManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.ulblManageUsers.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulblManageUsers.Location = new System.Drawing.Point(732, 22);
            this.ulblManageUsers.Name = "ulblManageUsers";
            this.ulblManageUsers.Size = new System.Drawing.Size(364, 42);
            this.ulblManageUsers.TabIndex = 0;
            this.ulblManageUsers.Text = "Users Managment System";
            // 
            // upnlbottom
            // 
            this.upnlbottom.Controls.Add(this.upnlClose);
            this.upnlbottom.Controls.Add(this.lblRecordsNum);
            this.upnlbottom.Controls.Add(this.ulblRecords);
            this.upnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.upnlbottom.Location = new System.Drawing.Point(0, 698);
            this.upnlbottom.Name = "upnlbottom";
            this.upnlbottom.Size = new System.Drawing.Size(1584, 63);
            this.upnlbottom.TabIndex = 3;
            // 
            // upnlClose
            // 
            this.upnlClose.Controls.Add(this.btnClose);
            this.upnlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.upnlClose.Location = new System.Drawing.Point(1464, 0);
            this.upnlClose.Name = "upnlClose";
            this.upnlClose.Size = new System.Drawing.Size(120, 63);
            this.upnlClose.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(3, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsNum
            // 
            this.lblRecordsNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsNum.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.lblRecordsNum.Location = new System.Drawing.Point(144, 14);
            this.lblRecordsNum.Name = "lblRecordsNum";
            this.lblRecordsNum.Size = new System.Drawing.Size(30, 31);
            this.lblRecordsNum.TabIndex = 2;
            this.lblRecordsNum.Text = "???";
            // 
            // ulblRecords
            // 
            this.ulblRecords.BackColor = System.Drawing.Color.Transparent;
            this.ulblRecords.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.ulblRecords.Location = new System.Drawing.Point(5, 14);
            this.ulblRecords.Name = "ulblRecords";
            this.ulblRecords.Size = new System.Drawing.Size(116, 31);
            this.ulblRecords.TabIndex = 1;
            this.ulblRecords.Text = "# Records:";
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.upnlTitle);
            this.Controls.Add(this.upnlbottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.upnlTitle.ResumeLayout(false);
            this.upnlTitle.PerformLayout();
            this.upnlAdd.ResumeLayout(false);
            this.upnlbottom.ResumeLayout(false);
            this.upnlbottom.PerformLayout();
            this.upnlClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Panel upnlTitle;
        private Guna.UI2.WinForms.Guna2RadioButton rbInactive;
        private Guna.UI2.WinForms.Guna2RadioButton rbActive;
        private Guna.UI2.WinForms.Guna2Panel upnlAdd;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblManageUsers;
        private Guna.UI2.WinForms.Guna2Panel upnlbottom;
        private Guna.UI2.WinForms.Guna2Panel upnlClose;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecordsNum;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblRecords;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmCall;
        private Guna.UI2.WinForms.Guna2CircleButton btnZoomIn;
        private Guna.UI2.WinForms.Guna2CircleButton btnZoomOut;
    }
}