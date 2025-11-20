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
    /// Adds or updates user info.
    /// </summary>
    public partial class frmAddOrEditUser : Form
    {

        public frmAddOrEditUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="User"></param>
        public frmAddOrEditUser(clsUser User)
        {
            InitializeComponent();
            this.User = User;


        }
        clsUser _User = new clsUser();
        /// <summary>
        /// Any changes will be applied to this instance it will affect the UI form.
        /// </summary>
        public clsUser User
        {
            get
            {
                return _User;
            }
            set
            {
                bool LogInInfoChanged = false;
                bool InfoChanged = !value.Equals(this.User);
                if(_User.UserID != value.UserID)
                {
                    _User.UserID = value.UserID;
                    lblID.Text = value.UserID == -1 ? "???" : value.UserID.ToString();
                }
                if (_User.UserName != value.UserName)
                {
                    _User.UserName = value.UserName;
                    tbUserName.Text = value.UserName;
                    LogInInfoChanged = true;
                }
                if (_User.Password != value.Password)
                {
                    _User.Password = value.Password;
                    tbPassword.Text = value.Password;
                    LogInInfoChanged = true;
                }
                if (_User.IsActive != value.IsActive)
                {
                    _User.IsActive = value.IsActive;
                    chbIsActive.Checked = value.IsActive;
                }
                if(_User.PersonInfo != value.PersonInfo)
                {
                    _User.PersonInfo = value.PersonInfo;
                    ctrlPersonDetails1.Person = value.PersonInfo;
                    ctrlPersonFilter1.Person = value.PersonInfo;
                }
                if(_User.Mode != value.Mode)
                {
                    _User.Mode = value.Mode;
                    if(value.Mode == clsUser.enMode.Update)
                    {
                        btnNext.Visible = true;
                        lblTitle1.Text = "Update User";
                        lblTitle2.Text = "Update User";
                        ctrlPersonFilter1.Enabled = false;
                    }
                    else
                    {
                        lblTitle1.Text = "Add New User";
                        lblTitle2.Text = "Add New User";
                        if(value.PersonInfo.PersonID == -1)
                        {
                            btnNext.Visible = false;
                        }
                    }

                }
                if(InfoChanged)UserInfo_Changed(this, User);
                if(LogInInfoChanged)UserLogInInfo_Changed(this, User);
            }
        }

        private Exception exception = null;
        public event EventHandler<clsUser> UserInfoChanged;
        public event EventHandler<clsUser> UserLogInInfoChanged;
        protected virtual void UserLogInInfo_Changed(object sender, clsUser User)
        {
            EventHandler<clsUser> Handler = UserLogInInfoChanged;
            if (Handler != null)
            {
                Handler?.Invoke(sender, User);
            }
        }

        protected virtual void UserInfo_Changed(object sender, clsUser User)
        {
            EventHandler<clsUser> Handler = UserInfoChanged;
            if(Handler != null)
            {
                Handler?.Invoke(sender, User);
            }
        }

        private void _LoadFormToUser()
        {
            User = new clsUser
            {
                PersonInfo = _User.PersonInfo,
                UserID = _User.UserID,
                Mode = _User.Mode,
                IsActive = chbIsActive.Checked,
                UserName = tbUserName.Text,
                Password = tbPassword.Text,
            };
        }
        private bool _IsInfoLogical()
        {
            bool IsInfoLogical = true;
            if(_User.Mode == clsUser.enMode.AddNew && clsUser.isUserExist(tbUserName.Text,ref exception)
                || (_User.Mode == clsUser.enMode.Update && tbUserName.Text != User.UserName
                && clsUser.isUserExist(tbUserName.Text, ref exception)))
            {
                clsMyWFL.DealWithException(ref exception);
                errorProvider1.SetError(tbUserName, "Username is already used!");
                IsInfoLogical = false;
            }
            else if(string.IsNullOrEmpty(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "this filed is mandatory!");
                IsInfoLogical = false;
            }
            if (tbPassword.Text.Length<4)
            {
                errorProvider1.SetError(tbPassword, "Password must be at least 4 characters!");
                IsInfoLogical = false;
            }
            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(tbConfirmPassword, "Password is not matched!");
                IsInfoLogical = false;
            }

            return IsInfoLogical;
        }
        private void frmAddOrEditUser_Load(object sender, EventArgs e)
        {
            clsMyWFL.CenterControlInParentHorizontally(lblTitle1,this);
            clsMyWFL.CenterControlInParentHorizontally(lblTitle2,this);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpUserDetails;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpPersonDetails;
        }

        private void ctrlPersonFilter1_PersonFoundOnSearch(object sender, EventArgs e)
        {
            if(clsUser.isUserExistForPersonID(ctrlPersonFilter1.Person.PersonID,ref exception))
            {
                MessageBox.Show("this person is already a user!", "User Exists!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ctrlPersonFilter1.Person = new clsPerson();
                btnNext.Visible = false;
                return;
            }
            ctrlPersonDetails1.Person = ctrlPersonFilter1.Person;
            _User.PersonInfo = ctrlPersonFilter1.Person;
            btnNext.Visible = true;
        }

        private void ctrlPersonFilter1_PersonNotFoundOnSearch(object sender, EventArgs e)
        {
            ctrlPersonDetails1.Person = new clsPerson();
            _User.PersonInfo = new clsPerson();
            btnNext.Visible = false;
        }

        private void ctrlPersonDetails1_InfoEdited(object sender, EventArgs e)
        {
            ctrlPersonFilter1.Person = ctrlPersonDetails1.Person;
            _User.PersonInfo = ctrlPersonDetails1.Person;
        }

        private void ctrlPersonFilter1_PersonAdded(object sender, EventArgs e)
        {
            ctrlPersonDetails1.Person = ctrlPersonFilter1.Person;
            _User.PersonInfo = ctrlPersonFilter1.Person;
        }

        private void tbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))||  tbUserName.Text.Length>35) e.Handled = true;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' '||tbUserName.Text.Length > 35) e.Handled = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!_IsInfoLogical()) return;

            _LoadFormToUser();
            if(User.Save(ref exception))
            {
                MessageBox.Show("User information saved successfully","User Saving",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            clsMyWFL.DealWithException(ref exception);

        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if(_User.Mode == clsUser.enMode.AddNew && clsUser.isUserExist(tbUserName.Text,ref exception))
            {
                errorProvider1.SetError(tbUserName, "Uesrname is already used!");
            }
            else if(_User.Mode == clsUser.enMode.Update && tbUserName.Text != User.UserName 
                && clsUser.isUserExist(tbUserName.Text, ref exception))
            {
                errorProvider1.SetError(tbUserName, "Uesrname is already used!");
            }
            else
            {
                errorProvider1.SetError(tbUserName, "");
            }
            clsMyWFL.DealWithException(ref exception);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length >= 4)
                errorProvider1.SetError(tbPassword, "");
            if (tbConfirmPassword.Text == tbPassword.Text)
                errorProvider1.SetError(tbConfirmPassword, "");
        }

    }
}
