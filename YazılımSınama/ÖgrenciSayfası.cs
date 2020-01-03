using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YazılımSınama
{
    public partial class ÖgrenciSayfası : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ÖgrenciSayfası()
        {
            InitializeComponent();
        }


        
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinavSayfasi frm = new SinavSayfasi();
            frm.Show();
        }
        
       

        
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            this.Hide();
            genelGrafik frm = new genelGrafik();
            frm.Show();
        }
    }
}
