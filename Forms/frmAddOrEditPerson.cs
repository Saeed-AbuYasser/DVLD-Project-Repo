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
    public partial class frmAddOrEditPerson : Form
    {
        private Exception exception = null;
        public clsPerson Person
        {
            get { return ctrlAddOrEditPerson1.Person; }
            set {  ctrlAddOrEditPerson1.Person = value;}
        }
        /// <summary>
        /// Any changes applied to instance values, it will be applied to UI form.
        /// </summary>

        public frmAddOrEditPerson()
        {
            InitializeComponent();
        }
        public frmAddOrEditPerson(clsPerson Person)
        {
            InitializeComponent();
            ctrlAddOrEditPerson1.Person = Person;

        }

        private void frmAddOrEditPerson_Load(object sender, EventArgs e)
        {
        }

        private void ctrlAddOrEditPerson1_Load(object sender, EventArgs e)
        {

        }

        private void frmAddOrEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
