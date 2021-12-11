using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class HtmlRapor:Rapor
    {
        public HtmlRapor(RaporBilgisi rb):base(rb)
        {}
        public override string KisiBilgileriOlustur()
        {
            // veri tabanından kisisel bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür
            string metin = string.Format("<h1>Kişi Bilgileri</h1>");

            metin += string.Format("<h3>Ad : {0}</h3>", this.raporbilgisi.Ad);
            metin += string.Format("<h3>Soyad : {0}</h3>", this.raporbilgisi.Soyad);
            metin += string.Format("<h3>TC Kimlik Numarası : {0}</h3>", this.raporbilgisi.TCNO);

            return metin;
        }
        public override string DiyetBilgileriOlustur()
        {
            // veri tabanından diyet bilgileri getir 
            // string bir değişkene aktar
            // değişkeni döndür

            string metin = string.Format("<h1>Hastalık Bilgileri</h1>");

            metin += string.Format("<h3>Hastalık : {0}</h3>", this.raporbilgisi.Hastalik);
            metin += string.Format("<h3>Diyet Yöntemi : {0}</h3>", this.raporbilgisi.DiyetYontemi);
            metin += string.Format("<h3>Kahvaltı Menünüz : <br>{0}</h3>", this.raporbilgisi.Kahvalti);
            metin += string.Format("<h3>Öğle Yemeği Menünüz : <br>{0}</h3>", this.raporbilgisi.OgleYemegi);
            metin += string.Format("<h3>Akşam Yemeği Menünüz : <br>{0}</h3>", this.raporbilgisi.AksamYemegi);

            return metin;
        }
    }
}
