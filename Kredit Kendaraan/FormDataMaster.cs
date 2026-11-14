using System;
using System.Data;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    public partial class FormDataMaster : Form
    {


        public FormDataMaster()
        {
            InitializeComponent();
        }

        public void bersih()
        {
            txtNama.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            cmbRole.SelectedItem = -1;
        }

        public void tampildata()
        {
            DataMaster.Rows.Clear();
            // fix: JOIN ke role untuk tampilkan nama role bukan id_role
            DB.crud("SELECT u.ID_user, u.Nama_Lengkap, u.ussername, r.role_name" +
                    " FROM user u LEFT JOIN role r ON u.id_role = r.id_role");
            foreach (DataRow brs in DB.ds.Tables[0].Rows) 
            {
                string idp  = "" + brs["ID_user"];
                string nm   = "" + brs["Nama_Lengkap"];
                string usn  = "" + brs["ussername"];
                string role = "" + brs["role_name"];   // fix: tampil nama role

                DataMaster.Rows.Add(idp, nm, usn, role);
            }
        }

        public void tampilrole()
        {
            DB.crud("SELECT  role_name FROM role ORDER BY id_role");
            if (DB.ds.Tables.Count > 0)
            {
                DataRole.DataSource = DB.ds.Tables[0];                       
            }
        }

    
        

        private void btnSimpanUser_Click_1(object sender, EventArgs e)
        {
            // fix: && bukan || — validasi cek semua field kosong
            if (txtUsername.Text == "" || txtNama.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("Lengkapi Data !");
            }
            else
            {
                string nm   = txtNama.Text;
                string user = txtUsername.Text;
                string pass = txtPassword.Text;

                // fix: cari id_role berdasarkan nama role yang dipilih
                DB.crud($"SELECT id_role FROM role WHERE role_name='{cmbRole.Text}'");
                string idRole = (DB.ds.Tables[0].Rows.Count > 0)
                                ? ("" + DB.ds.Tables[0].Rows[0]["id_role"])
                                : "2";  // default User jika tidak ditemukan

                DB.crud($"INSERT INTO user (Nama_Lengkap, ussername, password, id_role)" +
                        $" VALUES ('{nm}', '{user}', '{pass}', '{idRole}')");
                tampildata();
                bersih();
            }
        }

        private void btnSimpanRole_Click_1(object sender, EventArgs e)
        {
            if (txtRole.Text == "")
            {
                MessageBox.Show("Nama role tidak boleh kosong!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB.crud($"INSERT INTO role (role_name) VALUES ('{txtRole.Text}')");
            txtRole.Text = "";
            tampilrole();
        }

        private void btnBersihRole_Click_1(object sender, EventArgs e)
        {
           
        }



        private void DataMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = e.RowIndex;
            int kolom = e.ColumnIndex;
            if (kolom == 4)
            {
                string idbar = DataMaster.Rows[baris].Cells[0].Value.ToString();
                DB.crud($"SELECT u.*, r.role_name FROM user u" +
                        $" LEFT JOIN role r ON u.id_role = r.id_role" +
                        $" WHERE u.ID_user='{idbar}'");
                foreach(DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idr  = "" + brs["ID_user"];
                    string nama = "" + brs["Nama_Lengkap"];
                    string user = "" + brs["ussername"];
                    string Pass = "" + brs["password"];
                    string role = "" + brs["role_name"];  // fix: tampil role_name
                    label1.Text      = idr;
                    txtNama.Text     = nama;
                    txtUsername.Text = user;
                    txtPassword.Text = Pass;
                    cmbRole.Text     = role;
                }
            }
            if (kolom == 5)
            {
                string IDS = DataMaster.Rows[baris].Cells[0].Value.ToString();
                DialogResult setuju = MessageBox.Show("Apakah mau Dihapus?" + IDS, "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DB.crud($"Delete From user where id_user = '{IDS}'");
                }

                tampildata();
            }
        }

        private void btnBersihUser_Click(object sender, EventArgs e)
        {
            tampildata();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string na   = txtNama.Text;
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // fix: cari id_role dari nama role yang dipilih di combobox
            DB.crud($"SELECT id_role FROM role WHERE role_name='{cmbRole.Text}'");
            string idRole = (DB.ds.Tables[0].Rows.Count > 0)
                            ? ("" + DB.ds.Tables[0].Rows[0]["id_role"])
                            : cmbRole.Text;

            DB.crud($"UPDATE user SET Nama_Lengkap='{na}', ussername='{user}'," +
                    $" password='{pass}', id_role='{idRole}'" +
                    $" WHERE ID_user='{label1.Text}'");
            bersih();
            tampildata();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void cmbRole_DropDown(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            DB.crud("SELECT * FROM role");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                // fix: tampilkan role_name bukan id_role
                string roleName = "" + baris["role_name"];
                cmbRole.Items.Add(roleName);
            }
        }

        private void btnHapusRole_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tampilrole();
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
