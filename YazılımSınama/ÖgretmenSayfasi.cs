using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımSınama
{
   
         
    public partial class ÖgretmenSayfasi : Form
    {
        SinavOtomasyonuEntities SinavDB = new SinavOtomasyonuEntities();

        public ÖgretmenSayfasi()
        {
            InitializeComponent();
        }

        private void ÖgretmenSayfasi_Load(object sender, EventArgs e)
        {
            var kategoriler = SinavDB.Tbl_Kategoriler.ToList();
            cmBoxKategori.DataSource = kategoriler;
            cmBoxKategori.DisplayMember = "KategoriAdi";
            cmBoxKategori.ValueMember = "ID";
        }
       
        

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            SoruKaydet();

        }
        void SoruKaydet()
        {
            Tbl_Sorular soruKaydı = new Tbl_Sorular(); //sql baglantı
            soruKaydı.Soru = txtBoxSoruEkle.Text; // sorunun doğruluğunun belirlenemsi

            if(rdbtnA.Checked)
            {
                soruKaydı.DogruSecenek = txtA.Text;
                soruKaydı.Secenek1 = txtB.Text;
                soruKaydı.Secenek2 = txtC.Text;
                soruKaydı.Secenek3 = txtD.Text;
            }
            else if (rdbtnB.Checked)
            {
                soruKaydı.DogruSecenek = txtB.Text;
                soruKaydı.Secenek1 = txtA.Text;
                soruKaydı.Secenek2 = txtC.Text;
                soruKaydı.Secenek3 = txtD.Text;
            }
            else if (rdbtnC.Checked)
            {
                soruKaydı.DogruSecenek = txtC.Text;
                soruKaydı.Secenek1 = txtB.Text;
                soruKaydı.Secenek2 = txtA.Text;
                soruKaydı.Secenek3 = txtD.Text;
            }
            else if (rdbtnD.Checked)
            {
                soruKaydı.DogruSecenek = txtD.Text;
                soruKaydı.Secenek1 = txtB.Text;
                soruKaydı.Secenek2 = txtC.Text;
                soruKaydı.Secenek3 = txtA.Text;
            }
            else
            {
                MessageBox.Show("Sorunun dogru cevabını seçiniz");
            }

            soruKaydı.KategoriID = Convert.ToInt32(cmBoxKategori.SelectedValue);
            soruKaydı.SoruResmi = picGorselEkle.ImageLocation; //görsel ekle

            SinavDB.Tbl_Sorular.Add(soruKaydı);
            SinavDB.SaveChanges();


        }

        private void btnGorselEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picGorselEkle.ImageLocation = openFileDialog1.FileName;
        }

        private void btnSoruDuzenle_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            SoruDuzenle frm = new SoruDuzenle();
            frm.Show();

        }
    }
}
