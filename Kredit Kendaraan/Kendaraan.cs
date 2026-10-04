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
            DB.crud("select * from rincian_kendaraan");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string idk = "" + baris["ID_Kendaraan"];
                string merk = "" + baris["Merk"];
                string tipe = "" + baris["Tipe"];
                string tahun = "" + baris["Tahun"];
                string warna = "" + baris["Warna"];
                string harga = "" + baris["Harga"];
                string stok = "" + baris["Stok"];

                dataGridView1.Rows.Add(idk, merk, tipe, tahun, warna, harga, stok);


            }
        }

            private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtmerk.Text == "" || txttipe.Text == "" || txttahun.Text == "" || txtwarna.Text == "" || txtharga.Text == "" || txtstok.Text == "")
            {
                MessageBox.Show("Lengkapi data");
            }
            else
            {
               string mk =  txtmerk.Text;
               string tp = txttipe.Text;
               string th = txttahun.Text;
               string wn = txtwarna.Text;
               string hr = txtharga.Text;
               string sk = txtstok.Text;


                DB.crud($"INSERT INTO transaksi VALUES (null,'{mk}','{tp}','{th}','{wn}','{hr}','{sk}')");
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
    }
}
