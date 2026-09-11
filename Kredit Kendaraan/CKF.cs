using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_Kendaraan
{
    class CKF
    {
        public static void form(Form forma, Panel panela)
        {
            panela.Controls.Clear();
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;
            panela.Controls.Add(forma);
            forma.Show();
        }
    }
}
