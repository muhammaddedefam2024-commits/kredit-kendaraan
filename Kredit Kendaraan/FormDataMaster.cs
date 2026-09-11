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
            DB.crud($"select * from user");
            foreach (DataRow brs in DB.ds.Tables[0].Rows) 
            {
                string idp = "" + brs["ID_user"];
                string nm = "" + brs["Nama_Lengkap"];
                string usn = "" + brs["ussername"];
                string role = "" + brs ["id_role"];

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
            if (txtUsername.Text != "" || txtNama.Text != "" || txtPassword.Text != "" || cmbRole.Text != "")
            {
                string nm = txtNama.Text;
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string role = cmbRole.Text;

                DB.crud($"insert into user values (null, '{nm}', '{user}', '{pass}', '{role}')");
                tampildata();
                bersih();
            }
            else
            {
                MessageBox.Show("Lengkapi Data !");
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
                DB.crud($"Select * from user where ID_user = '{idbar}'");
                foreach(DataRow brs in DB.ds.Tables[0].Rows)
                {
                    string idr = "" + brs ["ID_user"];
                    string nama = "" + brs["Nama_Lengkap"];
                    string user = "" + brs["ussername"];
                    string Pass = "" + brs["password"];
                    string role = "" + brs["id_role"];
                    label1.Text = idr;
                    txtNama.Text = nama;
                    txtUsername.Text = user;
                    txtPassword.Text = Pass;
                    cmbRole.Text = role;
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
            string na = txtNama.Text;
            String user = txtUsername.Text;
            String pass = txtPassword.Text;
            String rl = "" + cmbRole.SelectedItem;

            DB.crud($"update user Set Nama_Lengkap = '{na}', ussername = '{user}', password = '{pass}', id_role = '{rl}' where  id_user = '{label1.Text}'");
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
            DB.crud($"SELECT * FROM role ");
            foreach (DataRow baris in DB.ds.Tables[0].Rows)
            {
                string roleName = "" + baris["id_role"];
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
