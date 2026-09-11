
namespace Kredit_Kendaraan
{
    partial class FormDataMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSub = new System.Windows.Forms.Label();
            this.pnlHeaderDivider = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPengguna = new System.Windows.Forms.TabPage();
            this.pnlPengguna = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFormPengguna = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleFormPeng = new System.Windows.Forms.Label();
            this.lblNamaUser = new System.Windows.Forms.Label();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUsernameInput = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPasswordInput = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRoleInput = new System.Windows.Forms.Label();
            this.cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpanUser = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTampil = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTablePengguna = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTablePengTitle = new System.Windows.Forms.Label();
            this.DataMaster = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ussername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.q = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.pnlRole = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFormRole = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitleFormRole = new System.Windows.Forms.Label();
            this.lblNamaRole = new System.Windows.Forms.Label();
            this.txtRole = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSimpanRole = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTableRole = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTableRoleTitle = new System.Windows.Forms.Label();
            this.DataRole = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPengguna.SuspendLayout();
            this.pnlPengguna.SuspendLayout();
            this.pnlFormPengguna.SuspendLayout();
            this.pnlTablePengguna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMaster)).BeginInit();
            this.tabRole.SuspendLayout();
            this.pnlRole.SuspendLayout();
            this.pnlFormRole.SuspendLayout();
            this.pnlTableRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataRole)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblFormSub);
            this.pnlHeader.Controls.Add(this.pnlHeaderDivider);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1911, 88);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblFormTitle.Location = new System.Drawing.Point(24, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(400, 52);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Data Master";
            // 
            // lblFormSub
            // 
            this.lblFormSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFormSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFormSub.Location = new System.Drawing.Point(27, 62);
            this.lblFormSub.Name = "lblFormSub";
            this.lblFormSub.Size = new System.Drawing.Size(500, 22);
            this.lblFormSub.TabIndex = 1;
            this.lblFormSub.Text = "Kelola data pengguna dan role sistem";
            // 
            // pnlHeaderDivider
            // 
            this.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlHeaderDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeaderDivider.Location = new System.Drawing.Point(0, 86);
            this.pnlHeaderDivider.Name = "pnlHeaderDivider";
            this.pnlHeaderDivider.Size = new System.Drawing.Size(1911, 2);
            this.pnlHeaderDivider.TabIndex = 99;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPengguna);
            this.tabControl.Controls.Add(this.tabRole);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(0, 88);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1911, 694);
            this.tabControl.TabIndex = 1;
            // 
            // tabPengguna
            // 
            this.tabPengguna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabPengguna.Controls.Add(this.pnlPengguna);
            this.tabPengguna.Location = new System.Drawing.Point(4, 34);
            this.tabPengguna.Name = "tabPengguna";
            this.tabPengguna.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPengguna.Size = new System.Drawing.Size(1903, 656);
            this.tabPengguna.TabIndex = 0;
            this.tabPengguna.Text = "  Pengguna  ";
            // 
            // pnlPengguna
            // 
            this.pnlPengguna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlPengguna.Controls.Add(this.pnlFormPengguna);
            this.pnlPengguna.Controls.Add(this.pnlTablePengguna);
            this.pnlPengguna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPengguna.Location = new System.Drawing.Point(3, 3);
            this.pnlPengguna.Name = "pnlPengguna";
            this.pnlPengguna.Size = new System.Drawing.Size(1897, 650);
            this.pnlPengguna.TabIndex = 0;
            // 
            // pnlFormPengguna
            // 
            this.pnlFormPengguna.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormPengguna.BorderRadius = 12;
            this.pnlFormPengguna.Controls.Add(this.BtnUpdate);
            this.pnlFormPengguna.Controls.Add(this.lblTitleFormPeng);
            this.pnlFormPengguna.Controls.Add(this.lblNamaUser);
            this.pnlFormPengguna.Controls.Add(this.txtNama);
            this.pnlFormPengguna.Controls.Add(this.lblUsernameInput);
            this.pnlFormPengguna.Controls.Add(this.txtUsername);
            this.pnlFormPengguna.Controls.Add(this.lblPasswordInput);
            this.pnlFormPengguna.Controls.Add(this.txtPassword);
            this.pnlFormPengguna.Controls.Add(this.lblRoleInput);
            this.pnlFormPengguna.Controls.Add(this.cmbRole);
            this.pnlFormPengguna.Controls.Add(this.btnSimpanUser);
            this.pnlFormPengguna.Controls.Add(this.BtnTampil);
            this.pnlFormPengguna.Location = new System.Drawing.Point(20, 20);
            this.pnlFormPengguna.Name = "pnlFormPengguna";
            this.pnlFormPengguna.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlFormPengguna.ShadowDecoration.Depth = 10;
            this.pnlFormPengguna.ShadowDecoration.Enabled = true;
            this.pnlFormPengguna.Size = new System.Drawing.Size(420, 540);
            this.pnlFormPengguna.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnUpdate.BorderRadius = 8;
            this.BtnUpdate.FillColor = System.Drawing.Color.LightCoral;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.BtnUpdate.Location = new System.Drawing.Point(146, 372);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(118, 40);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblTitleFormPeng
            // 
            this.lblTitleFormPeng.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleFormPeng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitleFormPeng.Location = new System.Drawing.Point(18, 18);
            this.lblTitleFormPeng.Name = "lblTitleFormPeng";
            this.lblTitleFormPeng.Size = new System.Drawing.Size(384, 26);
            this.lblTitleFormPeng.TabIndex = 0;
            this.lblTitleFormPeng.Text = "Form Pengguna";
            // 
            // lblNamaUser
            // 
            this.lblNamaUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNamaUser.Location = new System.Drawing.Point(18, 58);
            this.lblNamaUser.Name = "lblNamaUser";
            this.lblNamaUser.Size = new System.Drawing.Size(384, 20);
            this.lblNamaUser.TabIndex = 1;
            this.lblNamaUser.Text = "Nama Lengkap";
            // 
            // txtNama
            // 
            this.txtNama.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtNama.BorderRadius = 8;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtNama.Location = new System.Drawing.Point(18, 82);
            this.txtNama.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "Masukkan nama lengkap";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(384, 40);
            this.txtNama.TabIndex = 0;
            // 
            // lblUsernameInput
            // 
            this.lblUsernameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsernameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblUsernameInput.Location = new System.Drawing.Point(18, 134);
            this.lblUsernameInput.Name = "lblUsernameInput";
            this.lblUsernameInput.Size = new System.Drawing.Size(384, 20);
            this.lblUsernameInput.TabIndex = 2;
            this.lblUsernameInput.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtUsername.Location = new System.Drawing.Point(18, 158);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Masukkan username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(384, 40);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPasswordInput
            // 
            this.lblPasswordInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPasswordInput.Location = new System.Drawing.Point(18, 209);
            this.lblPasswordInput.Name = "lblPasswordInput";
            this.lblPasswordInput.Size = new System.Drawing.Size(384, 20);
            this.lblPasswordInput.TabIndex = 3;
            this.lblPasswordInput.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtPassword.BorderRadius = 8;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtPassword.Location = new System.Drawing.Point(18, 234);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Masukkan password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(384, 40);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRoleInput
            // 
            this.lblRoleInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRoleInput.Location = new System.Drawing.Point(18, 286);
            this.lblRoleInput.Name = "lblRoleInput";
            this.lblRoleInput.Size = new System.Drawing.Size(384, 20);
            this.lblRoleInput.TabIndex = 4;
            this.lblRoleInput.Text = "Role";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.White;
            this.cmbRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cmbRole.BorderRadius = 8;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cmbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbRole.ItemHeight = 30;
            this.cmbRole.Location = new System.Drawing.Point(18, 309);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(384, 36);
            this.cmbRole.TabIndex = 3;
            this.cmbRole.DropDown += new System.EventHandler(this.cmbRole_DropDown);
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            this.cmbRole.DropDownClosed += new System.EventHandler(this.cmbRole_DropDownClosed);
            // 
            // btnSimpanUser
            // 
            this.btnSimpanUser.BorderRadius = 8;
            this.btnSimpanUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpanUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpanUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanUser.ForeColor = System.Drawing.Color.White;
            this.btnSimpanUser.Location = new System.Drawing.Point(18, 372);
            this.btnSimpanUser.Name = "btnSimpanUser";
            this.btnSimpanUser.Size = new System.Drawing.Size(118, 40);
            this.btnSimpanUser.TabIndex = 4;
            this.btnSimpanUser.Text = "Simpan";
            this.btnSimpanUser.Click += new System.EventHandler(this.btnSimpanUser_Click_1);
            // 
            // BtnTampil
            // 
            this.BtnTampil.BorderRadius = 8;
            this.BtnTampil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.BtnTampil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnTampil.ForeColor = System.Drawing.Color.White;
            this.BtnTampil.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.BtnTampil.Location = new System.Drawing.Point(278, 372);
            this.BtnTampil.Name = "BtnTampil";
            this.BtnTampil.Size = new System.Drawing.Size(118, 40);
            this.BtnTampil.TabIndex = 6;
            this.BtnTampil.Text = "Tampil";
            this.BtnTampil.Click += new System.EventHandler(this.btnBersihUser_Click);
            // 
            // pnlTablePengguna
            // 
            this.pnlTablePengguna.BackColor = System.Drawing.Color.Transparent;
            this.pnlTablePengguna.BorderRadius = 12;
            this.pnlTablePengguna.Controls.Add(this.label1);
            this.pnlTablePengguna.Controls.Add(this.lblTablePengTitle);
            this.pnlTablePengguna.Controls.Add(this.DataMaster);
            this.pnlTablePengguna.Location = new System.Drawing.Point(460, 20);
            this.pnlTablePengguna.Name = "pnlTablePengguna";
            this.pnlTablePengguna.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTablePengguna.ShadowDecoration.Depth = 10;
            this.pnlTablePengguna.ShadowDecoration.Enabled = true;
            this.pnlTablePengguna.Size = new System.Drawing.Size(1430, 1040);
            this.pnlTablePengguna.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lblTablePengTitle
            // 
            this.lblTablePengTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTablePengTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTablePengTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTablePengTitle.Name = "lblTablePengTitle";
            this.lblTablePengTitle.Size = new System.Drawing.Size(400, 26);
            this.lblTablePengTitle.TabIndex = 0;
            this.lblTablePengTitle.Text = "Daftar Pengguna";
            // 
            // DataMaster
            // 
            this.DataMaster.AllowUserToAddRows = false;
            this.DataMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.DataMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMaster.BackgroundColor = System.Drawing.Color.White;
            this.DataMaster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataMaster.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataMaster.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.DataMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataMaster.ColumnHeadersHeight = 38;
            this.DataMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Nama,
            this.Ussername,
            this.Role,
            this.Edit,
            this.Delete,
            this.q});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataMaster.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataMaster.EnableHeadersVisualStyles = false;
            this.DataMaster.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.DataMaster.Location = new System.Drawing.Point(16, 49);
            this.DataMaster.Name = "DataMaster";
            this.DataMaster.ReadOnly = true;
            this.DataMaster.RowHeadersVisible = false;
            this.DataMaster.RowHeadersWidth = 62;
            this.DataMaster.RowTemplate.Height = 38;
            this.DataMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataMaster.Size = new System.Drawing.Size(1398, 974);
            this.DataMaster.TabIndex = 1;
            this.DataMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMaster_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 8;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = " Nama";
            this.Nama.MinimumWidth = 8;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Ussername
            // 
            this.Ussername.HeaderText = "Ussername";
            this.Ussername.MinimumWidth = 8;
            this.Ussername.Name = "Ussername";
            this.Ussername.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // q
            // 
            this.q.HeaderText = "";
            this.q.MinimumWidth = 8;
            this.q.Name = "q";
            this.q.ReadOnly = true;
            // 
            // tabRole
            // 
            this.tabRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.tabRole.Controls.Add(this.pnlRole);
            this.tabRole.Location = new System.Drawing.Point(4, 34);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRole.Size = new System.Drawing.Size(1903, 656);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "  Role  ";
            // 
            // pnlRole
            // 
            this.pnlRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlRole.Controls.Add(this.pnlFormRole);
            this.pnlRole.Controls.Add(this.pnlTableRole);
            this.pnlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRole.Location = new System.Drawing.Point(3, 3);
            this.pnlRole.Name = "pnlRole";
            this.pnlRole.Size = new System.Drawing.Size(1897, 650);
            this.pnlRole.TabIndex = 0;
            // 
            // pnlFormRole
            // 
            this.pnlFormRole.BackColor = System.Drawing.Color.Transparent;
            this.pnlFormRole.BorderRadius = 12;
            this.pnlFormRole.Controls.Add(this.guna2Button1);
            this.pnlFormRole.Controls.Add(this.lblTitleFormRole);
            this.pnlFormRole.Controls.Add(this.lblNamaRole);
            this.pnlFormRole.Controls.Add(this.txtRole);
            this.pnlFormRole.Controls.Add(this.btnSimpanRole);
            this.pnlFormRole.Location = new System.Drawing.Point(20, 20);
            this.pnlFormRole.Name = "pnlFormRole";
            this.pnlFormRole.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlFormRole.ShadowDecoration.Depth = 10;
            this.pnlFormRole.ShadowDecoration.Enabled = true;
            this.pnlFormRole.Size = new System.Drawing.Size(420, 260);
            this.pnlFormRole.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(152, 142);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 40);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Tampil";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblTitleFormRole
            // 
            this.lblTitleFormRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleFormRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTitleFormRole.Location = new System.Drawing.Point(18, 18);
            this.lblTitleFormRole.Name = "lblTitleFormRole";
            this.lblTitleFormRole.Size = new System.Drawing.Size(384, 26);
            this.lblTitleFormRole.TabIndex = 0;
            this.lblTitleFormRole.Text = "Form Role";
            // 
            // lblNamaRole
            // 
            this.lblNamaRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNamaRole.Location = new System.Drawing.Point(18, 58);
            this.lblNamaRole.Name = "lblNamaRole";
            this.lblNamaRole.Size = new System.Drawing.Size(384, 20);
            this.lblNamaRole.TabIndex = 1;
            this.lblNamaRole.Text = "Nama Role";
            // 
            // txtRole
            // 
            this.txtRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtRole.BorderRadius = 8;
            this.txtRole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRole.DefaultText = "";
            this.txtRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtRole.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.txtRole.Location = new System.Drawing.Point(18, 82);
            this.txtRole.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtRole.Name = "txtRole";
            this.txtRole.PlaceholderText = "Masukkan nama role";
            this.txtRole.SelectedText = "";
            this.txtRole.Size = new System.Drawing.Size(384, 40);
            this.txtRole.TabIndex = 0;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // btnSimpanRole
            // 
            this.btnSimpanRole.BorderRadius = 8;
            this.btnSimpanRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSimpanRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpanRole.ForeColor = System.Drawing.Color.White;
            this.btnSimpanRole.Location = new System.Drawing.Point(18, 142);
            this.btnSimpanRole.Name = "btnSimpanRole";
            this.btnSimpanRole.Size = new System.Drawing.Size(118, 40);
            this.btnSimpanRole.TabIndex = 1;
            this.btnSimpanRole.Text = "Simpan";
            this.btnSimpanRole.Click += new System.EventHandler(this.btnSimpanRole_Click_1);
            // 
            // pnlTableRole
            // 
            this.pnlTableRole.BackColor = System.Drawing.Color.Transparent;
            this.pnlTableRole.BorderRadius = 12;
            this.pnlTableRole.Controls.Add(this.lblTableRoleTitle);
            this.pnlTableRole.Controls.Add(this.DataRole);
            this.pnlTableRole.Location = new System.Drawing.Point(460, 20);
            this.pnlTableRole.Name = "pnlTableRole";
            this.pnlTableRole.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTableRole.ShadowDecoration.Depth = 10;
            this.pnlTableRole.ShadowDecoration.Enabled = true;
            this.pnlTableRole.Size = new System.Drawing.Size(1430, 1040);
            this.pnlTableRole.TabIndex = 1;
            // 
            // lblTableRoleTitle
            // 
            this.lblTableRoleTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTableRoleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTableRoleTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTableRoleTitle.Name = "lblTableRoleTitle";
            this.lblTableRoleTitle.Size = new System.Drawing.Size(400, 26);
            this.lblTableRoleTitle.TabIndex = 0;
            this.lblTableRoleTitle.Text = "Daftar Role";
            // 
            // DataRole
            // 
            this.DataRole.AllowUserToAddRows = false;
            this.DataRole.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.DataRole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataRole.BackgroundColor = System.Drawing.Color.White;
            this.DataRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataRole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.DataRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataRole.ColumnHeadersHeight = 38;
            this.DataRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataRole.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataRole.EnableHeadersVisualStyles = false;
            this.DataRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.DataRole.Location = new System.Drawing.Point(16, 49);
            this.DataRole.Name = "DataRole";
            this.DataRole.ReadOnly = true;
            this.DataRole.RowHeadersVisible = false;
            this.DataRole.RowHeadersWidth = 62;
            this.DataRole.RowTemplate.Height = 38;
            this.DataRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataRole.Size = new System.Drawing.Size(1398, 974);
            this.DataRole.TabIndex = 1;
            this.DataRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // FormDataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1911, 782);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FormDataMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredit Kendaraan — Data Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPengguna.ResumeLayout(false);
            this.pnlPengguna.ResumeLayout(false);
            this.pnlFormPengguna.ResumeLayout(false);
            this.pnlTablePengguna.ResumeLayout(false);
            this.pnlTablePengguna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMaster)).EndInit();
            this.tabRole.ResumeLayout(false);
            this.pnlRole.ResumeLayout(false);
            this.pnlFormRole.ResumeLayout(false);
            this.pnlTableRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel   pnlHeader;
        private System.Windows.Forms.Label     lblFormTitle;
        private System.Windows.Forms.Label     lblFormSub;
        private System.Windows.Forms.Panel     pnlHeaderDivider;
        private System.Windows.Forms.TabControl  tabControl;
        private System.Windows.Forms.TabPage     tabPengguna;
        private System.Windows.Forms.TabPage     tabRole;
        private Guna.UI2.WinForms.Guna2Panel   pnlPengguna;
        private Guna.UI2.WinForms.Guna2Panel   pnlFormPengguna;
        private System.Windows.Forms.Label     lblTitleFormPeng;
        private System.Windows.Forms.Label     lblNamaUser;
        private Guna.UI2.WinForms.Guna2TextBox  txtNama;
        private System.Windows.Forms.Label     lblUsernameInput;
        private Guna.UI2.WinForms.Guna2TextBox  txtUsername;
        private System.Windows.Forms.Label     lblPasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox  txtPassword;
        private System.Windows.Forms.Label     lblRoleInput;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2Button   btnSimpanUser;
        private Guna.UI2.WinForms.Guna2Button   BtnTampil;
        private Guna.UI2.WinForms.Guna2Panel   pnlTablePengguna;
        private System.Windows.Forms.Label     lblTablePengTitle;
        private System.Windows.Forms.DataGridView DataMaster;
        private Guna.UI2.WinForms.Guna2Panel   pnlRole;
        private Guna.UI2.WinForms.Guna2Panel   pnlFormRole;
        private System.Windows.Forms.Label     lblTitleFormRole;
        private System.Windows.Forms.Label     lblNamaRole;
        private Guna.UI2.WinForms.Guna2TextBox  txtRole;
        private Guna.UI2.WinForms.Guna2Button   btnSimpanRole;
        private Guna.UI2.WinForms.Guna2Panel   pnlTableRole;
        private System.Windows.Forms.Label     lblTableRoleTitle;
        private System.Windows.Forms.DataGridView DataRole;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ussername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn q;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
