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
    public partial class FrmMain : Form
    {
        public List<Person> peaple = new List<Person>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FillDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgPerson.SelectedRows.Count > 0)
            {
                int index = dvgPerson.SelectedRows[0].Index;
                peaple.RemoveAt(index);
                FillDgv();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmPerson();
            frm.Text = "ثبت دانش آموز";
            frm.ShowDialog();
            FillDgv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            FillDgv();
        }
        private void FillDgv()
        {
            dvgPerson.DataSource=peaple.ToList();
        }
    }
}
