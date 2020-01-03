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
    public partial class LoginEkrani : Form
    {
        SinavOtomasyonuEntities DB = new SinavOtomasyonuEntities();
        

        public LoginEkrani()
        {
            InitializeComponent();
        }

        private void GirisYap()
        {
            if (rdbtnOgretmen.Checked)
            {
                
                try
                {
                    Tbl_Kisi _Ogretmen = DB.Tbl_Kisi.First(s => s.kullaniciAdi == txtKullanici.Text.Trim() && s.sifre == txtSifre.Text.Trim() && s.rolID == 1);
                    this.Hide();
                    ÖgretmenSayfasi frm = new ÖgretmenSayfasi();
                    frm.Show();

                }

                catch (Exception)
                {
                    MessageBox.Show("");
                    return;
                }
            }
            if (rdbtnOgrenci.Checked)
            {
                try
                {
                    Tbl_Kisi _Ogrenci = DB.Tbl_Kisi.First(s => s.kullaniciAdi == txtKullanici.Text.Trim() && s.sifre == txtSifre.Text.Trim() && s.rolID == 2);
                    this.Hide();
                    ÖgrenciSayfası frm = new ÖgrenciSayfası();
                    frm.Show();

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalıdır");
                    return;
                }
            }
        }

        

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            GirisYap();
            
        }
    }
}
