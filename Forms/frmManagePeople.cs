using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD_System_Version2
{

    public partial class frmManagePeople : Form
    {
        Exception exception = null;


        public frmManagePeople()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// Update users information.
        /// </summary>
        public void RefreshInfo()
        {
            dgvPeople.DataSource = clsPerson.GetAllPeople(ref exception);
            clsMyWFL.DealWithException(ref exception);
            lblRecordsNum.Text = dgvPeople.Rows.Count.ToString();
            clsMyWFL.ChangeDataGridViewColumnsLayout(dgvPeople,DataGridViewAutoSizeColumnMode.AllCells);

        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbCountries.SelectedIndex = -1;

            switch(cbFilter.SelectedItem)
            {
                case "None":
                    tbFilter.Visible = false;
                    rbFemale.Visible = false;
                    rbMale.Visible = false;
                    cbCountries.Visible = false;
                    break;
                case "Nationality":
                    cbCountries.Visible = true;
                    tbFilter.Visible = false;
                    rbFemale.Visible = false;
                    rbMale.Visible = false;
                    cbCountries.Focus();
                    break;
                case "Gender":
                    cbCountries.Visible = false;
                    tbFilter.Visible = false;
                    rbFemale.Visible = true;
                    rbMale.Visible =   true;
                    break;
                default:
                    cbCountries.Visible = false;
                    tbFilter.Visible = true;
                    rbFemale.Visible = false;
                    rbMale.Visible = false;
                    tbFilter.Focus();
                    break;
            }
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }
        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountries.SelectedIndex == -1) (dgvPeople.DataSource as DataTable).DefaultView.RowFilter
                = string.Empty; 
            else(dgvPeople.DataSource as DataTable).DefaultView.RowFilter 
                = $"Nationality = '{cbCountries.SelectedItem}'";
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem == "None" || cbFilter.SelectedItem == "Gender" || cbFilter.SelectedItem == "Nationality")
            { return; }
            else if (cbFilter.SelectedItem == "PersonID" || cbFilter.SelectedItem == "Phone")
            { if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; }
            else if (cbFilter.SelectedItem == "NationalNo")
            { if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; }
            else if (cbFilter.SelectedItem == "Email")
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '_'
                     && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != '@') e.Handled = true;
            }
            else
            { if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true; }
        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFilter.Text))
                (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            else
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter =
                $"CONVERT({cbFilter.SelectedItem},System.String) LIKE '%{tbFilter.Text}%'";
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = "Gendor = 'Male'";
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = "Gendor = 'Female'";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmManagePeople_Resize(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(ulblManagePeople, this);
        }








        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(ulblManagePeople, this);
            clsMyWFL.FillComboBoxFromDataTable(cbCountries,clsCountry.GetAllCountries(ref exception),"CountryName");
            clsMyWFL.DealWithException(ref exception);
            RefreshInfo();

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            clsMyWFL.IncreaseDataGridViewFontSize(dgvPeople, 2);

        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            clsMyWFL.DecreaseDataGridViewFontSize(dgvPeople, 2);

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frmAddOrEditPerson = new frmAddOrEditPerson();
            frmAddOrEditPerson.ShowDialog();
            if (frmAddOrEditPerson.Person.PersonID != -1)
            {
                RefreshInfo();
            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmPersonDetails frmPersonDetails = new frmPersonDetails(
                clsPerson.Find(int.Parse(dgvPeople.SelectedCells[0].Value.ToString()), ref exception));
            clsMyWFL.DealWithException(ref exception);
            frmPersonDetails.ShowDialog();
            RefreshInfo();

        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frmAddOrEditPerson = new frmAddOrEditPerson
                (clsPerson.Find(int.Parse(dgvPeople.SelectedCells[0].Value.ToString()), ref exception));
            clsMyWFL.DealWithException(ref exception);
            frmAddOrEditPerson.ShowDialog();
            RefreshInfo();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            clsPerson.DeletePerson(int.Parse(dgvPeople.SelectedCells[0].Value.ToString()),ref exception);
            clsMyWFL.DealWithException(ref exception);
            RefreshInfo();
        }

    }
}
