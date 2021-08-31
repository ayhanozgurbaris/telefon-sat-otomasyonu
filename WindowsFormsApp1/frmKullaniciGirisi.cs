using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frmKullaniciGirisi : Form
	{
		public frmKullaniciGirisi()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnSifre_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void labelYeniKullanici_Click(object sender, EventArgs e)
		{
			frmYeniKullanici yk = new frmYeniKullanici();
			yk.ShowDialog();
		}


		// sifre checkbox
		private void checkbGoster_CheckedChanged(object sender, EventArgs e)
		{
			if (checkbGoster.CheckState == CheckState.Checked)
			{
				txtbSifre.UseSystemPasswordChar = true;
				checkbGoster.Text = "gizle";
			}
			else if (checkbGoster.CheckState == CheckState.Unchecked)
			{
				txtbSifre.UseSystemPasswordChar = false;
				checkbGoster.Text = "göster";
			}
		}

		Classlar.kullanici k = new Classlar.kullanici();
		private void btnGiris_Click(object sender, EventArgs e)
		{
			k.kullaniciGirisi(txtbSifre,txtbKullaniciAdi);

		}
	}
}
