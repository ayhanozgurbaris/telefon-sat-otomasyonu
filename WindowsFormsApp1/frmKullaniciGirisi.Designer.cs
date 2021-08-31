
namespace WindowsFormsApp1
{
	partial class frmKullaniciGirisi
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
			this.labelKullaniciAdi = new System.Windows.Forms.Label();
			this.labelSifre = new System.Windows.Forms.Label();
			this.txtbKullaniciAdi = new System.Windows.Forms.TextBox();
			this.txtbSifre = new System.Windows.Forms.TextBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.btnSifre = new System.Windows.Forms.Button();
			this.checkbGoster = new System.Windows.Forms.CheckBox();
			this.labelYeniKullanici = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelKullaniciAdi
			// 
			this.labelKullaniciAdi.AutoSize = true;
			this.labelKullaniciAdi.Location = new System.Drawing.Point(34, 59);
			this.labelKullaniciAdi.Name = "labelKullaniciAdi";
			this.labelKullaniciAdi.Size = new System.Drawing.Size(84, 17);
			this.labelKullaniciAdi.TabIndex = 0;
			this.labelKullaniciAdi.Text = "Kullanıcı Adı";
			this.labelKullaniciAdi.Click += new System.EventHandler(this.label1_Click);
			// 
			// labelSifre
			// 
			this.labelSifre.AutoSize = true;
			this.labelSifre.Location = new System.Drawing.Point(56, 104);
			this.labelSifre.Name = "labelSifre";
			this.labelSifre.Size = new System.Drawing.Size(37, 17);
			this.labelSifre.TabIndex = 0;
			this.labelSifre.Text = "Şifre";
			// 
			// txtbKullaniciAdi
			// 
			this.txtbKullaniciAdi.Location = new System.Drawing.Point(158, 56);
			this.txtbKullaniciAdi.Name = "txtbKullaniciAdi";
			this.txtbKullaniciAdi.Size = new System.Drawing.Size(224, 22);
			this.txtbKullaniciAdi.TabIndex = 1;
			// 
			// txtbSifre
			// 
			this.txtbSifre.Location = new System.Drawing.Point(158, 101);
			this.txtbSifre.Multiline = true;
			this.txtbSifre.Name = "txtbSifre";
			this.txtbSifre.PasswordChar = '*';
			this.txtbSifre.Size = new System.Drawing.Size(224, 52);
			this.txtbSifre.TabIndex = 2;
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(143, 170);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(109, 63);
			this.btnGiris.TabIndex = 3;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// btnSifre
			// 
			this.btnSifre.Location = new System.Drawing.Point(273, 170);
			this.btnSifre.Name = "btnSifre";
			this.btnSifre.Size = new System.Drawing.Size(109, 63);
			this.btnSifre.TabIndex = 3;
			this.btnSifre.Text = "iptal";
			this.btnSifre.UseVisualStyleBackColor = true;
			this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
			// 
			// checkbGoster
			// 
			this.checkbGoster.AutoSize = true;
			this.checkbGoster.Location = new System.Drawing.Point(430, 80);
			this.checkbGoster.Name = "checkbGoster";
			this.checkbGoster.Size = new System.Drawing.Size(73, 21);
			this.checkbGoster.TabIndex = 4;
			this.checkbGoster.Text = "Göster";
			this.checkbGoster.UseVisualStyleBackColor = true;
			this.checkbGoster.CheckedChanged += new System.EventHandler(this.checkbGoster_CheckedChanged);
			// 
			// labelYeniKullanici
			// 
			this.labelYeniKullanici.AutoSize = true;
			this.labelYeniKullanici.BackColor = System.Drawing.Color.Transparent;
			this.labelYeniKullanici.ForeColor = System.Drawing.Color.Red;
			this.labelYeniKullanici.Location = new System.Drawing.Point(74, 259);
			this.labelYeniKullanici.Name = "labelYeniKullanici";
			this.labelYeniKullanici.Size = new System.Drawing.Size(92, 17);
			this.labelYeniKullanici.TabIndex = 5;
			this.labelYeniKullanici.Text = "Yeni Kullanıcı";
			this.labelYeniKullanici.Click += new System.EventHandler(this.labelYeniKullanici_Click);
			// 
			// frmKullaniciGirisi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LemonChiffon;
			this.ClientSize = new System.Drawing.Size(688, 473);
			this.Controls.Add(this.labelYeniKullanici);
			this.Controls.Add(this.checkbGoster);
			this.Controls.Add(this.btnSifre);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txtbSifre);
			this.Controls.Add(this.txtbKullaniciAdi);
			this.Controls.Add(this.labelSifre);
			this.Controls.Add(this.labelKullaniciAdi);
			this.Name = "frmKullaniciGirisi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kullanıcı Girişi Sayfası";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelKullaniciAdi;
		private System.Windows.Forms.Label labelSifre;
		private System.Windows.Forms.TextBox txtbKullaniciAdi;
		private System.Windows.Forms.TextBox txtbSifre;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.Button btnSifre;
		private System.Windows.Forms.CheckBox checkbGoster;
		private System.Windows.Forms.Label labelYeniKullanici;
	}
}