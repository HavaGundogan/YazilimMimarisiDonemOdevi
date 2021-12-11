using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace YazilimMimarisiDonemOdevi
{
    public abstract class HastalikCesidiAbstraction
    {
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader dr;

        private string kisiad;
        private string kisisoyad;
        private int kisitcno;

        public string KisiAd { get { return kisiad; } set { this.kisiad = value; } }
        public string KisiSoyad { get { return kisisoyad; } set { this.kisisoyad = value; } }
        public int KisiTCNO { get { return kisitcno; } set { this.kisitcno = value; } }
        
        public DiyetYontemi diyet;

        public abstract void Hastalik();
        protected int KullaniciKontrol()
        {
            //Veritabanında girilen kullanıcı adı var mı diye kontrol et varsa 1 yoksa 0 döndür
            int deger = 0;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=C:/Users/havak/Dekstop/Yazılım Tasarımı Ve Mimarisi Dönem Ödevi/DiyetisyenUygulama.accdb");
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            baglanti.Open();

            komut.CommandText = "select * from Hasta where HastaTCNO=" + KisiTCNO + "";

            dr = komut.ExecuteReader();
            if (dr.Read())
                deger = 1;

            baglanti.Close();
            return deger;
        }

    }
}
