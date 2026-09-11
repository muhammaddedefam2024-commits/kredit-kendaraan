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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        public void bersih()
        {
            txtnama.Text = "";
            txtken.Text = "";
            txtharga.Text = "";
            txtdp.Text = "";
            txtsisa.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtawal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtnama.Text == "" || txtken.Text == "" || txtharga.Text == "" || txtdp.Text == ""|| txtsisa.Text == "")
            {
                MessageBox.Show("Lengkapi data");
            }
            else
            {
                string na = txtnama.Text;
                string ken = txtken.Text;
                string harga = txtharga.Text;
                string dp = txtdp.Text;
                string sisa = txtsisa.Text;

                DB.crud($"INSERT INTO transaksi VALUES (null,'{na}','{ken}','{harga}','{dp}','{sisa}')");
                bersih();
                tampildata();
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string na = txtnama.Text;
            string ken = txtken.Text;
            string harga = txtharga.Text;
            string dp = txtdp.Text;
            string sisa = txtsisa.Text;

            DB.crud($"update transaksi Set Pelanggan = '{na}', Kendaraan = '{ken}', Harga = '{harga}', DP = '{dp}', Sisa_kredit = '{sisa}' where  idtrans = '{label7.Text}'");
            bersih();
            tampildata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 6)
            {
                string idk = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"Select *From transaksi WHERE idtrans = '{idk}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idtr = "" + brs["idtans"];
                    string nama = "" + brs["Pelanggan"];
                    string ken = "" + brs["Kendaraan"];
                    string harga = "" + brs["Harga"];
                    string dp = "" + brs["DP"];
                    string sisa = "" + brs["Sisa_kredit"];

                    label7.Text = idtr;

                    txtnama.Text = nama;
                    txtken.Text = ken;
                    txtharga.Text = harga;
                    txtdp.Text = dp;
                    txtsisa.Text = sisa;


                }
            }
            if (kolom == 7)
            {
                string idt = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau Dihapus?" + idt, "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"Delete From transaksi where idtrans = '{idt}'");
                }

                tampildata();
            }
        }
    }
}
