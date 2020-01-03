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
    public partial class SinavSayfasi : Form
    {
        SinavOtomasyonuEntities DB = new SinavOtomasyonuEntities();
        int i = 0;
        string[,] SorularDizi = new string[21, 7];
        public SinavSayfasi()
        {
            InitializeComponent();
        }

        int timerSayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerSayac++;
            pBzamanlayici.Value = timerSayac;
            if (timerSayac == 500)
            {
                timer1.Stop();
                //YeniSoruButon.Enabled = false;
                //EskiSoruButon.Enabled = false;
                //SinavBitirButon.Visible = true;
                MessageBox.Show("Sınav süreniz bitmiştir.Sınav bitir butonuna basarak devam ediniz.");
            }
        }

        private void SinavSayfasi_Load(object sender, EventArgs e)
        {
           
            for(i=0;i<21;i++)
            {
                Soru();
                if(i==20)
                {
                    i = 0;
                }
            }
        }
        void Soru()
        {
            Random randomSec = new Random();
            int RndmSec = randomSec.Next(4) + 1;
            var soru = (from sr in DB.Tbl_Sorular
                        orderby Guid.NewGuid()
                        select sr).Take(1);

            foreach (var sorular in soru)
            {
                if (RndmSec == 1)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (RndmSec == 2)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 2] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (RndmSec == 3)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 4] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
                else if (RndmSec == 4)
                {
                    SorularDizi[i, 0] = Convert.ToString(sorular.Soru);
                    SorularDizi[i, 1] = Convert.ToString(sorular.Secenek1);
                    SorularDizi[i, 2] = Convert.ToString(sorular.Secenek2);
                    SorularDizi[i, 3] = Convert.ToString(sorular.Secenek3);
                    SorularDizi[i, 4] = Convert.ToString(sorular.DogruSecenek);
                    SorularDizi[i, 5] = Convert.ToString(sorular.SoruResmi);
                }
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            TxtSoru.Text = Convert.ToString(SorularDizi[i, 0]);
            rdbtnA.Text= Convert.ToString(SorularDizi[i, 1]);
            rdbtnB.Text = Convert.ToString(SorularDizi[i, 2]);
            rdbtnC.Text = Convert.ToString(SorularDizi[i, 3]);
            rdbtnD.Text = Convert.ToString(SorularDizi[i, 4]);
            //  soruResmiPic.Location= Convert.ToString(SorularDizi[i, 5]);
            
            if(i==20)
            {
                i = 19;
            }
            i++;
        }
    }
}