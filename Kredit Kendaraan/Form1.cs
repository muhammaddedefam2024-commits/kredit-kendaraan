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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DB.crud($"select * from user inner join role on user.id_role = role.id_role where ussername = '{TxtUsser.Text}' AND password='{TxtPass.Text}'");
            int cekbaris = DB.ds.Tables[0].Rows.Count;
            if (cekbaris == 1)
            {
                DataRow baris = DB.ds.Tables[0].Rows[0];
                string role = "" + baris["role_name"];

                if (role == "Admin")
                {
                    FormAdmin FA = new FormAdmin();
                    FA.Show();
                    this.Hide();
                }
                if (role == "User")
                {
                    Fuser FU = new Fuser();
                    FU.Show();
                    this.Hide();
                }
               
            }
            else
            {
                MessageBox.Show("Username atau password salah");
            }
        }

        private void TxtUsser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtUsser.Text != "")
                {
                    TxtPass.Select();
                }
            }
        }
    }
}
