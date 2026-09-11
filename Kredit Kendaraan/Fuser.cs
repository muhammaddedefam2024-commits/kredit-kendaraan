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
    public partial class Fuser : Form
    {
        public Fuser()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
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

        private void btnKreditSaya_Click(object sender, EventArgs e)
        {
            Transaksi Data = new Transaksi() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            Kendaraan Data = new Kendaraan() { TopLevel = false, TopMost = true };
            CKF.form(Data, pnlContent);
        }
    }
}
