using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class DenizUrunleri:DiyetYontemi
    {
        public override string Diyet()
        {
            return "Deniz Ürünleri";
        }
        public override string Kahvalti()
        {
            string kahvaltiliklar = "1 adet haşlanmış yumurta, 2 yemek kaşığı lor peyniri, "+
                "1 adet tam ceviz, 1 ince dilim tam buğday ekmeği(25 gr.),"+
                " Kırmızı biber, 7-8 sap maydanoz, 1 kupa yeşil çay";
            return kahvaltiliklar;
        }

        public override string OgleYemegi()
        {
            string ogleyemegi = "Somon balığı(200gr.), Roka salatası, 1 kepçe mercimek çorbası";
            return ogleyemegi;
        }

        public override string AksamYemegi()
        {
            string aksamyemegi = "1 kase maydonuzlu-dereotu-soğanlı salata, 6-8 kaşık haşlanmış börülce, 1 su bardağı ayran(200 ml)";
            return aksamyemegi;
        }
    }
}
