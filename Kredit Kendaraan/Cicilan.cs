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
    public partial class Cicilan : Form
    {
        
        public Cicilan()
        {
            InitializeComponent();
        }

        private void Cicilan_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            // Jika user biasa, filter berdasarkan nama login; Admin tampil semua
            string query = (DB.RoleName == "Admin")
                ? "SELECT * FROM transaksi"
                : $"SELECT * FROM transaksi WHERE Pelanggan LIKE '%{DB.NamaUser}%'";
            DB.crud(query);
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idt   = "" + baris["idtrans"];
                string nama  = "" + baris["Pelanggan"];
                string ken   = "" + baris["Kendaraan"];
                string harga = "" + baris["Harga"];
                string dp    = "" + baris["DP"];
                string sisa  = "" + baris["Sisa_kredit"];
                // handle NULL Tanggal
                string tgl   = (baris["Tanggal"] == DBNull.Value)
                               ? "-"
                               : Convert.ToDateTime(baris["Tanggal"]).ToString("dd/MM/yyyy");

                dataGridView1.Rows.Add(idt, nama, ken, harga, dp, sisa, tgl);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.crud($"SELECT * FROM transaksi WHERE Pelanggan LIKE '%{textBox1.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idt   = "" + baris["idtrans"];
                string nama  = "" + baris["Pelanggan"];
                string ken   = "" + baris["Kendaraan"];
                string harga = "" + baris["Harga"];
                string dp    = "" + baris["DP"];
                string sisa  = "" + baris["Sisa_kredit"];
                string tgl   = (baris["Tanggal"] == DBNull.Value)
                               ? "-"
                               : Convert.ToDateTime(baris["Tanggal"]).ToString("dd/MM/yyyy");

                dataGridView1.Rows.Add(idt, nama, ken, harga, dp, sisa, tgl);
            }
        }
    }
}
