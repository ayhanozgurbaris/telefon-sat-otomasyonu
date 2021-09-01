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
	public partial class frmYeniKullanici : Form
	{
		public frmYeniKullanici()
		{
			InitializeComponent();
		}

		private void frmYeniKullanici_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btniptal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnResimSec_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.ShowDialog();
			if (file.ShowDialog()==DialogResult.OK)		
			{
				pictureBox1.ImageLocation = file.FileName;

			}
		}

		Classlar.kullanici k = new Classlar.kullanici();


		private void btnEkle_Click(object sender, EventArgs e)
		{
			k.YeniKullanici(txtbAdiSoyadi.Text,txtbTelefonNo.Text,txtbAdres.Text,txtbEmail.Text,txtbKullaniciAdi.Text,txtbSifre.Text,txtbSifreTekrar.Text,txtbGorevi.Text,pictureBox1.ImageLocation);
		}
	}
}
