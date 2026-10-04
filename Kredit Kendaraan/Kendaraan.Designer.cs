
namespace Kredit_Kendaraan
{
    partial class Kendaraan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kendaraan));
            this.label2 = new System.Windows.Forms.Label();
            this.txtmerk = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtharga = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtwarna = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttipe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Merk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tahun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Harga";
            // 
            // txtmerk
            // 
            this.txtmerk.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtmerk.BorderRadius = 10;
            this.txtmerk.BorderThickness = 3;
            this.txtmerk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmerk.DefaultText = "";
            this.txtmerk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmerk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmerk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmerk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmerk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmerk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmerk.ForeColor = System.Drawing.Color.Black;
            this.txtmerk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmerk.Location = new System.Drawing.Point(251, 66);
            this.txtmerk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmerk.Name = "txtmerk";
            this.txtmerk.PlaceholderText = "Masukkan Merk Kendaraan";
            this.txtmerk.SelectedText = "";
            this.txtmerk.Size = new System.Drawing.Size(286, 60);
            this.txtmerk.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtstok);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtharga);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnTampil);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.txtwarna);
            this.panel2.Controls.Add(this.txttahun);
            this.panel2.Controls.Add(this.txttipe);
            this.panel2.Controls.Add(this.txtmerk);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 1170);
            this.panel2.TabIndex = 12;
            // 
            // txtharga
            // 
            this.txtharga.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtharga.BorderRadius = 10;
            this.txtharga.BorderThickness = 3;
            this.txtharga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtharga.DefaultText = "";
            this.txtharga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtharga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtharga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtharga.ForeColor = System.Drawing.Color.Black;
            this.txtharga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga.Location = new System.Drawing.Point(251, 360);
            this.txtharga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtharga.Name = "txtharga";
            this.txtharga.PlaceholderText = "Masukkan Harga Kendaraan";
            this.txtharga.SelectedText = "";
            this.txtharga.Size = new System.Drawing.Size(286, 60);
            this.txtharga.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BorderThickness = 2;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.button1.Location = new System.Drawing.Point(677, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 79);
            this.button1.TabIndex = 42;
            this.button1.Text = "Update";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderThickness = 2;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.Blue;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Image")));
            this.btnSimpan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSimpan.Location = new System.Drawing.Point(215, 502);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(198, 79);
            this.btnSimpan.TabIndex = 41;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
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
            this.btnTampil.Location = new System.Drawing.Point(446, 502);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(208, 79);
            this.btnTampil.TabIndex = 40;
            this.btnTampil.Text = "Tampil Data";
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
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
            this.textBox1.Location = new System.Drawing.Point(693, 276);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(286, 60);
            this.textBox1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Tahun";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Warna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tipe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Merk";
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
            this.IDK,
            this.Merk,
            this.Tipe,
            this.Tahun,
            this.Warna,
            this.Harga,
            this.Stok,
            this.Edit,
            this.Hapus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtwarna
            // 
            this.txtwarna.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtwarna.BorderRadius = 10;
            this.txtwarna.BorderThickness = 3;
            this.txtwarna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtwarna.DefaultText = "";
            this.txtwarna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtwarna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtwarna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwarna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtwarna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwarna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtwarna.ForeColor = System.Drawing.Color.Black;
            this.txtwarna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtwarna.Location = new System.Drawing.Point(251, 276);
            this.txtwarna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtwarna.Name = "txtwarna";
            this.txtwarna.PlaceholderText = "Masukkan Warna Kendaraan";
            this.txtwarna.SelectedText = "";
            this.txtwarna.Size = new System.Drawing.Size(286, 60);
            this.txtwarna.TabIndex = 33;
            // 
            // txttahun
            // 
            this.txttahun.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txttahun.BorderRadius = 10;
            this.txttahun.BorderThickness = 3;
            this.txttahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttahun.DefaultText = "";
            this.txttahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttahun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttahun.ForeColor = System.Drawing.Color.Black;
            this.txttahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttahun.Location = new System.Drawing.Point(251, 206);
            this.txttahun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttahun.Name = "txttahun";
            this.txttahun.PlaceholderText = "Masukkan Tahun Kendaraan";
            this.txttahun.SelectedText = "";
            this.txttahun.Size = new System.Drawing.Size(286, 60);
            this.txttahun.TabIndex = 32;
            // 
            // txttipe
            // 
            this.txttipe.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txttipe.BorderRadius = 10;
            this.txttipe.BorderThickness = 3;
            this.txttipe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttipe.DefaultText = "";
            this.txttipe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttipe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttipe.ForeColor = System.Drawing.Color.Black;
            this.txttipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttipe.Location = new System.Drawing.Point(251, 136);
            this.txttipe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttipe.Name = "txttipe";
            this.txttipe.PlaceholderText = "Masukkan Tipe Kendaraan";
            this.txttipe.SelectedText = "";
            this.txttipe.Size = new System.Drawing.Size(286, 60);
            this.txttipe.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(995, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtstok
            // 
            this.txtstok.BorderColor = System.Drawing.SystemColors.Highlight;
            this.txtstok.BorderRadius = 10;
            this.txtstok.BorderThickness = 3;
            this.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstok.DefaultText = "";
            this.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstok.ForeColor = System.Drawing.Color.Black;
            this.txtstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.Location = new System.Drawing.Point(693, 66);
            this.txtstok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstok.Name = "txtstok";
            this.txtstok.PlaceholderText = "Masukkan Stok kendaraan";
            this.txtstok.SelectedText = "";
            this.txtstok.Size = new System.Drawing.Size(286, 60);
            this.txtstok.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Stok";
            // 
            // IDK
            // 
            this.IDK.HeaderText = "IDK";
            this.IDK.MinimumWidth = 8;
            this.IDK.Name = "IDK";
            this.IDK.Width = 150;
            // 
            // Merk
            // 
            this.Merk.HeaderText = "Merk";
            this.Merk.MinimumWidth = 8;
            this.Merk.Name = "Merk";
            this.Merk.Width = 150;
            // 
            // Tipe
            // 
            this.Tipe.HeaderText = "Tipe";
            this.Tipe.MinimumWidth = 8;
            this.Tipe.Name = "Tipe";
            this.Tipe.Width = 150;
            // 
            // Tahun
            // 
            this.Tahun.HeaderText = "Tahun";
            this.Tahun.MinimumWidth = 8;
            this.Tahun.Name = "Tahun";
            this.Tahun.Width = 150;
            // 
            // Warna
            // 
            this.Warna.HeaderText = "Warna";
            this.Warna.MinimumWidth = 8;
            this.Warna.Name = "Warna";
            this.Warna.Width = 150;
            // 
            // Harga
            // 
            this.Harga.HeaderText = "Harga";
            this.Harga.MinimumWidth = 8;
            this.Harga.Name = "Harga";
            this.Harga.Width = 150;
            // 
            // Stok
            // 
            this.Stok.HeaderText = "Stok";
            this.Stok.MinimumWidth = 8;
            this.Stok.Name = "Stok";
            this.Stok.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 150;
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "";
            this.Hapus.Image = ((System.Drawing.Image)(resources.GetObject("Hapus.Image")));
            this.Hapus.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Hapus.MinimumWidth = 8;
            this.Hapus.Name = "Hapus";
            this.Hapus.Width = 150;
            // 
            // Kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.panel2);
            this.Name = "Kendaraan";
            this.Text = "Kendaraan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtmerk;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtharga;
        private Guna.UI2.WinForms.Guna2Button button1;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnTampil;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox txtwarna;
        private Guna.UI2.WinForms.Guna2TextBox txttahun;
        private Guna.UI2.WinForms.Guna2TextBox txttipe;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtstok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Merk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tahun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Hapus;
    }
}