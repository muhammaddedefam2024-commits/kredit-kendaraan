namespace Kredit_Kendaraan
{
    partial class DashboardUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvAlt    = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCell   = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlHeader        = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPageTitle     = new System.Windows.Forms.Label();
            this.lblHeaderInfo    = new System.Windows.Forms.Label();
            this.pnlHeaderDivider = new System.Windows.Forms.Panel();
            this.pnlContent       = new Guna.UI2.WinForms.Guna2Panel();
            this.cardKredit       = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCardKreditIcon  = new System.Windows.Forms.Label();
            this.lblCardKreditTitle = new System.Windows.Forms.Label();
            this.lblCardKreditValue = new System.Windows.Forms.Label();
            this.cardSisa         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCardSisaIcon  = new System.Windows.Forms.Label();
            this.lblCardSisaTitle = new System.Windows.Forms.Label();
            this.lblCardSisaValue = new System.Windows.Forms.Label();
            this.pnlTable         = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTableTitle    = new System.Windows.Forms.Label();
            this.dataGridView1    = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.cardKredit.SuspendLayout();
            this.cardSisa.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderInfo);
            this.pnlHeader.Controls.Add(this.pnlHeaderDivider);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Size     = new System.Drawing.Size(1924, 60);
            this.pnlHeader.TabIndex = 0;

            this.lblPageTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPageTitle.Location  = new System.Drawing.Point(20, 14);
            this.lblPageTitle.Name      = "lblPageTitle";
            this.lblPageTitle.Size      = new System.Drawing.Size(400, 32);
            this.lblPageTitle.Text      = "Dashboard Saya";

            this.lblHeaderInfo.Anchor    = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderInfo.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderInfo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderInfo.Location  = new System.Drawing.Point(1550, 18);
            this.lblHeaderInfo.Name      = "lblHeaderInfo";
            this.lblHeaderInfo.Size      = new System.Drawing.Size(354, 24);
            this.lblHeaderInfo.Text      = "User  |  Portal Nasabah";
            this.lblHeaderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlHeaderDivider.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderDivider.Location  = new System.Drawing.Point(0, 59);
            this.pnlHeaderDivider.Name      = "pnlHeaderDivider";
            this.pnlHeaderDivider.Size      = new System.Drawing.Size(1924, 1);
            this.pnlHeaderDivider.TabIndex  = 99;

            // ── pnlContent ───────────────────────────────────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlContent.Controls.Add(this.cardKredit);
            this.pnlContent.Controls.Add(this.cardSisa);
            this.pnlContent.Controls.Add(this.pnlTable);
            this.pnlContent.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Name     = "pnlContent";
            this.pnlContent.Size     = new System.Drawing.Size(1924, 1110);
            this.pnlContent.TabIndex = 1;

            // ── cardKredit ───────────────────────────────────────────────────
            this.cardKredit.BackColor                  = System.Drawing.Color.Transparent;
            this.cardKredit.BorderRadius               = 12;
            this.cardKredit.Controls.Add(this.lblCardKreditIcon);
            this.cardKredit.Controls.Add(this.lblCardKreditTitle);
            this.cardKredit.Controls.Add(this.lblCardKreditValue);
            this.cardKredit.Location                   = new System.Drawing.Point(24, 20);
            this.cardKredit.Name                       = "cardKredit";
            this.cardKredit.ShadowDecoration.Color     = System.Drawing.Color.FromArgb(18, 0, 0, 0);
            this.cardKredit.ShadowDecoration.Depth     = 10;
            this.cardKredit.ShadowDecoration.Enabled   = true;
            this.cardKredit.Size                       = new System.Drawing.Size(380, 100);
            this.cardKredit.TabIndex                   = 0;

            this.lblCardKreditIcon.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardKreditIcon.ForeColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblCardKreditIcon.Location  = new System.Drawing.Point(332, 16);
            this.lblCardKreditIcon.Name      = "lblCardKreditIcon";
            this.lblCardKreditIcon.Size      = new System.Drawing.Size(36, 36);
            this.lblCardKreditIcon.Text      = "■";
            this.lblCardKreditIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardKreditTitle.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardKreditTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCardKreditTitle.Location  = new System.Drawing.Point(14, 14);
            this.lblCardKreditTitle.Name      = "lblCardKreditTitle";
            this.lblCardKreditTitle.Size      = new System.Drawing.Size(300, 18);
            this.lblCardKreditTitle.Text      = "Jumlah Kredit Saya";

            this.lblCardKreditValue.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCardKreditValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardKreditValue.Location  = new System.Drawing.Point(12, 36);
            this.lblCardKreditValue.Name      = "lblCardKreditValue";
            this.lblCardKreditValue.Size      = new System.Drawing.Size(310, 52);
            this.lblCardKreditValue.Text      = "0";

            // ── cardSisa ─────────────────────────────────────────────────────
            this.cardSisa.BackColor                  = System.Drawing.Color.Transparent;
            this.cardSisa.BorderRadius               = 12;
            this.cardSisa.Controls.Add(this.lblCardSisaIcon);
            this.cardSisa.Controls.Add(this.lblCardSisaTitle);
            this.cardSisa.Controls.Add(this.lblCardSisaValue);
            this.cardSisa.Location                   = new System.Drawing.Point(424, 20);
            this.cardSisa.Name                       = "cardSisa";
            this.cardSisa.ShadowDecoration.Color     = System.Drawing.Color.FromArgb(18, 0, 0, 0);
            this.cardSisa.ShadowDecoration.Depth     = 10;
            this.cardSisa.ShadowDecoration.Enabled   = true;
            this.cardSisa.Size                       = new System.Drawing.Size(380, 100);
            this.cardSisa.TabIndex                   = 1;

            this.lblCardSisaIcon.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCardSisaIcon.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblCardSisaIcon.Location  = new System.Drawing.Point(332, 16);
            this.lblCardSisaIcon.Name      = "lblCardSisaIcon";
            this.lblCardSisaIcon.Size      = new System.Drawing.Size(36, 36);
            this.lblCardSisaIcon.Text      = "■";
            this.lblCardSisaIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCardSisaTitle.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCardSisaTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCardSisaTitle.Location  = new System.Drawing.Point(14, 14);
            this.lblCardSisaTitle.Name      = "lblCardSisaTitle";
            this.lblCardSisaTitle.Size      = new System.Drawing.Size(300, 18);
            this.lblCardSisaTitle.Text      = "Total Sisa Kredit";

            this.lblCardSisaValue.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardSisaValue.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCardSisaValue.Location  = new System.Drawing.Point(12, 36);
            this.lblCardSisaValue.Name      = "lblCardSisaValue";
            this.lblCardSisaValue.Size      = new System.Drawing.Size(310, 52);
            this.lblCardSisaValue.Text      = "Rp 0";

            // ── pnlTable ─────────────────────────────────────────────────────
            this.pnlTable.BackColor                  = System.Drawing.Color.Transparent;
            this.pnlTable.BorderRadius               = 12;
            this.pnlTable.Controls.Add(this.lblTableTitle);
            this.pnlTable.Controls.Add(this.dataGridView1);
            this.pnlTable.Location                   = new System.Drawing.Point(24, 138);
            this.pnlTable.Name                       = "pnlTable";
            this.pnlTable.ShadowDecoration.Color     = System.Drawing.Color.FromArgb(18, 0, 0, 0);
            this.pnlTable.ShadowDecoration.Depth     = 10;
            this.pnlTable.ShadowDecoration.Enabled   = true;
            this.pnlTable.Size                       = new System.Drawing.Size(1652, 952);
            this.pnlTable.TabIndex                   = 2;

            this.lblTableTitle.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTableTitle.Location  = new System.Drawing.Point(16, 14);
            this.lblTableTitle.Name      = "lblTableTitle";
            this.lblTableTitle.Size      = new System.Drawing.Size(400, 26);
            this.lblTableTitle.Text      = "Riwayat Cicilan Saya";

            // ── dataGridView1 ─────────────────────────────────────────────────
            dgvAlt.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dgvAlt;
            this.dataGridView1.AllowUserToAddRows    = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor        = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle            = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle        = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeader.Alignment          = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeader.BackColor          = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvHeader.Font               = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeader.ForeColor          = System.Drawing.Color.FromArgb(71, 85, 105);
            dgvHeader.Padding            = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvHeader.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            dgvHeader.SelectionForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.dataGridView1.ColumnHeadersDefaultCellStyle   = dgvHeader;
            this.dataGridView1.ColumnHeadersHeight             = 38;
            this.dataGridView1.ColumnHeadersHeightSizeMode     = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCell.Alignment          = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCell.BackColor          = System.Drawing.Color.White;
            dgvCell.Font               = new System.Drawing.Font("Segoe UI", 9F);
            dgvCell.ForeColor          = System.Drawing.Color.FromArgb(30, 41, 59);
            dgvCell.Padding            = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dgvCell.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dgvCell.SelectionForeColor = System.Drawing.Color.FromArgb(30, 58, 138);
            dgvCell.WrapMode           = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle          = dgvCell;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor                 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dataGridView1.Location                  = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name                      = "dataGridView1";
            this.dataGridView1.ReadOnly                  = true;
            this.dataGridView1.RowHeadersVisible         = false;
            this.dataGridView1.RowHeadersWidth           = 62;
            this.dataGridView1.RowTemplate.Height        = 38;
            this.dataGridView1.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size                      = new System.Drawing.Size(1620, 886);
            this.dataGridView1.TabIndex                  = 1;
            // Kolom grid
            System.Windows.Forms.DataGridViewTextBoxColumn cID   = new System.Windows.Forms.DataGridViewTextBoxColumn(); cID.HeaderText   = "ID";          cID.Name   = "cID";   cID.Width   = 60;
            System.Windows.Forms.DataGridViewTextBoxColumn cNama = new System.Windows.Forms.DataGridViewTextBoxColumn(); cNama.HeaderText = "Pelanggan";   cNama.Name = "cNama"; cNama.Width = 200;
            System.Windows.Forms.DataGridViewTextBoxColumn cKen  = new System.Windows.Forms.DataGridViewTextBoxColumn(); cKen.HeaderText  = "Kendaraan";   cKen.Name  = "cKen";  cKen.Width  = 200;
            System.Windows.Forms.DataGridViewTextBoxColumn cHrg  = new System.Windows.Forms.DataGridViewTextBoxColumn(); cHrg.HeaderText  = "Harga";       cHrg.Name  = "cHrg";  cHrg.Width  = 150;
            System.Windows.Forms.DataGridViewTextBoxColumn cDP   = new System.Windows.Forms.DataGridViewTextBoxColumn(); cDP.HeaderText   = "DP";          cDP.Name   = "cDP";   cDP.Width   = 150;
            System.Windows.Forms.DataGridViewTextBoxColumn cSisa = new System.Windows.Forms.DataGridViewTextBoxColumn(); cSisa.HeaderText = "Sisa Kredit"; cSisa.Name = "cSisa"; cSisa.Width = 150;
            System.Windows.Forms.DataGridViewTextBoxColumn cTgl  = new System.Windows.Forms.DataGridViewTextBoxColumn(); cTgl.HeaderText  = "Tanggal";     cTgl.Name  = "cTgl";  cTgl.Width  = 120;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cID, cNama, cKen, cHrg, cDP, cSisa, cTgl });

            // ── DashboardUser Form ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Name  = "DashboardUser";
            this.Text  = "Dashboard Saya";
            this.Load += new System.EventHandler(this.DashboardUser_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.cardKredit.ResumeLayout(false);
            this.cardSisa.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label   lblPageTitle;
        private System.Windows.Forms.Label   lblHeaderInfo;
        private System.Windows.Forms.Panel   pnlHeaderDivider;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Panel cardKredit;
        private System.Windows.Forms.Label   lblCardKreditIcon;
        private System.Windows.Forms.Label   lblCardKreditTitle;
        private System.Windows.Forms.Label   lblCardKreditValue;
        private Guna.UI2.WinForms.Guna2Panel cardSisa;
        private System.Windows.Forms.Label   lblCardSisaIcon;
        private System.Windows.Forms.Label   lblCardSisaTitle;
        private System.Windows.Forms.Label   lblCardSisaValue;
        private Guna.UI2.WinForms.Guna2Panel pnlTable;
        private System.Windows.Forms.Label   lblTableTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
