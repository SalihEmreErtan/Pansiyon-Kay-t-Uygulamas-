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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            #region hesapla
            int personel = Convert.ToInt16(textBoxPersonelSayı.Text);
            lblPersonelMaas.Text = (personel * 1500).ToString();
            #endregion

            #region sonuc
            int sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt16(lblPersonelMaas.Text) + Convert.ToInt16(lblAlinanUrunler1.Text) + Convert.ToInt16(lblAlinanUrunler2.Text) + Convert.ToInt16(lblFaturalar1.Text) + Convert.ToInt16(lblFaturalar2.Text) + Convert.ToInt16(lblFaturalar3.Text));
            lblSonuc.Text = sonuc.ToString();
            #endregion
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            #region kasada ki toplam tutar
            baglanti.Open();
            SqlCommand komutKasaTop = new SqlCommand("select sum(ucret) as toplam1 from MusteriEkle", baglanti);
            SqlDataReader okuKasaTop = komutKasaTop.ExecuteReader();

            while (okuKasaTop.Read())
            {
                lblKasaToplam.Text = okuKasaTop["toplam1"].ToString();
            }
            baglanti.Close();
            #endregion


            #region gıdalar
            baglanti.Open();
            SqlCommand komutgidalar = new SqlCommand("select sum(gida) as toplam2 from Stoklar", baglanti);
            SqlDataReader okuGida = komutgidalar.ExecuteReader();

            while (okuGida.Read())
            {
                lblAlinanUrunler1.Text = okuGida["toplam2"].ToString();
            }
            baglanti.Close();
            #endregion


            #region ıcecek
            baglanti.Open();
            SqlCommand komutIcecekler = new SqlCommand("select sum(icecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader okuIcecek = komutIcecekler.ExecuteReader();

            while (okuIcecek.Read())
            {
                lblAlinanUrunler2.Text = okuIcecek["toplam3"].ToString();
            }
            baglanti.Close();
            #endregion


            #region elektrik faturası
            baglanti.Open();
            SqlCommand komutElektrik = new SqlCommand("select sum(elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader okuElektrik = komutElektrik.ExecuteReader();

            while (okuElektrik.Read())
            {
                lblFaturalar1.Text = okuElektrik["toplam4"].ToString();
            }
            baglanti.Close();
            #endregion


            #region su faturası
            baglanti.Open();
            SqlCommand komutSu = new SqlCommand("select sum(su) as toplam5 from Faturalar", baglanti);
            SqlDataReader okuSu = komutSu.ExecuteReader();

            while (okuSu.Read())
            {
                lblFaturalar2.Text = okuSu["toplam5"].ToString();
            }
            baglanti.Close();
            #endregion


            #region internet faturası
            baglanti.Open();
            SqlCommand komutInternet = new SqlCommand("select sum(internet) as toplam6 from Faturalar", baglanti);
            SqlDataReader okuInternet = komutInternet.ExecuteReader();

            while (okuInternet.Read())
            {
                lblFaturalar3.Text = okuInternet["toplam6"].ToString();
            }
            baglanti.Close();
            #endregion




        }
    }
}
