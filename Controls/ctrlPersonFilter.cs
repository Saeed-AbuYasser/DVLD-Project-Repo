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
    /// <summary>
    /// Preview person information.
    /// </summary>
    public partial class ctrlPersonFilter : UserControl
    {
        /// <summary>
        /// Initialize a new empty instance of object ctrlPersonFilterV2.
        /// </summary>
        public ctrlPersonFilter()
        {
            InitializeComponent();
        }
        clsPerson _Person = new clsPerson();
        public clsPerson Person
        {
            get
            {
                return _Person;
            }
            set
            {
                if(value.PersonID != _Person.PersonID)
                {
                    if (cbFilter.SelectedItem == "PersonID")
                    {
                        if (value.PersonID != -1)
                            tbFilter.Text = value.PersonID.ToString();
                    }
                        _Person.PersonID = value.PersonID;
                }
                if(value.NationalNo != _Person.NationalNo)
                {
                    if(cbFilter.SelectedItem == "NationalNo")
                    {
                        if (value.NationalNo != "-1")
                            tbFilter.Text = value.NationalNo;

                    }
                    _Person.NationalNo = value.NationalNo;
                }
                if(value.FullName != _Person.FullName)
                {
                    _Person.FirstName = value.FirstName;
                    _Person.SecondName = value.SecondName;
                    _Person.ThirdName = value.ThirdName;
                    _Person.LastName = value.LastName;
                }
                if(value.NationalityCountryID != _Person.NationalityCountryID)
                {
                    _Person.NationalityCountryID = value.NationalityCountryID;
                }
                if(value.Email != _Person.Email)
                {
                    _Person.Email = value.Email;
                }
                if(value.Phone != _Person.Phone)
                {
                    _Person.Phone = value.Phone;
                }
                if(value.Address != _Person.Address)
                {
                    _Person.Address = value.Address;
                }
                if(value.DateOfBirth != _Person.DateOfBirth)
                {
                    _Person.DateOfBirth = value.DateOfBirth;
                }
                if(value.Gendor != _Person.Gendor)
                {
                    _Person.Gendor = value.Gendor;
                }
                if(value.ImagePath != _Person.ImagePath)
                {
                    _Person.ImagePath = value.ImagePath;
                }
                if(value.Mode != _Person.Mode)
                {
                    _Person.Mode = value.Mode;
                }
            }
        }
        private Exception exception  = null;
        public event EventHandler PersonFoundOnSearch;
        public event EventHandler PersonNotFoundOnSearch;
        public event EventHandler PersonAdded;
        protected virtual void Person_Found_OnSearch(object sender, EventArgs e)
        {
            EventHandler handler = PersonFoundOnSearch;
            if(handler != null)
            {
                handler(sender, e);
            }
        }
        protected virtual void Person_NotFound_OnSearch(object sender, EventArgs e)
        {
            EventHandler handler = PersonNotFoundOnSearch;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
        protected virtual void Person_Added(object sender, EventArgs e)
        {
            EventHandler handler = PersonAdded;
            if (handler != null)
            {
                handler(sender, e);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch(cbFilter.SelectedItem)
            {
                case "PersonID":
                    _Person = clsPerson.Find(int.Parse(tbFilter.Text), ref exception);
                    clsMyWFL.DealWithException(ref exception);
                    break;
                case "NationalNo":
                    _Person = clsPerson.Find(tbFilter.Text, ref exception);
                    clsMyWFL.DealWithException(ref exception);
                    break;
            }
            //if(clsUser.isUserExistForPersonID(_Person.PersonID,ref exception))
            //{
            //    MessageBox.Show("this person is already a user!","User Exists!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    Person = new clsPerson();
            //}

            clsMyWFL.DealWithException(ref exception);
            if (Person.PersonID == -1) Person_NotFound_OnSearch(sender, e); else Person_Found_OnSearch(sender, e);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilter.SelectedItem)
            {
                case "PersonID":
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
                    break;
                case "NationalNo":
                    if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrEditPerson frmAddOrEditPerson = new frmAddOrEditPerson();
            frmAddOrEditPerson.ShowDialog();
            if(frmAddOrEditPerson.Person.PersonID != -1)
            {
                this.Person = frmAddOrEditPerson.Person;
                Person_Added(sender, e);
            }

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.Person.PersonID != -1)
            {
                tbFilter.Text = cbFilter.SelectedItem == "PersonID" ? Person.PersonID.ToString() : Person.NationalNo;
            }
        }
    }
}
