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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        Exception exception = null;
        private void _RefreshInfo()
        {
            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes(ref exception);
            clsMyWFL.DealWithException(ref exception);
            lblRecordsNum.Text = dgvTestTypes.Rows.Count.ToString();
        }
        private void tsmEditTestType_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvTestTypes.SelectedCells[0].Value;
            string Title = dgvTestTypes.SelectedCells[1].Value.ToString();
            string Description  = dgvTestTypes.SelectedCells[2].Value.ToString();
            float Fees = float.Parse(dgvTestTypes.SelectedCells[3].Value.ToString());
            frmEditTestType frm = new frmEditTestType(ID, Title,Description, Fees);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(lblTitle, this);
            _RefreshInfo();
        }

        private void frmManageTestTypes_Resize(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(lblTitle, this);
        }
    }
}
