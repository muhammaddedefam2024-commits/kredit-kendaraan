using System;
using System.Data;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MuatDashboard();
        }

        private void MuatDashboard()
        {
            // ── Kartu: Total Kendaraan ──────────────────────────────────────
            try
            {
                DB.crud("SELECT COUNT(*) AS total FROM kendaraan");
                lblCardKenValue.Text = "" + DB.ds.Tables[0].Rows[0]["total"];
            }
            catch { lblCardKenValue.Text = "0"; }

            // ── Kartu: Kredit Aktif (total transaksi) ───────────────────────
            try
            {
                DB.crud("SELECT COUNT(*) AS total FROM transaksi");
                lblCardKreValue.Text = "" + DB.ds.Tables[0].Rows[0]["total"];
            }
            catch { lblCardKreValue.Text = "0"; }

            // ── Tabel: 10 Transaksi Terbaru ──────────────────────────────────
            dataGridView1.Rows.Clear();
            try
            {
                DB.crud("SELECT idtrans, Pelanggan, Kendaraan, Harga, DP, Sisa_kredit, Tanggal" +
                        " FROM transaksi ORDER BY idtrans DESC LIMIT 10");
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
            catch { }

            // ── Info admin di header ─────────────────────────────────────────
            if (DB.NamaUser != "")
                lblHeaderInfo.Text = DB.NamaUser + "  |  Selamat datang kembali";
        }

        private void lblCardKenValue_Click(object sender, EventArgs e) { }
    }
}
