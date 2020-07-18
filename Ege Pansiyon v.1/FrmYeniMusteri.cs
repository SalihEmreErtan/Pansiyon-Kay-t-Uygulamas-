using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;        // sql
using System.Data.SqlClient;  // sql

namespace Ege_Pansiyon_v._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");
        // tek slaş işareti(\) kaçış komutunu ifade eder 
        // çift slaş (\\ adres komutunu işaret eder)
        // dip not eğer bağlantı içerisinde birden faza slaş işareti varsa parantez içinde ki çift tırnak başına @ işareti konur.
        // bu şekilde @ kullanımı ile yazılan komutun adres yolunu ifade ettiği söylenmiş olur  
        
        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "101";

            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn101 = new SqlCommand("insert into oda101 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text +"')",baglanti);
                komutbtn101.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "102";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn102 = new SqlCommand("insert into oda102 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn102.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "103";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn103 = new SqlCommand("insert into oda103 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn103.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "104";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn104 = new SqlCommand("insert into oda104 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn104.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "105";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn105 = new SqlCommand("insert into oda105 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn105.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    
        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "106";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn106 = new SqlCommand("insert into oda106 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn106.ExecuteNonQuery();
                baglanti.Close();
            }
        }
    
        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "107";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn107 = new SqlCommand("insert into oda107 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn107.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "108";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn108 = new SqlCommand("insert into oda108 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn108.ExecuteNonQuery();
                baglanti.Close();
            }
        }  

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNo.Text = "109";
            if (txtAdi.Text != "")
            {
                baglanti.Open();
                SqlCommand komutbtn109 = new SqlCommand("insert into oda109 (adi,soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
                komutbtn109.ExecuteNonQuery();
                baglanti.Close();
            }

        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir. ");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir. ");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);   // DateTime pickerlearın textini aldık
            DateTime buyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);   // DateTime pickerlearın textini aldık

            TimeSpan sonuc = buyukTarih - kucukTarih;   // TimeSpan tarihler arasındaki farkı alır

            gun_hesaplama.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(gun_hesaplama.Text) * 50;
            txtUcret1.Text = ucret.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();   // pasif olan balantıyı açma işlemi
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (adi,soyadi,cinsiyet,telefon,mail,tc,odaNo,ucret,girisTarihi,cikisTarihi) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + comboBox1.Text + "','"+ mskTxtTelefon.Text+"','"+ txtMail.Text + "','"+ txtKimlikNo.Text + "','"+ txtOdaNo.Text + "','"+ txtUcret1.Text + "','"+ dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','"+ dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();   
            baglanti.Close();
            // ExecuteNonQuery ile gönderilen parametrelerde değişiklik yapılır.silme ,güncelleme işlemleri..
            MessageBox.Show("Müşteri kaydı yapıldı.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            #region oda101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnOda101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
            }
            #endregion

            #region oda102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnOda102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
                btnOda102.Enabled = false;
            }
            #endregion

            #region oda103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnOda103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
                btnOda103.Enabled = false;
            }
            #endregion

            #region oda104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnOda104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
                btnOda104.Enabled = false;
            }
            #endregion

            #region oda105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btnOda105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
                btnOda105.Enabled = false;
            }
            #endregion

            #region oda106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btnOda106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
                btnOda106.Enabled = false;
            }
            #endregion

            #region oda107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnOda107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
                btnOda107.Enabled = false;
            }
            #endregion

            #region oda108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btnOda108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
                btnOda108.Enabled = false;
            }
            #endregion

            #region oda109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                grpOdalar.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();

            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
                btnOda109.Enabled = false;
            }
            #endregion
        }
    }
}

//Data Source=.\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True
// (truncate table MusteriEkle)  komutu ile musteriId columunda ki 1 den 102 ye çıkma hatasını çözebiliriz.komple database i temizler 
// checkındb ile aynu hatanın çözümü mümkündür.