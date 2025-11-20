namespace DVLD_System_Version2
{
    partial class frmManageApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulblRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRecordsNum = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvAppTypes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsTypesOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upnlClose = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppTypes)).BeginInit();
            this.cmsTypesOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.upnlClose.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.lblTitle.Location = new System.Drawing.Point(410, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TabStop = false;
            this.lblTitle.Text = "Manage Application Types System";
            // 
            // ulblRecords
            // 
            this.ulblRecords.BackColor = System.Drawing.Color.Transparent;
            this.ulblRecords.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.ulblRecords.Location = new System.Drawing.Point(3, 3);
            this.ulblRecords.Name = "ulblRecords";
            this.ulblRecords.Size = new System.Drawing.Size(116, 31);
            this.ulblRecords.TabIndex = 1;
            this.ulblRecords.TabStop = false;
            this.ulblRecords.Text = "# Records:";
            // 
            // lblRecordsNum
            // 
            this.lblRecordsNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsNum.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.lblRecordsNum.Location = new System.Drawing.Point(138, 3);
            this.lblRecordsNum.Name = "lblRecordsNum";
            this.lblRecordsNum.Size = new System.Drawing.Size(30, 31);
            this.lblRecordsNum.TabIndex = 2;
            this.lblRecordsNum.TabStop = false;
            this.lblRecordsNum.Text = "???";
            // 
            // dgvAppTypes
            // 
            this.dgvAppTypes.AllowUserToAddRows = false;
            this.dgvAppTypes.AllowUserToDeleteRows = false;
            this.dgvAppTypes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAppTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAppTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppTypes.ColumnHeadersHeight = 20;
            this.dgvAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppTypes.ContextMenuStrip = this.cmsTypesOptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppTypes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAppTypes.Location = new System.Drawing.Point(0, 152);
            this.dgvAppTypes.Name = "dgvAppTypes";
            this.dgvAppTypes.ReadOnly = true;
            this.dgvAppTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppTypes.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAppTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAppTypes.Size = new System.Drawing.Size(1385, 551);
            this.dgvAppTypes.TabIndex = 0;
            this.dgvAppTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvAppTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppTypes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppTypes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppTypes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAppTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvAppTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvAppTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAppTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAppTypes.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvAppTypes.ThemeStyle.ReadOnly = true;
            this.dgvAppTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvAppTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAppTypes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAppTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvAppTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsTypesOptions
            // 
            this.cmsTypesOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationType});
            this.cmsTypesOptions.Name = "cmsTypesOptions";
            this.cmsTypesOptions.Size = new System.Drawing.Size(219, 28);
            // 
            // tsmEditApplicationType
            // 
            this.tsmEditApplicationType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsmEditApplicationType.Name = "tsmEditApplicationType";
            this.tsmEditApplicationType.Size = new System.Drawing.Size(218, 24);
            this.tsmEditApplicationType.Text = "Edit Application Type";
            this.tsmEditApplicationType.Click += new System.EventHandler(this.tsmEditApplicationType_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upnlClose);
            this.panel1.Controls.Add(this.ulblRecords);
            this.panel1.Controls.Add(this.lblRecordsNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 703);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 58);
            this.panel1.TabIndex = 4;
            // 
            // upnlClose
            // 
            this.upnlClose.Controls.Add(this.btnClose);
            this.upnlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.upnlClose.Location = new System.Drawing.Point(1265, 0);
            this.upnlClose.Name = "upnlClose";
            this.upnlClose.Size = new System.Drawing.Size(120, 58);
            this.upnlClose.TabIndex = 6;
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
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 152);
            this.panel2.TabIndex = 5;
            // 
            // frmManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 761);
            this.Controls.Add(this.dgvAppTypes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageApplicationTypes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmManageApplicationTypes_Load);
            this.Resize += new System.EventHandler(this.frmManageApplicationTypes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppTypes)).EndInit();
            this.cmsTypesOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.upnlClose.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel ulblRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecordsNum;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsTypesOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationType;
        private Guna.UI2.WinForms.Guna2Panel upnlClose;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}