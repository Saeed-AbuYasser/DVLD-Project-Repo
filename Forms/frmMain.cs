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
    /// 
    /// </summary>
    public partial class frmMain : Form
    {
        private bool _DragingMode = false;
        private Point _StartPoint = Point.Empty;
        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                _DragingMode = true;
                _StartPoint = new Point(e.X, e.Y);
            }
        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_DragingMode == true)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(newPoint.X - _StartPoint.X,newPoint.Y - _StartPoint.Y);
            }
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _DragingMode = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public frmMain(clsUser User)
        {

            InitializeComponent();
            this.User = User.Clone();
        }
        static private clsUser _User = new clsUser();
        public clsUser User
        {
            get
            {
                return _User;
            }
            set
            {
                if(_User.UserID != value.UserID)
                {
                    _User.UserID = value.UserID;

                }
                if (_User.UserName != value.UserName)
                {
                    _User.UserName = value.UserName;
                }
                if (_User.Password != value.Password)
                {
                    _User.Password = value.Password;
                }
                if (_User.IsActive != value.IsActive)
                {
                    _User.IsActive = value.IsActive;
                }
                if (!_User.PersonInfo.Equals(value.PersonInfo))
                {
                    _User.PersonInfo = value.PersonInfo;
                }
                if(_User.Mode != value.Mode)
                {
                    _User.Mode = value.Mode;
                }
            }
        }
        public event EventHandler<clsUser> LogInInfoChanged;
        protected virtual void LogInInfo_Changed(object sender, clsUser User)
        {
            EventHandler<clsUser> handler = LogInInfoChanged;
            handler?.Invoke(sender, User);
        }
        frmManagePeople frmManagePeople = new frmManagePeople();
        frmManageUsers frmManageUsers = new frmManageUsers();
        frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes();
        frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
        //frmManageApplications frmManageApplications = new frmManageApplications();
        private void frmMain_Load(object sender, EventArgs e)
        {

            frmManagePeople.MdiParent = this;
            frmManageUsers.MdiParent = this;
            frmManageApplicationTypes.MdiParent = this;
            frmManageTestTypes.MdiParent = this;
            //frmManageApplications.MdiParent = this;

            pnlWindows.Controls.Add(frmManagePeople);
            pnlWindows.Controls.Add(frmManageUsers);
            pnlWindows.Controls.Add(frmManageApplicationTypes);
            pnlWindows.Controls.Add(frmManageTestTypes);
            //pnlWindows.Controls.Add(frmManageApplications);

            frmManageUsers.UserLogInInfoChanged += (object sender1, clsUser User1) =>
            {
                if (this.User.UserID == User1.UserID)
                    LogInInfo_Changed(sender1, User1);
            };
        }
        private void tsmPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople.Visible = !frmManagePeople.Visible;
            frmManageUsers.Visible = false;
            frmManageApplicationTypes.Visible = false;
            frmManageTestTypes.Visible = false;
            //frmManageApplications.Visible = false;
        }

        private void tsmUsers_Click(object sender, EventArgs e)
        {
            frmManagePeople.Visible = false;
            frmManageUsers.Visible = !frmManageUsers.Visible;
            frmManageApplicationTypes.Visible = false;
            frmManageTestTypes.Visible = false;
            //frmManageApplications.Visible = false;
        }


        private void tsmApplications_Click(object sender, EventArgs e)
        {/*
            frmManagePeople.Visible = false;
            frmManageUsers.Visible = false;
            frmManageApplicationTypes.Visible = false;
            //frmManageApplications.Visible = !frmManageApplications.Visible;*/
        }
        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes.Visible = !frmManageApplicationTypes.Visible;
            frmManagePeople.Visible = false;
            frmManageUsers.Visible = false;
            frmManageTestTypes.Visible = false;
            //frmManageApplications.Visible = false;
        }
        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes.Visible = !frmManageTestTypes.Visible;
            frmManageApplicationTypes.Visible = false;
            frmManagePeople.Visible = false;
            frmManageUsers.Visible = false;
            //frmManageApplications.Visible = false;
        }

        private void tsmDrivers_Click(object sender, EventArgs e)
        {
            frmManagePeople.Visible = false;
            frmManageUsers.Visible = false;
            frmManageApplicationTypes.Visible = false;
            frmManageTestTypes.Visible = false;
            //frmManageApplications.Visible = !frmManageApplications.Visible;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }


        private void frmMain_Resize(object sender, EventArgs e)
        {
            frmManagePeople.WindowState = FormWindowState.Minimized;
            frmManageUsers.WindowState = FormWindowState.Minimized;
            frmManageApplicationTypes.WindowState = FormWindowState.Minimized;
            frmManageTestTypes.WindowState = FormWindowState.Minimized;
            //frmManageApplications.WindowState = FormWindowState.Minimized;

            frmManagePeople.WindowState = FormWindowState.Maximized;
            frmManageUsers.WindowState = FormWindowState.Maximized;
            frmManageApplicationTypes.WindowState = FormWindowState.Maximized;
            frmManageTestTypes.WindowState = FormWindowState.Maximized;
            //frmManageApplications.WindowState = FormWindowState.Maximized;
        }


        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddOrEditUser frmAddOrEditUser = new frmAddOrEditUser(User);
            frmAddOrEditUser.UserLogInInfoChanged += (object sender1, clsUser User1) =>
            {
                LogInInfo_Changed(sender1, User1);
            };
            frmAddOrEditUser.ShowDialog();

        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Driving_License_Application form = new frm_Add_New_Driving_License_Application();
            form.ShowDialog();

        }
    }
}
