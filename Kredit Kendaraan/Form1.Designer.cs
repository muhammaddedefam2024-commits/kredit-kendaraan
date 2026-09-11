
namespace Kredit_Kendaraan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.lblAppDesc = new System.Windows.Forms.Label();
            this.pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.pnlFormDivider = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.TxtUsser = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.pnlLeft.Controls.Add(this.lblAppTitle);
            this.pnlLeft.Controls.Add(this.lblAppSubtitle);
            this.pnlLeft.Controls.Add(this.lblAppDesc);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(788, 1170);
            this.pnlLeft.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(68, 600);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(652, 100);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Kredit Kendaraan";
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(68, 712);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(652, 45);
            this.lblAppSubtitle.TabIndex = 1;
            this.lblAppSubtitle.Text = "Sistem Manajemen Kredit Kendaraan";
            // 
            // lblAppDesc
            // 
            this.lblAppDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblAppDesc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAppDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAppDesc.Location = new System.Drawing.Point(68, 775);
            this.lblAppDesc.Name = "lblAppDesc";
            this.lblAppDesc.Size = new System.Drawing.Size(652, 75);
            this.lblAppDesc.TabIndex = 2;
            this.lblAppDesc.Text = "Kelola data kredit kendaraan dengan mudah\r\ndan efisien dalam satu platform terpad" +
    "u.";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlRight.Controls.Add(this.pnlCard);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(788, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1136, 1170);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 20;
            this.pnlCard.Controls.Add(this.lblWelcome);
            this.pnlCard.Controls.Add(this.lblWelcomeSub);
            this.pnlCard.Controls.Add(this.pnlFormDivider);
            this.pnlCard.Controls.Add(this.lblUsername);
            this.pnlCard.Controls.Add(this.TxtUsser);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Controls.Add(this.TxtPass);
            this.pnlCard.Controls.Add(this.guna2Button1);
            this.pnlCard.Controls.Add(this.lblFooter);
            this.pnlCard.Location = new System.Drawing.Point(146, 250);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(855, 775);
            this.pnlCard.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWelcome.Location = new System.Drawing.Point(68, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(720, 70);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Selamat Datang";
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWelcomeSub.Location = new System.Drawing.Point(68, 148);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(720, 40);
            this.lblWelcomeSub.TabIndex = 1;
            this.lblWelcomeSub.Text = "Masuk ke akun Anda untuk melanjutkan";
            // 
            // pnlFormDivider
            // 
            this.pnlFormDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.pnlFormDivider.Location = new System.Drawing.Point(68, 202);
            this.pnlFormDivider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFormDivider.Name = "pnlFormDivider";
            this.pnlFormDivider.Size = new System.Drawing.Size(720, 1);
            this.pnlFormDivider.TabIndex = 99;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblUsername.Location = new System.Drawing.Point(68, 232);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(720, 35);
            this.lblUsername.TabIndex = 100;
            this.lblUsername.Text = "Username";
            // 
            // TxtUsser
            // 
            this.TxtUsser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TxtUsser.BorderRadius = 10;
            this.TxtUsser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsser.DefaultText = "";
            this.TxtUsser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TxtUsser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtUsser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.TxtUsser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TxtUsser.Location = new System.Drawing.Point(68, 275);
            this.TxtUsser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsser.Name = "TxtUsser";
            this.TxtUsser.PlaceholderText = "Masukkan username";
            this.TxtUsser.SelectedText = "";
            this.TxtUsser.Size = new System.Drawing.Size(720, 70);
            this.TxtUsser.TabIndex = 0;
            this.TxtUsser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsser_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPassword.Location = new System.Drawing.Point(68, 370);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(720, 35);
            this.lblPassword.TabIndex = 101;
            this.lblPassword.Text = "Password";
            // 
            // TxtPass
            // 
            this.TxtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.TxtPass.BorderRadius = 10;
            this.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPass.DefaultText = "";
            this.TxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TxtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.TxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.TxtPass.Location = new System.Drawing.Point(68, 412);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PlaceholderText = "Masukkan password";
            this.TxtPass.SelectedText = "";
            this.TxtPass.Size = new System.Drawing.Size(720, 70);
            this.TxtPass.TabIndex = 1;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(68, 520);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(720, 72);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Masuk";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFooter.Location = new System.Drawing.Point(68, 625);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(720, 38);
            this.lblFooter.TabIndex = 102;
            this.lblFooter.Text = "© 2026 Kredit Kendaraan — Semua hak dilindungi";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredit Kendaraan — Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel  pnlLeft;
        private Guna.UI2.WinForms.Guna2Panel  pnlRight;
        private Guna.UI2.WinForms.Guna2Panel  pnlCard;
        private System.Windows.Forms.Label    lblAppTitle;
        private System.Windows.Forms.Label    lblAppSubtitle;
        private System.Windows.Forms.Label    lblAppDesc;
        private System.Windows.Forms.Label    lblWelcome;
        private System.Windows.Forms.Label    lblWelcomeSub;
        private System.Windows.Forms.Panel    pnlFormDivider;
        private System.Windows.Forms.Label    lblUsername;
        private System.Windows.Forms.Label    lblPassword;
        private System.Windows.Forms.Label    lblFooter;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsser;
        private Guna.UI2.WinForms.Guna2TextBox TxtPass;
        private Guna.UI2.WinForms.Guna2Button  guna2Button1;
    }
}
