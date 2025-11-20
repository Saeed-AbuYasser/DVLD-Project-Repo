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
    public partial class frmManageApplicationTypes : Form
    {
        public frmManageApplicationTypes()
        {
            InitializeComponent();
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
        private void _RefreshInfo()
        {
            dgvAppTypes.DataSource = clsApplicationType.GetAllApplicationTypes(exception);
            lblRecordsNum.Text = dgvAppTypes.Rows.Count.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmEditApplicationType_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvAppTypes.SelectedCells[0].Value;
            string Title = dgvAppTypes.SelectedCells[1].Value.ToString();
            float Fees = float.Parse(dgvAppTypes.SelectedCells[2].Value.ToString());
            frmEditApplicationType frm = new frmEditApplicationType(ID,Title,Fees);
            frm.ShowDialog();
            _RefreshInfo();
        }

        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(lblTitle,this);
            _RefreshInfo();
        }

        private void frmManageApplicationTypes_Resize(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(lblTitle, this);
        }

    }
}
