using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class GlutenFree:DiyetYontemi
    {
        public override string Diyet()
        {
            return "Gluten Free";
        }
        public override string Kahvalti()
        {
            string kahvaltiliklar = "Sebzeli omlet.";
            return kahvaltiliklar;
        }

        public override string OgleYemegi()
        {
            string ogleyemegi = "Dilimlenmiş domates, salatalık ve Ispanak ve avokadolu kinoa salatası.";
            return ogleyemegi;
        }

        public override string AksamYemegi()
        {
            string aksamyemegi = "Şiş karides, salata, Glutensiz ekmek";
            return aksamyemegi;
        }
    }
}
