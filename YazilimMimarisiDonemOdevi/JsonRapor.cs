using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YazilimMimarisiDonemOdevi
{
    public class JsonRapor : Rapor
    {
        public class KisiselBilgiler
        {
            //Kisi Bilgileri
            public string Ad;
            public string Soyad;
            public int TCNO;
        }
        public class DiyetBilgileri
        { 
            //Hastalık Bilgileri

            public string Hastalik;
            public string DiyetYontemi;
            public string Kahvalti;
            public string OgleYemegi;
            public string AksamYemegi;
        }
        public JsonRapor(RaporBilgisi rb) : base(rb)
        {}
        public override string KisiBilgileriOlustur()
        {
            KisiselBilgiler kb = new KisiselBilgiler();

            kb.Ad = this.raporbilgisi.Ad;
            kb.Soyad = this.raporbilgisi.Soyad;
            kb.TCNO = this.raporbilgisi.TCNO;

            string stringjson = JsonConvert.SerializeObject(kb);
            return stringjson;
        }
        public override string DiyetBilgileriOlustur()
        {
            DiyetBilgileri db = new DiyetBilgileri();

            db.Hastalik = this.raporbilgisi.Hastalik;
            db.DiyetYontemi = this.raporbilgisi.DiyetYontemi;
            db.Kahvalti = this.raporbilgisi.Kahvalti;
            db.OgleYemegi = this.raporbilgisi.OgleYemegi;
            db.AksamYemegi = this.raporbilgisi.AksamYemegi;

            string stringjson = JsonConvert.SerializeObject(db);
            return stringjson;
        }
    }
}
