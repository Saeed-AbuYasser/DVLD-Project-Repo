using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD_Business;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DVLD_System_Version2;
using Microsoft.Win32;

namespace DVLD_System
{
    public partial class frmLogIn : Form
    {
        frmMain frmMain = new frmMain(new clsUser());
        Exception exception = null;
        public static string PhotoDirectoryName = "C:\\DVLD-People-Images";
        public static string PasswordFileName = "Password.txt";
        public static string UserNameFileName = "UserName.txt";
        public static string LocalInfoDirectoryName = "C:\\DVLD-LocalDeviceLogInInfo";
        bool DidLogInBefor = false;

        private string _Password = "";
        private string _UserName = "";

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                tbPassword.Text = value;
            }
        }
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                tbUserName.Text = value;
            }
        }

        private void _TakeCareOfException()
        {
            if(exception != null)
            {
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                exception = null;
            }
        }
        //private void _TakeCareOfFiles()
        //{
        //    if (!Directory.Exists(PhotoDirectoryName))
        //    {
        //        try
        //        {
        //            Directory.CreateDirectory(PhotoDirectoryName);
        //            //FileStream PhotoFile = new FileStream(PhotoFileName, FileMode.CreateNew);
        //            //PhotoFile.Close();

        //        }
        //        catch(Exception ex) { MessageBox.Show(ex.Message); }
        //        finally { }
        //    }
        //    if (!Directory.Exists(LocalInfoDirectoryName))
        //    {
        //        Directory.CreateDirectory(LocalInfoDirectoryName);
        //    }
        //    if (!File.Exists(LocalInfoDirectoryName+"\\"+ PasswordFileName))
        //    {
        //        try
        //        {
        //            FileStream PasswordFile = new FileStream(LocalInfoDirectoryName + "\\" + PasswordFileName, FileMode.CreateNew);
        //            PasswordFile.Close();

        //        }
        //        catch (Exception ex) { MessageBox.Show(ex.Message); }

        //    }
        //    if (!File.Exists(LocalInfoDirectoryName + "\\" + UserNameFileName))
        //    {
        //        try
        //        {
        //            FileStream UserNameFile = new FileStream(LocalInfoDirectoryName + "\\" + UserNameFileName, FileMode.CreateNew);
        //            UserNameFile.Close();

        //        }
        //        catch (Exception ex) { MessageBox.Show(ex.Message); }

        //    }
        //}
        //private void _LoadPassword_UserNameFromFile()
        //{
        //    FileStream Passwordfile = new FileStream(LocalInfoDirectoryName + "\\" + PasswordFileName, FileMode.Open, FileAccess.Read);
        //    tbPassword.Text = File.ReadAllText(Passwordfile.Name);
        //    Passwordfile.Close();

        //    FileStream UserNamefile = new FileStream(LocalInfoDirectoryName + "\\" + UserNameFileName, FileMode.Open, FileAccess.Read);
        //    tbUserName.Text = File.ReadAllText(UserNamefile.Name);
        //    UserNamefile.Close();
        //}
        //private void _AddPassword_UserNameToFile(string UserName,string Password)
        //{
        //    File.WriteAllText(LocalInfoDirectoryName + "\\" + PasswordFileName, Password);

        //    File.WriteAllText(LocalInfoDirectoryName + "\\" + UserNameFileName, UserName);
        //}
        //private void _RemovePassword_UserNameFromFile()
        //{
        //    FileStream Passwordfile = new FileStream(LocalInfoDirectoryName + "\\" + PasswordFileName, FileMode.Open, FileAccess.Write);
        //    File.WriteAllText(Passwordfile.Name, "");
        //    Passwordfile.Close();

        //    FileStream UserNamefile = new FileStream(LocalInfoDirectoryName + "\\" + UserNameFileName, FileMode.Open, FileAccess.Write);
        //    File.WriteAllText(UserNamefile.Name, "");
        //    UserNamefile.Close();
        //}

        private void _ReadPassword_UserNameFromRegistry()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_System";
            string PasswordValueName = "Password";
            string UserNameValueName = "UserName";
            try
            {
                tbPassword.Text = Registry.GetValue(KeyPath, PasswordValueName, string.Empty) as string;
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {

                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                tbUserName.Text = Registry.GetValue(KeyPath, UserNameValueName, string.Empty) as string;
                if (!string.IsNullOrEmpty(tbUserName.Text))
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void _WritePassword_UserNameToRegistry(string UserName, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_System";
            string PasswordValueName = "Password";
            string UserNameValueName = "UserName";
            try
            {
                Registry.SetValue(KeyPath, PasswordValueName, Password);
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Registry.SetValue(KeyPath, UserNameValueName, UserName);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void _RemovePassword_UserNameFromRegistry()
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_System";
            string PasswordValueName = "Password";
            string UserNameValueName = "UserName";
            try
            {
                Registry.SetValue(KeyPath, PasswordValueName, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Registry.SetValue(KeyPath, UserNameValueName, string.Empty);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public frmLogIn()
        {
            InitializeComponent();
            this.VisibleChanged += (object sender, EventArgs e) => frmMain.Visible = !this.Visible;
            frmMain.VisibleChanged += (object sender, EventArgs e) => this.Visible = !frmMain.Visible;

        }   

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            //_TakeCareOfFiles();
            //_LoadPassword_UserNameFromFile();
            _ReadPassword_UserNameFromRegistry();
            frmMain.LogInInfoChanged += (object sender1, clsUser User) => 
            { 
                Password = User.Password;UserName = User.UserName; 
                _WritePassword_UserNameToRegistry(UserName,Password);
                //_AddPassword_UserNameToFile(UserName, Password);
            };

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.FindByUsernameAndPassword(tbUserName.Text, tbPassword.Text, ref exception);
            _TakeCareOfException();
            if (User.UserID == -1)
            {
                MessageBox.Show("Wrong UserName/Password!","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if(User.IsActive == false)
            {
                MessageBox.Show("User is deactivated!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmMain.User = User;
            if (chbRemeberMe.Checked)
            {
                //_AddPassword_UserNameToFile(tbUserName.Text,tbPassword.Text);
                _WritePassword_UserNameToRegistry(tbUserName.Text,tbPassword.Text);
                if (!DidLogInBefor)
                {
                    frmMain.FormClosing += (object sender1, FormClosingEventArgs e1) =>
                    {
                        //_AddPassword_UserNameToFile(frmMain.User.UserName, frmMain.User.Password);
                        _WritePassword_UserNameToRegistry(frmMain.User.UserName, frmMain.User.Password);
                        this.Close();
                    };
                    DidLogInBefor = true;
                }
            }
            else
            {
                //_RemovePassword_UserNameFromFile();
                _RemovePassword_UserNameFromRegistry();
            }
            this.Hide();
        }
    }
}
   