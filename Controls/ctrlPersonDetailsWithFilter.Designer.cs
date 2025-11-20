namespace DVLD_System_Version2
{
    partial class ctrlPersonDetailsWithFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DVLD_Business.clsPerson clsPerson1 = new DVLD_Business.clsPerson();
            DVLD_Business.clsPerson clsPerson2 = new DVLD_Business.clsPerson();
            this.ctrlPersonDetails1 = new DVLD_System_Version2.ctrlPersonDetails();
            this.ctrlPersonFilter1 = new DVLD_System_Version2.ctrlPersonFilter();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.SuspendLayout();
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(0, 148);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            clsPerson1.Address = "";
            clsPerson1.DateOfBirth = new System.DateTime(2007, 3, 25, 0, 0, 0, 0);
            clsPerson1.Email = "";
            clsPerson1.FirstName = "";
            clsPerson1.Gendor = ((byte)(2));
            clsPerson1.ImagePath = "";
            clsPerson1.LastName = "";
            clsPerson1.NationalityCountryID = -1;
            clsPerson1.NationalNo = "";
            clsPerson1.PersonID = -1;
            clsPerson1.Phone = "";
            clsPerson1.SecondName = "";
            clsPerson1.ThirdName = "";
            this.ctrlPersonDetails1.Person = clsPerson1;
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(1030, 560);
            this.ctrlPersonDetails1.TabIndex = 0;
            this.ctrlPersonDetails1.InfoEdited += new System.EventHandler(this.ctrlPersonDetails1_InfoEdited);
            // 
            // ctrlPersonFilter1
            // 
            this.ctrlPersonFilter1.Location = new System.Drawing.Point(12, 74);
            this.ctrlPersonFilter1.Name = "ctrlPersonFilter1";
            clsPerson2.Address = "";
            clsPerson2.DateOfBirth = new System.DateTime(2007, 3, 25, 0, 0, 0, 0);
            clsPerson2.Email = "";
            clsPerson2.FirstName = "";
            clsPerson2.Gendor = ((byte)(2));
            clsPerson2.ImagePath = "";
            clsPerson2.LastName = "";
            clsPerson2.NationalityCountryID = -1;
            clsPerson2.NationalNo = "";
            clsPerson2.PersonID = -1;
            clsPerson2.Phone = "";
            clsPerson2.SecondName = "";
            clsPerson2.ThirdName = "";
            this.ctrlPersonFilter1.Person = clsPerson2;
            this.ctrlPersonFilter1.Size = new System.Drawing.Size(597, 68);
            this.ctrlPersonFilter1.TabIndex = 1;
            this.ctrlPersonFilter1.PersonFoundOnSearch += new System.EventHandler(this.ctrlPersonFilter1_PersonFoundOnSearch);
            this.ctrlPersonFilter1.PersonNotFoundOnSearch += new System.EventHandler(this.ctrlPersonFilter1_PersonNotFoundOnSearch);
            this.ctrlPersonFilter1.PersonAdded += new System.EventHandler(this.ctrlPersonFilter1_PersonAdded);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(83, 164);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(855, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // ctrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.ctrlPersonFilter1);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "ctrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(1037, 708);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetails ctrlPersonDetails1;
        private ctrlPersonFilter ctrlPersonFilter1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
