using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ege_Pansiyon_v._1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FSAB4G1\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");

        private void verileriGoster()
        {
;           listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["girisTarihi"].ToString());
                ekle.SubItems.Add(oku["cikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
        int id = 0;

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set adi='"+txtAdi.Text+"',soyadi='"+txtSoyadi.Text+"',cinsiyet='"+comboBox1.Text+"',telefon='"+mskTxtTelefon.Text+ "',mail = '" + txtMail.Text+"', tc = '"+txtKimlikNo.Text+"', odaNo = '"+txtOdaNo.Text+"', ucret = '"+txtUcret1.Text+"', girisTarihi = '"+ dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', cikisTarihi = '"+ dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }
        //dtpGirisTarihi.Value.ToString("yyyy-MM-dd")
         
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut101 = new SqlCommand("delete from oda101", baglanti);
                komut101.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut102 = new SqlCommand("delete from oda102", baglanti);
                komut102.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut103 = new SqlCommand("delete from oda103", baglanti);
                komut103.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut104 = new SqlCommand("delete from oda104", baglanti);
                komut104.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut105 = new SqlCommand("delete from oda105", baglanti);
                komut105.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut106 = new SqlCommand("delete from oda106", baglanti);
                komut106.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut107 = new SqlCommand("delete from oda107", baglanti);
                komut107.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut108 = new SqlCommand("delete from oda108", baglanti);
                komut108.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            if (txtOdaNo.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut109 = new SqlCommand("delete from oda109", baglanti);
                komut109.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            comboBox1.Text = "";
            mskTxtTelefon.Clear();
            txtMail.Text = "";
            txtKimlikNo.Clear();
            txtOdaNo.Clear();
            txtUcret1.Clear();
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where adi like '%"+ txtArama.Text+"%'", baglanti);  // % arama işlemi için kullanılan özel karakter
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odaNo"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["girisTarihi"].ToString());
                ekle.SubItems.Add(oku["cikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
// Data Source=DESKTOP-FSAB4G1\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True