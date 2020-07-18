using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ege_Pansiyon_v._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();    // yeni forma gönderme işlemi
            this.Hide();  // FrmAdminGiris gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMus = new FrmYeniMusteri();
            frmYeniMus.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusGit = new FrmMusteriler();
            frmMusGit.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ege Pansiyon Kayıt Uygulaması / 2020 - İstanbul");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOda = new FrmOdalar();
            frmOda.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            tmrTarihZaman.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTarih.Text = DateTime.Now.ToLongDateString();
            lbSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGelirGiderFormu_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            frm.Show();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            frm.Show();
        }

        private void btnRadyodinle_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle frmYeniMus = new FrmRadyoDinle();
            frmYeniMus.Show();
        }

        private void btnGazeteler_Click(object sender, EventArgs e)
        {
            FrmGazeteler frmGazete = new FrmGazeteler();
            frmGazete.Show();
        }

        private void btnHavadurumu_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frmSifreGun = new FrmSifreGuncelle();
            frmSifreGun.Show();
        }

        private void btnMusterimesajlari_Click(object sender, EventArgs e)
        {
            FrmMesajlar frmMesaj = new FrmMesajlar();
            frmMesaj.Show();
        }
    }
}
