using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class RaporBilgisi
    {
        //kişisel bilgiler
        private string ad;
        private string soyad;
        private int tcno;

        //hastalik bilgileri
        private string hastalik;
        private string diyetyontemi;
        private string kahvalti;
        private string ogleyemegi;
        private string aksamyemegi;

        //Kisi Bilgileri
        public string Ad { get { return ad; } set { this.ad = value; } }
        public string Soyad { get { return soyad; } set { this.soyad = value; } }
        public int TCNO { get { return tcno; } set { this.tcno = value; } }

        //Hastalık Bilgileri

        public string Hastalik { get { return hastalik; } set { this.hastalik = value; } }
        public string DiyetYontemi { get { return diyetyontemi; } set { this.diyetyontemi = value; } }
        public string Kahvalti { get { return kahvalti; } set { this.kahvalti = value; } }
        public string OgleYemegi { get { return ogleyemegi; } set { this.ogleyemegi = value; } }
        public string AksamYemegi { get { return aksamyemegi; } set { this.aksamyemegi = value; } }

        
    }
}
