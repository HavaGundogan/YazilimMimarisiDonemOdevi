using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace YazilimMimarisiDonemOdevi
{
    class VeriTabani
    {
        OleDbConnection Baglanti;
        OleDbCommand komut;
        OleDbDataReader dr;
        public VeriTabani(OleDbConnection baglanti)
        {
            this.Baglanti = baglanti;
            Baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/havak/Desktop/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/DiyetisyenUygulama.accdb");
        }

        //Diyetisyen Giriş İşlemi
        public void DiyetisyenGiris(int TCNO, int SIFRE)
        {
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = Baglanti;
            OleDbDataReader dr;
            Baglanti.Open();

            komut.CommandText = "select DiyetisyenTCNO,DiyetisyenSifre from Diyetisyen where DiyetisyenTCNO=" + TCNO + " and DiyetisyenSifre=" + SIFRE + "";
            dr = komut.ExecuteReader();

            if (dr.Read())//eğer diyetisyen varsa
            {
                System.Windows.Forms.MessageBox.Show("Giriş işlemi başarılı sayfanıza yönlendiriliyorsunuz.");
                DiyetisyenForm df = new DiyetisyenForm();
                df.tcno = TCNO;
                df.Show();
            }
            Baglanti.Close();
        }

        //Diyetisyen Ekleme İşlemleri
        public void DiyetisyenEkle(string diyetisyenad,string diyetisyensoyad,int tcno,int sifre)
        {
            int kayitlimi = 0;

            komut = new OleDbCommand();
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.CommandText = "select DiyetisyenTCNO,DiyetisyenSifre from Diyetisyen where DiyetisyenTCNO=" + tcno + " AND  DiyetisyenSifre=" + sifre + "";
            dr = komut.ExecuteReader();

            if (dr.Read())//diyetisyen bulunduysa kayıtlı demektir.
                kayitlimi = 1;

            Baglanti.Close();

            if (kayitlimi == 1)//1'e eşitse kayıtlı demektir.
            {
                System.Windows.Forms.MessageBox.Show("\nKayıt etmek istediğiniz diyetisyen zaten kayıtlı.\n");
            }
            else //Kayıtlı değilse kayıt et
            {
                komut = new OleDbCommand();
                komut.Connection = Baglanti;
                Baglanti.Open();

                komut.CommandText = "insert into Diyetisyen(DiyetisyenAd,DiyetisyenSoyad,DiyetisyenTCNO,DiyetisyenSifre) values('" + diyetisyenad + "','" + diyetisyensoyad + "', '" + tcno + "','" + sifre + "')";
                komut.ExecuteNonQuery();
                Baglanti.Close();

                System.Windows.Forms.MessageBox.Show("Diyetisyenin kaydı başarıyla yapıldı.");
            }
        }
    }
}
