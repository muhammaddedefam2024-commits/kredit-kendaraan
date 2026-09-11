
namespace Kredit_Kendaraan
{
    partial class Fuser
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.lblSidebarSub = new System.Windows.Forms.Label();
            this.pnlSidebarDivider = new System.Windows.Forms.Panel();
            this.btnKreditSaya = new Guna.UI2.WinForms.Guna2Button();
            this.btnRiwayat = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.guna2Panel3.Controls.Add(this.lblSidebarTitle);
            this.guna2Panel3.Controls.Add(this.lblSidebarSub);
            this.guna2Panel3.Controls.Add(this.pnlSidebarDivider);
            this.guna2Panel3.Controls.Add(this.btnKreditSaya);
            this.guna2Panel3.Controls.Add(this.btnRiwayat);
            this.guna2Panel3.Controls.Add(this.btnLogout);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(220, 1170);
            this.guna2Panel3.TabIndex = 2;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(16, 22);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(188, 26);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Kredit Kendaraan";
            // 
            // lblSidebarSub
            // 
            this.lblSidebarSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSidebarSub.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSidebarSub.Location = new System.Drawing.Point(16, 50);
            this.lblSidebarSub.Name = "lblSidebarSub";
            this.lblSidebarSub.Size = new System.Drawing.Size(188, 18);
            this.lblSidebarSub.TabIndex = 1;
            this.lblSidebarSub.Text = "Portal Nasabah";
            // 
            // pnlSidebarDivider
            // 
            this.pnlSidebarDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlSidebarDivider.Location = new System.Drawing.Point(16, 76);
            this.pnlSidebarDivider.Name = "pnlSidebarDivider";
            this.pnlSidebarDivider.Size = new System.Drawing.Size(188, 1);
            this.pnlSidebarDivider.TabIndex = 99;
            // 
            // btnKreditSaya
            // 
            this.btnKreditSaya.BorderRadius = 8;
            this.btnKreditSaya.FillColor = System.Drawing.Color.Transparent;
            this.btnKreditSaya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKreditSaya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnKreditSaya.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnKreditSaya.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnKreditSaya.Location = new System.Drawing.Point(0, 107);
            this.btnKreditSaya.Name = "btnKreditSaya";
            this.btnKreditSaya.Size = new System.Drawing.Size(220, 40);
            this.btnKreditSaya.TabIndex = 2;
            this.btnKreditSaya.Text = "   Kredit Saya";
            this.btnKreditSaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKreditSaya.Click += new System.EventHandler(this.btnKreditSaya_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BorderRadius = 8;
            this.btnRiwayat.FillColor = System.Drawing.Color.Transparent;
            this.btnRiwayat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRiwayat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnRiwayat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btnRiwayat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.Location = new System.Drawing.Point(0, 153);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Size = new System.Drawing.Size(220, 40);
            this.btnRiwayat.TabIndex = 3;
            this.btnRiwayat.Text = "   Riwayat Cicilan";
            this.btnRiwayat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 1130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1704, 1170);
            this.pnlContent.TabIndex = 1;
            // 
            // Fuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.guna2Panel3);
            this.Name = "Fuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredit Kendaraan — User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel  guna2Panel3;
        private System.Windows.Forms.Label    lblSidebarTitle;
        private System.Windows.Forms.Label    lblSidebarSub;
        private System.Windows.Forms.Panel    pnlSidebarDivider;
        private Guna.UI2.WinForms.Guna2Button btnKreditSaya;
        private Guna.UI2.WinForms.Guna2Button btnRiwayat;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel  pnlContent;
    }
}
