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
    public partial class frmEditApplicationType : Form
    {
        public frmEditApplicationType(int ID,string Title,float Fees)
        {
            InitializeComponent();
            lblID.Text = ID.ToString();
            tbTitle.Text = Title;
            tbFees.Text = Fees.ToString();

        }
        Exception _exception = null;
        Exception exception
        {
            get { return _exception; }
            set
            {
                if(value != null)
                {
                    _exception = value;
                    clsMyWFL.DealWithException(ref _exception);
                }
            }
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == '.' && tbFees.Text.IndexOf('.') == -1)) { }
            else e.Handled = true;

        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFees.Text))
            {
                tbFees.Text = "0";return;
            }
            if (float.Parse(tbFees.Text) > 214478) tbFees.Text = "214478";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool AllDone = true;
            if (tbTitle.Text.Length == 0)
            {
                errorProvider1.SetError(tbTitle, "This filed is mandatory!");
                AllDone = false;
            }
            if (tbFees.Text.Length == 0)
            {
                errorProvider1.SetError(tbFees, "This filed is mandatory!");
                AllDone = false;
            }
            if (AllDone)
            {
                if (clsApplicationType.UpdateApplicationType(int.Parse(lblID.Text), tbTitle.Text, float.Parse(tbFees.Text), exception))
                {
                    MessageBox.Show("Application Type updated successfully!", "Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Application Type updating failed!", "Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text.Length > 0)
                errorProvider1.SetError(tbTitle, "");
            if (tbFees.Text.Length > 0)
                errorProvider1.SetError(tbFees, "");
        }
    }
}
