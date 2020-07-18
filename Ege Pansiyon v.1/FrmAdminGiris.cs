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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EgePansiyon;Integrated Security=True");

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where kullanici=@kullaniciadi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi",txtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("sifresi", txtKullaniciSifre.Text);
                SqlCommand komutbtnGirisYap = new SqlCommand(sql,baglanti);
                komutbtnGirisYap.Parameters.Add(prm1);
                komutbtnGirisYap.Parameters.Add(prm2);

                
                DataTable dt = new DataTable();                            // sanal tablo oluşturma
                SqlDataAdapter da = new SqlDataAdapter(komutbtnGirisYap);  // sanal tablo içini doldurma
                da.Fill(dt);

                if (dt.Rows.Count >0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
             }
        }
    }
}
