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
    /// Search for a person with ID or NationalNo. to preview its information with the ability of editing it.
    /// </summary>
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {

        
        clsPerson Person 
        { 
            get
            {
                return ctrlPersonDetails1.Person; 
            }
            set
            {
                if (!ctrlPersonDetails1.Person.Equals(value))
                {
                    ctrlPersonDetails1.Person = value;
                }
                if (!ctrlPersonFilter1.Person.Equals(value))
                {
                    ctrlPersonFilter1.Person = value;
                }
            }
        }

        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void ctrlPersonFilter1_PersonAdded(object sender, EventArgs e)
        {
            Person = ctrlPersonFilter1.Person;
        }

        private void ctrlPersonFilter1_PersonFoundOnSearch(object sender, EventArgs e)
        {
            Person = ctrlPersonFilter1.Person;
        }

        private void ctrlPersonFilter1_PersonNotFoundOnSearch(object sender, EventArgs e)
        {
            Person = new clsPerson();
        }

        private void ctrlPersonDetails1_InfoEdited(object sender, EventArgs e)
        {
            Person = ctrlPersonDetails1.Person;
        }
    }
}
