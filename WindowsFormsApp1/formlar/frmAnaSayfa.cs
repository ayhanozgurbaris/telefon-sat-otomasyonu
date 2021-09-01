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
	public partial class frmAnaSayfa : Form
	{
		public frmAnaSayfa()
		{
			InitializeComponent();
		}

		//iç içe form açma
		private void FormGetir(Form frm)
		{
			panelSayfalar.Controls.Clear();
			frm.MdiParent = this;  //yeni form(frm) bu(this) panelin alt forumu
			frm.FormBorderStyle = FormBorderStyle.None;  //içteki formu sabitle
			frm.Dock = DockStyle.Left;
			panelSayfalar.Controls.Add(frm); //ana sayfanın altındaki panelin adı(oraya yükle)
			frm.Show();
		}

		private void frmAnaSayfa_Load(object sender, EventArgs e)
		{

		}

		//anaSayfa telefon ekle
		private void btnTelefonEkle_Click(object sender, EventArgs e)
		{
			yeniTelefonEkle telekle = new yeniTelefonEkle(); 
			FormGetir(telekle);
		}


		//anaSayfa kullanıcı ekle
		private void btnKullaniciEkle_Click(object sender, EventArgs e)
		{
			frmYeniKullanici yeni = new frmYeniKullanici();
			FormGetir(yeni);
		}
	}
}
