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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FSAB4G1\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komutMesajlar = new SqlCommand("select * from Mesajlar",baglanti);
            SqlDataReader oku = komutMesajlar.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajId"].ToString();
                ekle.SubItems.Add(oku["adSoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnMesajlarKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(adSoyad,mesaj) values('" + txtAdSoyad.Text + "','" + richTextMesaj.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
