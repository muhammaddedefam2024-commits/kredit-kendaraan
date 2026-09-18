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

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("select * from transaksi");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idt = "" + baris["idtrans"];
                string nama = "" + baris["Pelanggan"];
                string ken = "" + baris["Kendaraan"];
                string harga = "" + baris["Harga"];
                string dp = "" + baris["DP"];
                string sisa = "" + baris["Sisa_kredit"];
                dataGridView1.Rows.Add(idt, nama, ken, harga, dp, sisa);
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
            DB.crud($"Select * From transaksi where Pelanggan like '%{textBox1.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idt = "" + baris["idtrans"];
                string nama = "" + baris["Pelanggan"];
                string ken = "" + baris["Kendaraan"];
                string harga = "" + baris["Harga"];
                string dp = "" + baris["DP"];
                string sisa = "" + baris["Sisa_kredit"];
                dataGridView1.Rows.Add(idt, nama, ken, harga, dp, sisa);
            }
        }
    }
}
