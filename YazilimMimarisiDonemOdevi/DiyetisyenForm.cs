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
using System.IO;

namespace YazilimMimarisiDonemOdevi
{
    public partial class DiyetisyenForm : Form
    {
        public DiyetisyenForm()
        {
            InitializeComponent();
        }

        public int tcno;
        private void DiyetisyenForm_Load(object sender, EventArgs e)
        {
            lbl_tcnotext.Text = tcno.ToString();
        }

        private void btn_HastaKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_hastalik.Text=="Obez")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Obez();

                    hastalikcesidi.KisiAd = txt_hastaad.Text;
                    hastalikcesidi.KisiSoyad = txt_hastasoyad.Text;
                    hastalikcesidi.KisiTCNO =Convert.ToInt32(txt_hastatcno.Text);

                    if (cmb_diyetyontemi.Text=="Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Deniz Ürünleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Yeşillikler Dünyası")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else if(cmb_hastalik.Text == "Çölyak")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Colyak();

                    hastalikcesidi.KisiAd = txt_hastaad.Text;
                    hastalikcesidi.KisiSoyad = txt_hastasoyad.Text;
                    hastalikcesidi.KisiTCNO = Convert.ToInt32(txt_hastatcno.Text);

                    if (cmb_diyetyontemi.Text == "Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Deniz Ürünleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Yeşillikler Dünyası")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else if(cmb_hastalik.Text == "Şeker")
                {
                    HastalikCesidiAbstraction hastalikcesidi = new Seker();

                    hastalikcesidi.KisiAd = txt_hastaad.Text;
                    hastalikcesidi.KisiSoyad = txt_hastasoyad.Text;
                    hastalikcesidi.KisiTCNO = Convert.ToInt32(txt_hastatcno.Text);

                    if (cmb_diyetyontemi.Text == "Akdeniz")
                    {
                        hastalikcesidi.diyet = new Akdeniz();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Gluten Free")
                    {
                        hastalikcesidi.diyet = new GlutenFree();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Deniz Ürünleri")
                    {
                        hastalikcesidi.diyet = new DenizUrunleri();
                        hastalikcesidi.Hastalik();
                    }
                    else if (cmb_diyetyontemi.Text == "Yeşillikler Dünyası")
                    {
                        hastalikcesidi.diyet = new YesilliklerDunyasi();
                        hastalikcesidi.Hastalik();
                    }
                    else
                    {
                        MessageBox.Show("Bir Diyet Yöntemi Seçiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Hastalık Seçiniz..");
                }
            }
            
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi.\nLütfen Sonra Tekrar Deneyiniz."+ hata.Message);
            }
        }

        private void txt_raportc_TextChanged(object sender, EventArgs e)
        {
            btn_RaporAl.Enabled = true;
        }

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {
            //dosya işlemleri için
            StreamWriter sw;
            string dosya="";
            string metin="";

            string raporcesidi=cmb_raporcesidi.Text;
            string raporonceligi = cmb_raporgosterimi.Text;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/marsl/OneDrive/Masaüstü/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/DiyetisyenUygulama.accdb");
            OleDbCommand komut = new OleDbCommand();
            OleDbDataReader dr;
            komut.Connection = baglanti;

            //raporu alınacak hastanın tcno numarasını gönder.
            int tcno = Convert.ToInt32(txt_raportc.Text);
            
            RaporBilgisi rb = new RaporBilgisi();   

            baglanti.Open();
            komut.CommandText = "select * from Hasta where HastaTCNO=" + tcno + "";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                //kişisel bilgiler
                rb.Ad = dr[1].ToString();
                rb.Soyad = dr[2].ToString();
                rb.TCNO = Convert.ToInt32(dr[3]);

                //Hastalık bilgileri
                rb.Hastalik = dr[4].ToString();
                rb.DiyetYontemi = dr[5].ToString();
                rb.Kahvalti = dr[6].ToString();
                rb.OgleYemegi = dr[7].ToString();
                rb.AksamYemegi = dr[8].ToString();
            }
            baglanti.Close();

            if (raporcesidi=="HTML")
            {
                Rapor rapor = new HtmlRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.Olustur();
                    dosya = @"C:/Users/marsl/OneDrive/Masaüstü/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/HtmlRapor.html";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenOlustur();
                    dosya = @"C:/Users/marsl/OneDrive/Masaüstü/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/HtmlRapor.html";
                }
                else
                {
                    MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
                }
            }
            else if (raporcesidi == "JSON")
            {
                Rapor rapor = new JsonRapor(rb);
                RaporYonetimi raporyonetimi = new RaporYonetimi(rapor);
                if (raporonceligi == "Kişi Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.Olustur();
                    dosya = @"C:/Users/marsl/OneDrive/Masaüstü/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/JSONRapor.json";
                }
                else if (raporonceligi == "Hastalık Bilgileri Öncelikli")
                {
                    metin = raporyonetimi.TerstenOlustur();
                    dosya = @"C:/Users/marsl/OneDrive/Masaüstü/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/JSONRapor.json";
                }
                else
                {
                    MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
                }
            }
            else
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılamaz...");
            }

            sw = new StreamWriter(dosya);
            sw.WriteLine(metin);
            sw.Close();

            MessageBox.Show("Rapor Oluşturuldu Klasorün İçine Bakınız..");
        }
    }
}
