using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class YesilliklerDunyasi:DiyetYontemi
    {
        public override string Diyet()
        {
            return "Yeşillikler Dünyası";
        }
        public override string Kahvalti()
        {
            string kahvaltiliklar = "Meyveli ve keten tohumlu yulaf ezmesi";
            return kahvaltiliklar;
        }

        public override string OgleYemegi()
        {
            string ogleyemegi = "Tatlı patates kızartması, ızgara sebzeli ve humuslu dürüm";
            return ogleyemegi;
        }

        public override string AksamYemegi()
        {
            string aksamyemegi = "Salamura lahana salatası ile Tofu sandviç";
            return aksamyemegi;
        }
    }
}
