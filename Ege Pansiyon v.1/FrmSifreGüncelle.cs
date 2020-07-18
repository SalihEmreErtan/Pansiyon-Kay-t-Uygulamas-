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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FSAB4G1\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("update AdminGiris set kullanici='" + txtKullaniciAdi.Text + "',sifre='" + txtKullaniciSifre.Text + "'", baglanti);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();    
        }
    }
}
