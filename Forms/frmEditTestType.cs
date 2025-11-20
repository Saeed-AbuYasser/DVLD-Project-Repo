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
    public partial class frmEditTestType : Form
    {
        public frmEditTestType(int ID,string Title,string Description,float Fees)
        {
            InitializeComponent();
            lblID.Text = ID.ToString();
            tbTitle.Text = Title;
            tbDescription.Text = Description;
            tbFees.Text = Fees.ToString();

        }
        Exception exception = null;


        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || (e.KeyChar == '.' && tbFees.Text.IndexOf('.') == -1)) { }
            else e.Handled = true;

        }

        private void tbFees_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFees.Text))
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
            if(tbDescription.Text.Length == 0)
            {
                errorProvider1.SetError(tbFees, "This filed is mandatory!");
                AllDone = false;
            }
            if (AllDone)
            {
                if (clsTestType.UpdateTestType(int.Parse(lblID.Text), tbTitle.Text,tbDescription.Text, float.Parse(tbFees.Text), ref exception))
                {
                    MessageBox.Show("Test Type updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Test Type updating failed!", "Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clsMyWFL.DealWithException(ref exception);
            }
        }

        private void tbInfo_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text.Length > 0)
                errorProvider1.SetError(tbTitle, "");
            if (tbFees.Text.Length > 0)
                errorProvider1.SetError(tbFees, "");
            if (tbDescription.Text.Length > 0)
                errorProvider1.SetError(tbDescription, "");
        }
    }
}
