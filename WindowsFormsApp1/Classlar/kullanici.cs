using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classlar
{
	class kullanici
	{

		SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S5DON3B;Initial Catalog=telefonsatisotomasyonu;Integrated Security=True;Pooling=False");

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

		public void kullaniciGirisi(TextBox txtbSifre,TextBox txtbKullaniciAdi)
		{
			
			if (txtbKullaniciAdi.Text=="" || txtbSifre.Text == "")
			{
				MessageBox.Show("kullanıcı adı veya sifre boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); //!!!!
			}
			else
			{
				baglanti.Open();
				SqlCommand komut = new SqlCommand("select * from Kullanici where kullaniciadi='"+txtbKullaniciAdi.Text+"' and sifre = '"+txtbSifre.Text+"'",baglanti);
				SqlDataReader dr = komut.ExecuteReader();
				if(dr.Read())
				{
					frmAnaSayfa anasayfa = new frmAnaSayfa();
					frmKullaniciGirisi.ActiveForm.Visible = false;
					anasayfa.Show();
					
				}
				else
				{
					MessageBox.Show("Kullanıcı adı veya sifrenizi kontrol ediniz!!!", "Uyarı-2",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
				baglanti.Close();
			}
		}


		public void YeniKullanici(string _AdiSoyadi,string _TelNo,string _Adres,string _Email,string _KullaniciAdi,string _Sifre,string _SifreTekrar,string _Gorevi,string _Resim )
		{
			Adisoyadi = _AdiSoyadi;
			Telefon = _TelNo;
			Adres = _Adres;
			Email = _Email;
			KullaniciAdi = _KullaniciAdi;
			Sifre = _Sifre;
			Gorevi = _Gorevi;
			Resim = _Resim;

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into Kullanici values()", baglanti);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("yeni kullanici eklendi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}



