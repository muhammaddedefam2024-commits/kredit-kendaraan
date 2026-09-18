using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            FormDataMaster Data = new FormDataMaster() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form2 Data = new Form2() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }

        private void btnKredit_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult setuju = MessageBox.Show("Apakah mau keluar?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (setuju == DialogResult.Yes)
            {
                Form1 F1 = new Form1();
                F1.Visible = true;
                this.Hide();
            }
        }

        private void btnKendaraan_Click(object sender, EventArgs e)
        {
            Transaksi Data = new Transaksi() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Kendaraan Data = new Kendaraan() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }
    }
}
