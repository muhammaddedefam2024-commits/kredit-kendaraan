using System;
using System.Data;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class ListKendaraanUser : Form
    {
        public ListKendaraanUser()
        {
            InitializeComponent();
        }

        private void ListKendaraanUser_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        private void tampildata()
        {
            dataGridView1.Rows.Clear();
            try
            {
                DB.crud("SELECT KendaraanID, Merk, Tipe, Tahun, NoPolisi, Harga, Status" +
                        " FROM kendaraan ORDER BY Merk");
                foreach (DataRow baris in DB.ds.Tables[0].Rows)
                {
                    string idk   = "" + baris["KendaraanID"];
                    string merk  = "" + baris["Merk"];
                    string tipe  = "" + baris["Tipe"];
                    string tahun = "" + baris["Tahun"];
                    string nopol = "" + baris["NoPolisi"];
                    string harga = string.Format("Rp {0:N0}", baris["Harga"]);
                    string status = "" + baris["Status"];
                    dataGridView1.Rows.Add(idk, merk, tipe, tahun, nopol, harga, status);
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                DB.crud($"SELECT KendaraanID, Merk, Tipe, Tahun, NoPolisi, Harga, Status" +
                        $" FROM kendaraan WHERE Merk LIKE '%{textBox1.Text}%'" +
                        $" OR Tipe LIKE '%{textBox1.Text}%'");
                foreach (DataRow baris in DB.ds.Tables[0].Rows)
                {
                    string idk   = "" + baris["KendaraanID"];
                    string merk  = "" + baris["Merk"];
                    string tipe  = "" + baris["Tipe"];
                    string tahun = "" + baris["Tahun"];
                    string nopol = "" + baris["NoPolisi"];
                    string harga = string.Format("Rp {0:N0}", baris["Harga"]);
                    string status = "" + baris["Status"];
                    dataGridView1.Rows.Add(idk, merk, tipe, tahun, nopol, harga, status);
                }
            }
            catch { }
        }
    }
}
