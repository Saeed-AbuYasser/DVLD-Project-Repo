using System;

namespace DVLD_System_Version2
{
    partial class frmAddOrEditPerson
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlAddOrEditPerson1 = new DVLD_System_Version2.ctrlAddOrEditPerson();
            this.SuspendLayout();
            // 
            // ctrlAddOrEditPerson1
            // 
            this.ctrlAddOrEditPerson1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlAddOrEditPerson1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctrlAddOrEditPerson1.Location = new System.Drawing.Point(1, -1);

            this.ctrlAddOrEditPerson1.Size = new System.Drawing.Size(1067, 735);
            this.ctrlAddOrEditPerson1.TabIndex = 0;
            this.ctrlAddOrEditPerson1.Load += new System.EventHandler(this.ctrlAddOrEditPerson1_Load);
            // 
            // frmAddOrEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 735);
            this.Controls.Add(this.ctrlAddOrEditPerson1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddOrEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add _Person";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddOrEditPerson_FormClosing);
            this.Load += new System.EventHandler(this.frmAddOrEditPerson_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddOrEditPerson ctrlAddOrEditPerson1;
    }
}