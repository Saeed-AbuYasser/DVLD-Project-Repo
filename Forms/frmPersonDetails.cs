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
    public partial class frmPersonDetails : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmPersonDetails()
        {
            InitializeComponent();
        }
        public clsPerson Person 
        {
            get 
            {
                return ctrlPersonDetails1.Person; 
            }
            set
            {
                ctrlPersonDetails1.Person = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Person"></param>
        public frmPersonDetails(clsPerson Person)
        {
            InitializeComponent();
            this.Person = Person;

        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
