using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace YazilimMimarisiDonemOdevi
{
    class DiyetisyenEkle
    {
        private string diyetisyenad;
        private string diyetisyensoyad;
        private int sifre;
        private int tcno;

        public string DiyetisyenAd { get { return diyetisyenad; } set { this.diyetisyenad = value; } }
        public string DiyetisyenSoyad { get { return diyetisyensoyad; } set { this.diyetisyensoyad = value; } }
        public int Sifre { get { return sifre; } set { this.sifre = value; } }
        public int TCNO { get { return tcno; } set { this.tcno = value; } }

        OleDbConnection baglanti;     

        public void DiyetisyenKaydet()
        {
            VeriTabani vt = new VeriTabani(baglanti);
            vt.DiyetisyenEkle(diyetisyenad,diyetisyensoyad,tcno,sifre);            
        }



    }
}
