using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Peaple = new Person();

            Peaple.NationalCode = int.Parse(txtNationalCode.Text);
            Peaple.Name = txtName.Text;
            Peaple.LastName = txtLastName.Text;
            Peaple.Gender = txtGender.Text;
            var frmMain = Application.OpenForms["FrmMain"] as FrmMain;
            frmMain.peaple.Add(Peaple);
            this.Close();
            
        }
     }
}
