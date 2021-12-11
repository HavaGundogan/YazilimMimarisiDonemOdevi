using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMimarisiDonemOdevi
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            DiyetisyenEkle de = new DiyetisyenEkle();
            de.DiyetisyenAd = txt_diyetisyenad.Text;
            de.DiyetisyenSoyad = txt_diyetisyensoyad.Text;
            de.TCNO = Convert.ToInt32(txt_tcno.Text);
            de.Sifre = Convert.ToInt32(txt_sifre.Text);

            de.DiyetisyenKaydet();
        }
    }
}
