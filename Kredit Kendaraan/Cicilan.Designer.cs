
namespace Kredit_Kendaraan
{
    partial class Cicilan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cicilan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.IDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kendaraan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SisaKredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnTampil);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 1170);
            this.panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.BorderRadius = 10;
            this.textBox1.BorderThickness = 3;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBox1.IconLeft")));
            this.textBox1.Location = new System.Drawing.Point(32, 603);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(286, 60);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.dataGridView1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 795);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1924, 375);
            this.guna2Panel1.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDT,
            this.Pelanggan,
            this.Kendaraan,
            this.Harga,
            this.DP,
            this.SisaKredit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTampil
            // 
            this.btnTampil.BorderThickness = 2;
            this.btnTampil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTampil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTampil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTampil.FillColor = System.Drawing.Color.Blue;
            this.btnTampil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Image = ((System.Drawing.Image)(resources.GetObject("btnTampil.Image")));
            this.btnTampil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTampil.Location = new System.Drawing.Point(32, 59);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(208, 79);
            this.btnTampil.TabIndex = 40;
            this.btnTampil.Text = "Tampil Data";
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // IDT
            // 
            this.IDT.HeaderText = "IDT";
            this.IDT.MinimumWidth = 8;
            this.IDT.Name = "IDT";
            this.IDT.Width = 150;
            // 
            // Pelanggan
            // 
            this.Pelanggan.HeaderText = "Pelanggan";
            this.Pelanggan.MinimumWidth = 8;
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.Width = 150;
            // 
            // Kendaraan
            // 
            this.Kendaraan.HeaderText = "Kendaraan";
            this.Kendaraan.MinimumWidth = 8;
            this.Kendaraan.Name = "Kendaraan";
            this.Kendaraan.Width = 150;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            this.Harga.Width = 150;
            // 
            // DP
            // 
            this.DP.HeaderText = "DP";
            this.DP.MinimumWidth = 8;
            this.DP.Name = "DP";
            this.DP.Width = 150;
            // 
            // SisaKredit
            // 
            this.SisaKredit.HeaderText = "Sisa Kredit";
            this.SisaKredit.MinimumWidth = 8;
            this.SisaKredit.Name = "SisaKredit";
            this.SisaKredit.Width = 150;
            // 
            // Cicilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.panel2);
            this.Name = "Cicilan";
            this.Text = "Cicilan";
            this.panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kendaraan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn DP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SisaKredit;
    }
}