using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System_Version2
{
    public partial class frmManageUsers : Form
    {
        Exception exception = null;
        public frmManageUsers()
        {
            InitializeComponent();
        }
        public event EventHandler<clsUser> UserLogInInfoChanged;
        protected virtual void UserLogInInf_Changed(object sender,clsUser User)
        {
            EventHandler<clsUser> eventHandler = UserLogInInfoChanged;
            eventHandler?.Invoke(sender,User);
        }
        public void RefreshInfo()
        {
            dgvUsers.DataSource = clsUser.GetAllUsers(ref exception);
            clsMyWFL.DealWithException(ref exception);
            lblRecordsNum.Text = dgvUsers.Rows.Count.ToString();
            clsMyWFL.ChangeDataGridViewColumnsLayout(dgvUsers, DataGridViewAutoSizeColumnMode.AllCells);

        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            rbInactive.Checked = false;
            rbActive.Checked = false;

            switch(cbFilter.SelectedItem)
            {
                case "None":
                    tbFilter.Visible = false;
                    rbActive.Visible = false;
                    rbInactive.Visible = false;
                    break;
                case "IsActive":
                    tbFilter.Visible = false;
                    rbActive.Visible = true;
                    rbInactive.Visible = true;
                    break;
                default:
                    tbFilter.Visible = true;
                    rbActive.Visible = false;
                    rbInactive.Visible = false;
                    break;
            }
            (dgvUsers.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilter.SelectedItem)
            {
                case "None":
                    return;
                case "IsActive":
                    return;
                case "UserName":
                    if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '_') e.Handled = true;
                    break;
                default:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
                    break;

            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text))
                (dgvUsers.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            else (dgvUsers.DataSource as DataTable).DefaultView.RowFilter =
                $"CONVERT({cbFilter.SelectedItem},System.String) LIKE '%{tbFilter.Text}%'";
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            clsMyWFL.IncreaseDataGridViewFontSize(dgvUsers, 2);

        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            clsMyWFL.DecreaseDataGridViewFontSize(dgvUsers, 2);
        }

        private void rbActivation_Changed(object sender, EventArgs e)
        {
            (dgvUsers.DataSource as DataTable).DefaultView.RowFilter =
                rbActive.Checked ? "IsActive = true" :
                rbInactive.Checked ? "IsActive = false" :
                string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frmAddOrEditUser = new frmAddOrEditUser
                (clsUser.FindByUserID(int.Parse(dgvUsers.SelectedCells[0].Value.ToString()), ref exception));
            clsMyWFL.DealWithException(ref exception);
            frmAddOrEditUser.UserLogInInfoChanged += (object sender1, clsUser User1) =>
            {
                UserLogInInf_Changed(sender1, User1);
            };
            frmAddOrEditUser.ShowDialog();
            RefreshInfo();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frmAddOrEditUser = new frmAddOrEditUser();
            frmAddOrEditUser.UserLogInInfoChanged += (object sender1, clsUser User) =>
            {
                UserLogInInf_Changed(sender1,User);
            };
            frmAddOrEditUser.ShowDialog();
            RefreshInfo();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to delete ({dgvUsers.SelectedCells[2].Value.ToString()})?"
                ,"Confirming",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
                clsUser.DeleteUser(int.Parse(dgvUsers.SelectedCells[0].Value.ToString()),ref exception);
            MessageBox.Show("User deleted successfully","User Deleting",MessageBoxButtons.OK,MessageBoxIcon.Information);
            clsMyWFL.DealWithException(ref exception);
            RefreshInfo();
        }
    }
}
