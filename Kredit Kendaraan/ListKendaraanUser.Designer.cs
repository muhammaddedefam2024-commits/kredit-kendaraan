namespace Kredit_Kendaraan
{
    partial class ListKendaraanUser
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

            this.panel2       = new System.Windows.Forms.Panel();
            this.pnlHeader    = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlHeaderDiv = new System.Windows.Forms.Panel();
            this.textBox1     = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1  = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            // kolom
            this.colID     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMerk   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipe   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTahun  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoPol  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarga  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panel2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // ── panel2 (background) ──────────────────────────────────────────
            this.panel2.AutoSize  = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panel2.Controls.Add(this.pnlHeader);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name     = "panel2";
            this.panel2.Size     = new System.Drawing.Size(1924, 1170);
            this.panel2.TabIndex = 0;

            // ── pnlHeader ────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.pnlHeaderDiv);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name     = "pnlHeader";
            this.pnlHeader.Size     = new System.Drawing.Size(1924, 60);
            this.pnlHeader.TabIndex = 0;

            this.lblPageTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPageTitle.Location  = new System.Drawing.Point(20, 14);
            this.lblPageTitle.Name      = "lblPageTitle";
            this.lblPageTitle.Size      = new System.Drawing.Size(600, 32);
            this.lblPageTitle.Text      = "Daftar Kendaraan Tersedia";

            this.pnlHeaderDiv.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlHeaderDiv.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderDiv.Location  = new System.Drawing.Point(0, 59);
            this.pnlHeaderDiv.Name      = "pnlHeaderDiv";
            this.pnlHeaderDiv.Size      = new System.Drawing.Size(1924, 1);
            this.pnlHeaderDiv.TabIndex  = 99;

            // ── textBox1 (search) ─────────────────────────────────────────────
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.BorderColor     = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderRadius    = 10;
            this.textBox1.BorderThickness = 3;
            this.textBox1.Cursor          = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText     = "";
            this.textBox1.DisabledState.BorderColor         = System.Drawing.Color.FromArgb(208, 208, 208);
            this.textBox1.DisabledState.FillColor           = System.Drawing.Color.FromArgb(226, 226, 226);
            this.textBox1.DisabledState.ForeColor           = System.Drawing.Color.FromArgb(138, 138, 138);
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            this.textBox1.FocusedState.BorderColor          = System.Drawing.Color.FromArgb(94, 148, 255);
            this.textBox1.Font            = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor       = System.Drawing.Color.Black;
            this.textBox1.HoverState.BorderColor            = System.Drawing.Color.FromArgb(94, 148, 255);
            this.textBox1.Location        = new System.Drawing.Point(32, 80);
            this.textBox1.Margin          = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name            = "textBox1";
            this.textBox1.PlaceholderText = "Cari Merk atau Tipe...";
            this.textBox1.SelectedText    = "";
            this.textBox1.Size            = new System.Drawing.Size(350, 55);
            this.textBox1.TabIndex        = 1;
            this.textBox1.TextChanged    += new System.EventHandler(this.textBox1_TextChanged);

            // ── guna2Panel1 (tabel) ───────────────────────────────────────────
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 170);
            this.guna2Panel1.Name     = "guna2Panel1";
            this.guna2Panel1.Size     = new System.Drawing.Size(1924, 1000);
            this.guna2Panel1.TabIndex = 2;

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
            this.dataGridView1.Dock                      = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location                  = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name                      = "dataGridView1";
            this.dataGridView1.ReadOnly                  = true;
            this.dataGridView1.RowHeadersVisible         = false;
            this.dataGridView1.RowHeadersWidth           = 62;
            this.dataGridView1.RowTemplate.Height        = 38;
            this.dataGridView1.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabIndex                  = 0;

            // Kolom grid
            this.colID.HeaderText = "ID";       this.colID.Name = "colID";     this.colID.Width = 60;
            this.colMerk.HeaderText = "Merk";   this.colMerk.Name = "colMerk"; this.colMerk.Width = 200;
            this.colTipe.HeaderText = "Tipe";   this.colTipe.Name = "colTipe"; this.colTipe.Width = 200;
            this.colTahun.HeaderText = "Tahun"; this.colTahun.Name = "colTahun"; this.colTahun.Width = 80;
            this.colNoPol.HeaderText = "No. Polisi"; this.colNoPol.Name = "colNoPol"; this.colNoPol.Width = 130;
            this.colHarga.HeaderText = "Harga"; this.colHarga.Name = "colHarga"; this.colHarga.Width = 160;
            this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus"; this.colStatus.Width = 120;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID, this.colMerk, this.colTipe, this.colTahun,
                this.colNoPol, this.colHarga, this.colStatus });

            // ── Form ──────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.panel2);
            this.Name  = "ListKendaraanUser";
            this.Text  = "Daftar Kendaraan";
            this.Load += new System.EventHandler(this.ListKendaraanUser_Load);

            this.panel2.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel            panel2;
        private Guna.UI2.WinForms.Guna2Panel          pnlHeader;
        private System.Windows.Forms.Label            lblPageTitle;
        private System.Windows.Forms.Panel            pnlHeaderDiv;
        private Guna.UI2.WinForms.Guna2TextBox        textBox1;
        private Guna.UI2.WinForms.Guna2Panel          guna2Panel1;
        private System.Windows.Forms.DataGridView     dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoPol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
