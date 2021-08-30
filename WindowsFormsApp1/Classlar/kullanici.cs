using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classlar
{
	class kullanici
	{

		SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - S5DON3B; Initial Catalog = telefonsatisotomasyonu; Integrated Security = True; Pooling=False");

		private string adisoyadi;
		private string telefon;
		string adres;
		string email;
		string kullaniciAdi;
		string sifre;
		string gorevi;
		string resim;

		public string Adisoyadi { get => adisoyadi; set => adisoyadi = value; }
		public string Telefon { get => telefon; set => telefon = value; }
		public string Adres { get => adres; set => adres = value; }
		public string Email { get => email; set => email = value; }
		public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
		public string Sifre { get => sifre; set => sifre = value; }
		public string Gorevi { get => gorevi; set => gorevi = value; }
		public string Resim { get => resim; set => resim = value; }

		public void kullaniciGirisi()
		{

		}
	}
}



