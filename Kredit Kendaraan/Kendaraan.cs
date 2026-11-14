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
    public partial class Kendaraan : Form
    {
        public Kendaraan()
        {
            InitializeComponent();
        }

        private void Kendaraan_Load(object sender, EventArgs e)
        {
            tampildata();
        }
        public void bersih()
        {
            txtmerk.Text = "";
            txttipe.Text = "";
            txttahun.Text = "";
            txtwarna.Text = "";
            txtharga.Text = "";
            txtstok.Text = "";
        }
        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            // fix: tabel kendaraan (bukan rincian_kendaraan yang tidak ada di DB)
            DB.crud("SELECT KendaraanID, Merk, Tipe, Tahun, NoPolisi, Harga, Status FROM kendaraan");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idk   = "" + baris["KendaraanID"];
                string merk  = "" + baris["Merk"];
                string tipe  = "" + baris["Tipe"];
                string tahun = "" + baris["Tahun"];
                string warna = "" + baris["NoPolisi"];   // NoPolisi di-map ke kolom Warna/No.Polisi
                string harga = "" + baris["Harga"];
                string stok  = "" + baris["Status"];     // Status di-map ke kolom Stok/Status

                dataGridView1.Rows.Add(idk, merk, tipe, tahun, warna, harga, stok);
            }
        }

            private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtmerk.Text == "" || txttipe.Text == "" || txttahun.Text == "" || txtharga.Text == "")
            {
                MessageBox.Show("Lengkapi data (Merk, Tipe, Tahun, Harga wajib diisi)");
            }
            else
            {
               string mk = txtmerk.Text;
               string tp = txttipe.Text;
               string th = txttahun.Text;
               string wn = txtwarna.Text == "" ? "-" : txtwarna.Text;  // NoPolisi
               string hr = txtharga.Text;
               string sk = txtstok.Text  == "" ? "Tersedia" : txtstok.Text;  // Status

               // fix: INSERT ke tabel kendaraan dengan named columns
               DB.crud($"INSERT INTO kendaraan (NoPolisi, Merk, Tipe, Tahun, Harga, Status)" +
                       $" VALUES ('{wn}','{mk}','{tp}','{th}','{hr}','{sk}')");
               bersih();
               tampildata();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        // handler Update (button1) — isi data dari grid dulu via dataGridView1_CellContentClick
        private void button1_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.");
                return;
            }
            string mk = txtmerk.Text;
            string tp = txttipe.Text;
            string th = txttahun.Text;
            string wn = txtwarna.Text == "" ? "-" : txtwarna.Text;
            string hr = txtharga.Text;
            string sk = txtstok.Text  == "" ? "Tersedia" : txtstok.Text;

            DB.crud($"UPDATE kendaraan SET NoPolisi='{wn}', Merk='{mk}', Tipe='{tp}'," +
                    $" Tahun='{th}', Harga='{hr}', Status='{sk}'" +
                    $" WHERE KendaraanID='{label7.Text}'");
            bersih();
            tampildata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            if (kolom == 7)  // Edit
            {
                string idk = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM kendaraan WHERE KendaraanID='{idk}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    label7.Text   = "" + brs["KendaraanID"];
                    txtmerk.Text  = "" + brs["Merk"];
                    txttipe.Text  = "" + brs["Tipe"];
                    txttahun.Text = "" + brs["Tahun"];
                    txtwarna.Text = "" + brs["NoPolisi"];
                    txtharga.Text = "" + brs["Harga"];
                    txtstok.Text  = "" + brs["Status"];
                }
            }
            if (kolom == 8)  // Hapus
            {
                string idk = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau Dihapus? ID: " + idk, "Pemberitahuan",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                    DB.crud($"DELETE FROM kendaraan WHERE KendaraanID='{idk}'");
                tampildata();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DB.crud($"SELECT KendaraanID, Merk, Tipe, Tahun, NoPolisi, Harga, Status" +
                    $" FROM kendaraan WHERE Merk LIKE '%{textBox1.Text}%'" +
                    $" OR Tipe LIKE '%{textBox1.Text}%'");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idk   = "" + baris["KendaraanID"];
                string merk  = "" + baris["Merk"];
                string tipe  = "" + baris["Tipe"];
                string tahun = "" + baris["Tahun"];
                string warna = "" + baris["NoPolisi"];
                string harga = "" + baris["Harga"];
                string stok  = "" + baris["Status"];
                dataGridView1.Rows.Add(idk, merk, tipe, tahun, warna, harga, stok);
            }
        }
    }
}
