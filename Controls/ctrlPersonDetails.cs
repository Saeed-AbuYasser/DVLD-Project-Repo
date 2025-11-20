using DVLD_Business;
using DVLD_System_Version2.Properties;
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

    public partial class ctrlPersonDetails : UserControl
    {
        public ctrlPersonDetails()
        {
            InitializeComponent();
        }
        Exception exception = null;
        clsPerson _Person  = new clsPerson();
        /// <summary>
        /// Any changes applied to this instance it will be applied to the UI form.
        /// </summary>
        public clsPerson Person
        {
            get { return _Person; }
            set
            {
                if(lblPersonID.Text != value.PersonID.ToString())
                {
                    _Person.PersonID = value.PersonID;
                    lblPersonID.Text = value.PersonID == -1?"???":value.PersonID.ToString();
                    llblEditInfo.Visible = Person.PersonID != -1;
                }
                if (lblNationalNo.Text != value.NationalNo)
                {
                    _Person.NationalNo = value.NationalNo;
                    lblNationalNo.Text = value.NationalNo == "" ? "???" : value.NationalNo;
                }
                if (lblName.Text != value.FullName)
                {
                    _Person.FirstName = value.FirstName;
                    _Person.SecondName = value.SecondName;
                    _Person.ThirdName = value.ThirdName;
                    _Person.LastName = value.LastName;

                    lblName.Text = string.IsNullOrEmpty(value.FullName)?"???" : value.FullName;
                }
                if (lblDOB.Text != value.DateOfBirth.ToShortDateString())
                {
                    _Person.DateOfBirth = value.DateOfBirth;
                    lblDOB.Text = (value.PersonID == -1 && value.NationalNo == "") ? "???" : value.DateOfBirth.ToShortDateString();
                }
                if (lblEmail.Text != value.Email)
                {
                    _Person.Email = value.Email;
                    lblEmail.Text = string.IsNullOrEmpty(value.Email)?"???" : value.Email;
                }
                if (lblPhone.Text != value.Phone)
                {
                    _Person.Phone = value.Phone;
                    lblPhone.Text = string.IsNullOrEmpty(value.Phone)?"???" : value.Phone;
                }
                if (lblAddress.Text != value.Address)
                {
                    _Person.Address = value.Address;
                    lblAddress.Text = string.IsNullOrEmpty(value.Address)?"???" : value.Address;
                }
                if(lblCountry.Text != value.CountryInfo.CountryName)
                {
                    _Person.NationalityCountryID = value.NationalityCountryID;
                    lblCountry.Text = value.NationalityCountryID == -1?"???":value.CountryInfo.CountryName;
                }
                if((pbPersonImage.ImageLocation != value.ImagePath) &&
                    !(string.IsNullOrEmpty(pbPersonImage.ImageLocation) && string.IsNullOrEmpty(value.ImagePath)))
                {
                    _Person.ImagePath = value.ImagePath;
                    if (string.IsNullOrEmpty(value.ImagePath))
                    {
                        pbPersonImage.ImageLocation = string.Empty;
                        pbPersonImage.Image = null;

                        pbPersonImage.BackgroundImage =
                            (value.Gendor == 0 ? Resources.administrator : value.Gendor == 1 ? Resources.person_woman_young : null);

                    }
                    else
                    {
                        pbPersonImage.BackgroundImage = null;
                        pbPersonImage.ImageLocation = value.ImagePath;
                    }
                }
                if (lblGendor.Text != (value.Gendor == 0?"Male":value.Gendor == 1?"Female":"???"))
                {
                    _Person.Gendor = value.Gendor;
                    lblGendor.Text = (value.Gendor == 0 ? "Male" : value.Gendor == 1 ? "Female" : "???");
                    pbGendor.Image = 
                        (value.Gendor == 0 ? Resources.administrator : value.Gendor == 1 ? Resources.person_woman_young : Resources.user);
                    if (pbPersonImage.Image == null)
                        pbPersonImage.BackgroundImage = (value.Gendor == 0 ? Resources.administrator : value.Gendor == 1 ? Resources.person_woman_young : null);
                    else
                        pbPersonImage.BackgroundImage = null;

                }
                if (_Person.Mode != value.Mode)
                {
                    _Person.Mode = value.Mode;
                }
            }
        }
        public event EventHandler InfoEdited;
        protected virtual void Info_Edited(object sender,EventArgs e)
        {
            EventHandler Handler = InfoEdited;
            if(Handler != null)
            {
                Handler(sender, e);
            }
        }

        private void ctrlPersonDetails_Load(object sender, EventArgs e)
        {

            llblEditInfo.Visible = Person.PersonID != -1;
            if (pbPersonImage.Image == null)
                pbPersonImage.BackgroundImage =
                                (Person.Gendor == 0 ? Resources.administrator : Person.Gendor == 1 ? Resources.person_woman_young : null);
            pbGendor.Image =
                        (Person.Gendor == 0 ? Resources.administrator : Person.Gendor == 1 ? Resources.person_woman_young : Resources.user);
        }

        private void llblEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddOrEditPerson frmAddOrEditPerson = new frmAddOrEditPerson(_Person.Clone());
            frmAddOrEditPerson.ShowDialog();
            if (!Person.Equals(frmAddOrEditPerson.Person))
            {
                Person = frmAddOrEditPerson.Person;
                Info_Edited(sender, e);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
                ParentForm.Close();
        }
    }
}
