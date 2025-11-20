using DVLD_Business;
using DVLD_System;
using DVLD_System_Version2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System_Version2
{


    public partial class ctrlAddOrEditPerson : UserControl
    {
        public event EventHandler InfoSaved;
        protected virtual void Info_Saved(object sender, EventArgs e)
        {
            EventHandler handler = InfoSaved;
            if (handler != null)
            {
                handler(sender, e);
            }
        }



        clsPerson _Person = new clsPerson();
        /// <summary>
        /// Any changes will be applied to this instance will change the UI form values.
        /// </summary>
        public clsPerson Person
        {
            get
            {
                return _Person.Clone();
            }
            set
            {
                if(value == null && value.PersonID == -1)
                {
                    _Person = new clsPerson();return;
                }
                if(lblID.Text != (value.PersonID == -1?"???": value.PersonID.ToString()))
                {

                    _Person.PersonID = value.PersonID;
                    lblID.Text = value.PersonID == -1? "???" : value.PersonID.ToString();
                }
                if (tbNationalNo.Text != value.NationalNo)
                {
                    _Person.NationalNo = value.NationalNo;
                    tbNationalNo.Text = value.NationalNo;
                }
                if (tbFirstName.Text != value.FirstName)
                {
                    _Person.FirstName = value.FirstName;
                    tbFirstName.Text = value.FirstName;
                }
                if (tbSecondName.Text != value.SecondName)
                {
                    _Person.SecondName = value.SecondName;
                    tbSecondName.Text = value.SecondName;
                }
                if (tbThirdName.Text != value.ThirdName)
                {
                    _Person.ThirdName = value.ThirdName;
                    tbThirdName.Text = value.ThirdName;
                }
                if (tbLastName.Text != value.LastName)
                {
                    _Person.LastName = value.LastName;
                    tbLastName.Text = value.LastName;
                }
                if (dtpDOT.Value != value.DateOfBirth)
                {
                    _Person.DateOfBirth = value.DateOfBirth;
                    dtpDOT.Value = value.DateOfBirth;
                }
                if (tbEmail.Text!= value.Email)
                {
                    _Person.Email = value.Email;
                    tbEmail.Text = value.Email;
                }
                if (tbPhone.Text != value.Phone)
                {
                    _Person.Phone = value.Phone;
                    tbPhone.Text = value.Phone;
                }
                if (tbAddress.Text != value.Address)
                {
                    _Person.Address = value.Address;
                    tbAddress.Text = value.Address;
                }
                if (cbCountries.SelectedItem != value.CountryInfo.CountryName)
                {
                    _Person.NationalityCountryID = value.NationalityCountryID;
                    if (value.NationalityCountryID == -1)
                        cbCountries.SelectedIndex = -1;
                    else
                        cbCountries.SelectedItem = value.CountryInfo.CountryName;
                }
                if (pbImage.ImageLocation != value.ImagePath)
                {
                    _Person.ImagePath = value.ImagePath;
                    if (string.IsNullOrEmpty(value.ImagePath))
                        pbImage.Image = null;
                    else
                        pbImage.ImageLocation = value.ImagePath;
                }
                if((value.Gendor == 0 && !rbMale.Checked) || (value.Gendor == 1 && !rbFemale.Checked))
                {
                    _Person.Gendor = value.Gendor;
                    if(value.Gendor == 0)rbMale.Checked = true;
                    else if (value.Gendor ==1) rbFemale.Checked = true;
                }
                else if (value.Gendor == 2)
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = false;
                }
                if((lblTitle.Text == "Add New Person" && value.Mode != clsPerson.enMode.AddNew) || (lblTitle.Text == "Update Person" && value.Mode != clsPerson.enMode.Update))
                {
                    _Person.Mode = value.Mode;
                    lblTitle.Text = value.Mode == clsPerson.enMode.Update ? "Update Person" : "Add New Person";
                }
            }
        }
        public ctrlAddOrEditPerson()
        {
            InitializeComponent();
        }
        private void _SavingImageHandler()
        {
            if (Person.ImagePath == (pbImage.ImageLocation==null?"": pbImage.ImageLocation)) return;

            if (!string.IsNullOrEmpty(Person.ImagePath))
            {
                File.Delete(Person.ImagePath);
            }
            if (pbImage.Image == null) return;
            string newLocation = frmLogIn.PhotoDirectoryName + "\\" + tbNationalNo.Text + 
                Guid.NewGuid().ToString() + "." + Path.GetExtension(pbImage.ImageLocation);

            File.Copy(pbImage.ImageLocation,newLocation);

            pbImage.ImageLocation = newLocation;
        }
        /*private void _LoadPersonInfoToForm()
        {
            if(Person != null && Person.PersonID != -1)
            {
                lblID.Text = Person.PersonID.ToString();
                tbFirstName.Text = Person.FirstName;
                tbSecondName.Text = Person.SecondName;
                tbThirdName.Text = Person.ThirdName;
                tbLastName.Text = Person.LastName;
                tbNationalNo.Text = Person.NationalNo;
                tbPhone.Text = Person.Phone;
                tbEmail.Text = Person.Email;
                tbAddress.Text = Person.Address;
                dtpDOT.Value = Person.DateOfBirth;
                cbCountries.SelectedItem = Person.CountryInfo.CountryName;
                clsMyWFL.DealWithException(ref exception);
                if(!string.IsNullOrEmpty(Person.ImagePath))
                    pbImage.ImageLocation = Person.ImagePath;
                else if(Person.Gendor == 0)
                    pbImage.BackgroundImage = Resources.administrator;
                else if(Person.Gendor == 1)
                    pbImage.BackgroundImage= Resources.person_woman_young;
                if(Person.Gendor == 0)rbMale.Checked = true;
                else rbFemale.Checked = true;
                lblTitle.Text = Person.Mode == clsPerson.enMode.AddNew ? "Add New Person" : "Update Person";
            }
        }*/
        private void _LoadFormInfoToPerson()
        {

            _Person.NationalNo = tbNationalNo.Text;
            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            _Person.ThirdName = tbThirdName.Text;
            _Person.LastName = tbLastName.Text;
            _Person.NationalityCountryID = clsCountry.Find(cbCountries.SelectedItem.ToString(), ref exception).ID;
            _Person.Email = tbEmail.Text;
            _Person.Address = tbAddress.Text;
            _Person.Phone = tbPhone.Text;
            _Person.Gendor = (byte)(rbMale.Checked?0:1);
            _Person.ImagePath = pbImage.Image == null ? string.Empty : pbImage.ImageLocation;
            _Person.DateOfBirth = dtpDOT.Value;



        }
        private Exception exception = null;
        private void _AcceptedCharsHandler()
        {
            tbFirstName.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
            };
            tbSecondName.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
            };
            tbThirdName.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
            };
            tbLastName.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.Handled = true;
            };

            tbNationalNo.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)) e.Handled = true;
            };
            tbPhone.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
            tbEmail.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)
                && e.KeyChar != '@' && e.KeyChar != '-' &&
                e.KeyChar != '_' && e.KeyChar != '.') e.Handled = true;
            };
            tbAddress.KeyPress += (object sender, KeyPressEventArgs e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)
                && e.KeyChar != ',' && e.KeyChar != '-' &&
                e.KeyChar != '_' && e.KeyChar != '.') e.Handled = true;
            };
        }
        private bool _IsInfoLogicalHandled()
        {

            bool IsAllDone = true;
            if (string.IsNullOrEmpty(tbNationalNo.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbNationalNo, "This filed is mandatory!");
            }
            else if(Person.NationalNo != tbNationalNo.Text && clsPerson.IsPersonExist(tbNationalNo.Text,ref exception))
            {
                IsAllDone = false;
            }
            clsMyWFL.DealWithException(ref exception);
            if (string.IsNullOrEmpty(tbFirstName.Text)) 
            {
                IsAllDone = false;
                errorProvider.SetError(tbFirstName, "This filed is mandatory!"); 
            }
            if (string.IsNullOrEmpty(tbSecondName.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbSecondName, "This filed is mandatory!");
            }
            if (string.IsNullOrEmpty(tbThirdName.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbThirdName, "This filed is mandatory!");
            }
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbLastName, "This filed is mandatory!");
            }
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbPhone, "This filed is mandatory!");
            }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                IsAllDone = false;
                errorProvider.SetError(tbAddress, "This filed is mandatory!");
            }
            //else if (!Regex.IsMatch(tbAddress.Text, ""))
            //{
            //    IsAllDone=false;
            //}
            if(!rbFemale.Checked && !rbMale.Checked)
            {
                IsAllDone = false;
                errorProvider.SetError(rbFemale, "No Specified Gender!");
            }
            //if(!string.IsNullOrEmpty(tbEmail.Text)&& !Regex.IsMatch(tbEmail.Text, ""))
            //{
            //    IsAllDone = false;
            //}
            return IsAllDone;
        }
        private void _FillCountriesIn_cbCountries_()
        {
            clsMyWFL.FillComboBoxFromDataTable(cbCountries, clsCountry.GetAllCountries(ref exception), "CountryName");
            clsMyWFL.DealWithException(ref exception);
            cbCountries.SelectedItem = "Syria";
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, "");
            if(pbImage.Image == null)
            {
                pbImage.BackgroundImage = rbFemale.Checked ?
                    Resources.person_woman_young : rbMale.Checked ? Resources.administrator : null;
            }
        }
        private void llblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(ofdImage.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = ofdImage.FileName;
                llblRemoveImage.Visible = true;
                pbImage.BackgroundImage = null;
            }
        }
        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pbImage.Image != null)
            {
                pbImage.Image = null;
            }
            llblRemoveImage.Visible = false;
            pbImage.BackgroundImage = rbMale.Checked ?
                Resources.administrator : rbFemale.Checked ? Resources.person_woman_young : null;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                ParentForm.Close();
            }
        }
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            lblEmailValidating.Visible = false;
        }
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            //lblEmailValidating.Visible = !Regex.IsMatch(tbEmail.Text, "");
        }
        private void tbAddress_Enter(object sender, EventArgs e)
        {
            lblAddressDescription.Visible = true;
            lblAddressWarning.Visible = false;
        }
        private void tbAddress_Leave(object sender, EventArgs e)
        {
            lblAddressDescription.Visible = false;
            //lblAddressWarning.Visible = !Regex.IsMatch(tbAddress.Text,"");
        }



        private void ctrlAddOrEditPerson_Load(object sender, EventArgs e)
        {
            dtpDOT.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);
            _AcceptedCharsHandler();
            _FillCountriesIn_cbCountries_();
            lblTitle.Text = Person.Mode == clsPerson.enMode.Update ? "Update Person" : "Add New Person";
            llblRemoveImage.Visible = pbImage.Image != null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsInfoLogicalHandled()) return;
            _SavingImageHandler();
            _LoadFormInfoToPerson();
            if (_Person.Save(ref exception))
            {
                Person = _Person;
                Info_Saved(sender, e);
            }
            clsMyWFL.DealWithException(ref exception);

        }
        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, "");
        }

        private void tbNationaNo_TextChanged(object sender, EventArgs e)
        {
            if (Person.NationalNo != tbNationalNo.Text && clsPerson.IsPersonExist(tbNationalNo.Text, ref exception))
                errorProvider.SetError(tbNationalNo, "NationalNo belong to another person!");
            else errorProvider.SetError(tbNationalNo, "");
        }
    }
}
