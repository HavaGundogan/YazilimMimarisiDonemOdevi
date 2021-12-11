using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace YazilimMimarisiDonemOdevi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;

        public void Kontrol()
        {
            int tcno=Convert.ToInt32(txt_tcno.Text);
            int sifre=Convert.ToInt32(txt_sifre.Text);

            if ((tcno==11111) && (sifre==123))//admin girişi
            {
                AdminForm af = new AdminForm();
                af.Show();
            }
            else //diyetisyen kontrolu yap. tcno ve şifre uyumlu ise diyetisyen ekranına geçiş yap.
            {
                VeriTabani vt = new VeriTabani(baglanti);
                vt.DiyetisyenGiris(tcno,sifre);
            }
        }
        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            Kontrol();
        }
    }
}
