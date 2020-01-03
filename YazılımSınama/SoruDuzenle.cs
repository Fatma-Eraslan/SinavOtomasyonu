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
    public partial class SoruDuzenle : Form
    {
        SinavOtomasyonuEntities DB = new SinavOtomasyonuEntities();

        public SoruDuzenle()
        {
            InitializeComponent();
        }
       
        void soruGoruntule()
        {
            var sorularVeri = (from sr in DB.Tbl_Sorular
                               select new
                               {
                                   sr.Soru,
                                   sr.Secenek1,
                                   sr.Secenek2,
                                   sr.Secenek3,
                                   sr.DogruSecenek,
                               });
            DatagridSorular.DataSource = sorularVeri.ToList();
        }

        private void SoruDuzenle_Load(object sender, EventArgs e)
        {
            soruGoruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sil = SilGuncelleLbl.Text;
            var soruSil = DB.Tbl_Sorular.Where(w => w.Soru == sil).FirstOrDefault();
            DB.Tbl_Sorular.Remove(soruSil);
            DB.SaveChanges();
            soruGoruntule();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string guncelle = SilGuncelleLbl.Text;
            var soruGuncelle = DB.Tbl_Sorular.Where(w => w.Soru == guncelle).FirstOrDefault();
            soruGuncelle.Soru = txtSoruDuzenle.Text;
            soruGuncelle.Secenek1 = txtSecenek1.Text;
            soruGuncelle.Secenek2 = txtSecenek2.Text;
            soruGuncelle.Secenek3 = txtSecenek3.Text;
            soruGuncelle.DogruSecenek = txtDogruSecenek.Text;

            DB.SaveChanges();
            soruGoruntule();
        }

        private void DatagridSorular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoruDuzenle.Text = DatagridSorular.CurrentRow.Cells[0].Value.ToString();
            txtSecenek1.Text = DatagridSorular.CurrentRow.Cells[1].Value.ToString();
            txtSecenek2.Text = DatagridSorular.CurrentRow.Cells[2].Value.ToString();
            txtSecenek3.Text = DatagridSorular.CurrentRow.Cells[3].Value.ToString();
            txtDogruSecenek.Text = DatagridSorular.CurrentRow.Cells[4].Value.ToString();
            SilGuncelleLbl.Text = DatagridSorular.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

