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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");
        
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["gida"].ToString();
                ekle.SubItems.Add(oku["icecek"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["elektrik"].ToString();
                ekle.SubItems.Add(oku2["su"].ToString());
                ekle.SubItems.Add(oku2["internet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(gida,icecek) values('" + txtGidalar.Text+"','"+txtIcecekler.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnTemizle1_Click(object sender, EventArgs e)
        {
            txtGidalar.Clear();
            txtIcecekler.Clear();
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(gida,icecek) values('" + txtGidalar.Text + "','" + txtIcecekler.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            txtElektrik.Clear();
            txtSu.Clear();
            txtInternet.Clear();
        }

        private void btnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(elektrik,su,internet) values('" + txtElektrik.Text + "','" + txtSu.Text + "','"+txtInternet.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
