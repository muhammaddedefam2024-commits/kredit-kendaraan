using System;
using System.Data;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void DashboardUser_Load(object sender, EventArgs e)
        {
            MuatDashboard();
        }

        private void MuatDashboard()
        {
            // Sambut user dengan nama login
            if (DB.NamaUser != "")
                lblHeaderInfo.Text = DB.NamaUser + "  |  Portal Nasabah";

            // ── Kartu: Jumlah Kredit Saya ────────────────────────────────────
            try
            {
                DB.crud($"SELECT COUNT(*) AS total FROM transaksi" +
                        $" WHERE Pelanggan LIKE '%{DB.NamaUser}%'");
                lblCardKreditValue.Text = "" + DB.ds.Tables[0].Rows[0]["total"];
            }
            catch { lblCardKreditValue.Text = "0"; }

            // ── Kartu: Total Sisa Kredit ─────────────────────────────────────
            try
            {
                DB.crud($"SELECT COALESCE(SUM(Sisa_kredit),0) AS total FROM transaksi" +
                        $" WHERE Pelanggan LIKE '%{DB.NamaUser}%'");
                object val = DB.ds.Tables[0].Rows[0]["total"];
                lblCardSisaValue.Text = "Rp " + string.Format("{0:N0}", val);
            }
            catch { lblCardSisaValue.Text = "Rp 0"; }

            // ── Tabel: Riwayat Cicilan Saya ──────────────────────────────────
            dataGridView1.Rows.Clear();
            try
            {
                DB.crud($"SELECT idtrans, Pelanggan, Kendaraan, Harga, DP, Sisa_kredit, Tanggal" +
                        $" FROM transaksi WHERE Pelanggan LIKE '%{DB.NamaUser}%'" +
                        $" ORDER BY idtrans DESC");
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
        }
    }
}
