using System;
using System.Data;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            MuatDropdownPelanggan();
            MuatDropdownKendaraan();
            tampildata();
        }

        // ── Dropdown Pelanggan: ambil dari tabel user role = User (id_role=2) ──
        private void MuatDropdownPelanggan()
        {
            cmbPelanggan.Items.Clear();
            try
            {
                DB.crud("SELECT ID_user, Nama_Lengkap FROM user WHERE id_role = '2' ORDER BY Nama_Lengkap");
                foreach (DataRow baris in DB.ds.Tables[0].Rows)
                {
                    // Format: "Nama_Lengkap|ID_user"
                    cmbPelanggan.Items.Add("" + baris["Nama_Lengkap"] + "|" + baris["ID_user"]);
                }
            }
            catch { }
        }

        // Helper: ambil ID user dari item dropdown pelanggan
        private string IDPelanggan()
        {
            string item = cmbPelanggan.SelectedItem?.ToString() ?? "";
            string[] parts = item.Split('|');
            return parts.Length >= 2 ? parts[1] : "0";
        }

        // Helper: ambil nama pelanggan bersih dari item dropdown
        private string NamaPelanggan()
        {
            string item = cmbPelanggan.SelectedItem?.ToString() ?? "";
            string[] parts = item.Split('|');
            return parts.Length > 0 ? parts[0] : item;
        }

        // ── Dropdown Kendaraan: ambil dari tabel kendaraan ──────────────────────────
        private void MuatDropdownKendaraan()
        {
            cmbKendaraan.Items.Clear();
            try
            {
                DB.crud("SELECT KendaraanID, Merk, Tipe, Harga FROM kendaraan ORDER BY Merk");
                foreach (DataRow baris in DB.ds.Tables[0].Rows)
                {
                    // Format: "Merk Tipe|Harga|KendaraanID"
                    string label = baris["Merk"] + " " + baris["Tipe"];
                    cmbKendaraan.Items.Add(label + "|" + baris["Harga"] + "|" + baris["KendaraanID"]);
                }
            }
            catch { }
        }

        // Saat kendaraan dipilih, otomatis isi harga dari DB
        private void cmbKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKendaraan.SelectedIndex < 0) return;
            string item = cmbKendaraan.SelectedItem?.ToString() ?? "";
            string[] parts = item.Split('|');
            if (parts.Length >= 2)
                txtharga.Text = parts[1];
        }

        // Handler pelanggan — tidak perlu auto-fill apapun
        private void cmbPelanggan_SelectedIndexChanged(object sender, EventArgs e) { }

        // Helper: ambil KendaraanID dari item dropdown kendaraan
        private string IDKendaraan()
        {
            string item = cmbKendaraan.SelectedItem?.ToString() ?? "";
            string[] parts = item.Split('|');
            return parts.Length >= 3 ? parts[2] : "0";
        }

        // Helper: ambil nama kendaraan bersih
        private string NamaKendaraan()
        {
            string item = cmbKendaraan.SelectedItem?.ToString() ?? "";
            string[] parts = item.Split('|');
            return parts.Length > 0 ? parts[0] : item;
        }

        public void bersih()
        {
            cmbPelanggan.SelectedIndex = -1;
            cmbKendaraan.SelectedIndex = -1;
            txtharga.Text = "";
            txtdp.Text    = "";
            txtsisa.Text  = "";
            label7.Text   = "";
        }

        public void tampildata()
        {
            dataGridView1.Rows.Clear();
            DB.crud("SELECT * FROM transaksi ORDER BY idtrans DESC");
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cmbPelanggan.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih pelanggan dari dropdown.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbKendaraan.SelectedIndex < 0)
            {
                MessageBox.Show("Pilih kendaraan dari dropdown.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtharga.Text == "" || txtdp.Text == "" || txtsisa.Text == "")
            {
                MessageBox.Show("Lengkapi semua data kredit.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi DP tidak boleh melebihi harga
            if (long.TryParse(txtdp.Text, out long dpVal) &&
                long.TryParse(txtharga.Text, out long hargaVal) &&
                dpVal > hargaVal)
            {
                MessageBox.Show("DP tidak boleh melebihi harga kendaraan.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string na      = NamaPelanggan();
            string idUser  = IDPelanggan();
            string ken     = NamaKendaraan();
            string idKen   = IDKendaraan();
            string harga   = txtharga.Text;
            string dp      = txtdp.Text;
            string sisa    = txtsisa.Text;
            string tanggal = Date.Value.ToString("yyyy-MM-dd");

            // INSERT dengan FK (ID_user, KendaraanID) + teks redundant untuk kompatibilitas app
            DB.crud($"INSERT INTO transaksi (ID_user, KendaraanID, Pelanggan, Kendaraan, Harga, DP, Sisa_kredit, Tanggal)" +
                    $" VALUES ('{idUser}','{idKen}','{na}','{ken}','{harga}','{dp}','{sisa}','{tanggal}')");
            bersih();
            tampildata();
            MessageBox.Show("Data kredit atas nama '" + na + "' berhasil disimpan.\n" +
                            "Data sudah bisa dilihat di halaman Kredit Saya dan Riwayat Cicilan user.",
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void button1_Click(object sender, EventArgs e)  // Update
        {
            if (label7.Text == "")
            {
                MessageBox.Show("Pilih data yang akan diupdate dari tabel.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string na      = cmbPelanggan.SelectedIndex >= 0
                             ? NamaPelanggan()
                             : (dataGridView1.CurrentRow?.Cells[1].Value?.ToString() ?? "");
            string idUser  = cmbPelanggan.SelectedIndex >= 0 ? IDPelanggan() : "0";
            string ken     = cmbKendaraan.SelectedIndex >= 0
                             ? NamaKendaraan()
                             : (dataGridView1.CurrentRow?.Cells[2].Value?.ToString() ?? "");
            string idKen   = cmbKendaraan.SelectedIndex >= 0 ? IDKendaraan() : "0";
            string harga   = txtharga.Text;
            string dp      = txtdp.Text;
            string sisa    = txtsisa.Text;
            string tanggal = Date.Value.ToString("yyyy-MM-dd");

            DB.crud($"UPDATE transaksi SET ID_user='{idUser}', KendaraanID='{idKen}'," +
                    $" Pelanggan='{na}', Kendaraan='{ken}', Harga='{harga}'," +
                    $" DP='{dp}', Sisa_kredit='{sisa}', Tanggal='{tanggal}'" +
                    $" WHERE idtrans='{label7.Text}'");
            bersih();
            tampildata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;

            if (kolom == 7)  // Edit — isi form dari baris terpilih
            {
                string idk = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT * FROM transaksi WHERE idtrans='{idk}'");
                foreach (DataRow brs in DB.ds.Tables[0].Rows)
                {
                    label7.Text   = "" + brs["idtrans"];
                    string namaDB = "" + brs["Pelanggan"];
                    string kenDB  = "" + brs["Kendaraan"];
                    txtharga.Text = "" + brs["Harga"];
                    txtdp.Text    = "" + brs["DP"];
                    txtsisa.Text  = "" + brs["Sisa_kredit"];
                    if (brs["Tanggal"] != DBNull.Value)
                        Date.Value = Convert.ToDateTime(brs["Tanggal"]);

                    // Cari dan pilih pelanggan di dropdown
                    cmbPelanggan.SelectedIndex = -1;
                    for (int i = 0; i < cmbPelanggan.Items.Count; i++)
                    {
                        if (cmbPelanggan.Items[i].ToString().Split('|')[0] == namaDB)
                        {
                            cmbPelanggan.SelectedIndex = i;
                            break;
                        }
                    }

                    // Cari dan pilih kendaraan di dropdown
                    cmbKendaraan.SelectedIndex = -1;
                    for (int i = 0; i < cmbKendaraan.Items.Count; i++)
                    {
                        if (cmbKendaraan.Items[i].ToString().Split('|')[0] == kenDB)
                        {
                            cmbKendaraan.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }

            if (kolom == 8)  // Hapus
            {
                string idt = dataGridView1.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau Dihapus? ID: " + idt, "Pemberitahuan",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                    DB.crud($"DELETE FROM transaksi WHERE idtrans='{idt}'");
                tampildata();
            }
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

        // Stubs untuk event yang di-wire di Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void txtnama_TextChanged(object sender, EventArgs e) { }
        private void txtawal_TextChanged(object sender, EventArgs e) { }
        private void txtsisa_TextChanged(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }
        private void txtdp_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void txtharga_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}
