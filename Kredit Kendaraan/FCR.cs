using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Kredit_Kendaraan
{
    public partial class FCR : Form
    {
        private ReportDocument DokumenLaporan;
        public FCR()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            string reportPath = Path.Combine(Application.StartupPath, "Jumlah.rpt");
            try
            {
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show(
                    "File report tidak ditemukan: \n" + reportPath,
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DokumenLaporan = new ReportDocument();
                DokumenLaporan. Load(reportPath);
                crystalReportViewer1.ReportSource = DokumenLaporan;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "Gagal menampilkan report: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DokumenLaporan != null)
                {
                    DokumenLaporan.Close();
                    DokumenLaporan.Dispose();
                    DokumenLaporan = null;
                }

            }
        }
    }
}
