using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    public class Akdeniz:DiyetYontemi
    {
        public override string Diyet()
        {
            return "Akdeniz";
        }
        public override string Kahvalti()
        {
            string kahvaltiliklar = "1 dilim tam çavdar ekmeği (erkekler için iki dilim), "
                +"50 gram lor peyniri, 1 tatlı kaşığı zeytinyağı, kekik,pul biber, "+
                "taze fesleğen Domates, yeşil biber, maydanoz Şekersiz açık çay";
            return kahvaltiliklar;
        }

        public override string OgleYemegi()
        {
            string ogleyemegi = "1 kâse mercimek salatası, 1 dilim az yağlı beyaz peynir, 1 dilim tam çavdar ekmeği";
            return ogleyemegi;
        }

        public override string AksamYemegi()
        {
            string aksamyemegi = "6 çorba kaşığı kıymalı bezelye, 3 çorba kaşığı bulgur pilavı(erkekler için 4 çorba kaşığı bulgur pilavı), Cacık veya ayran";
            return aksamyemegi;
        }
    }
}
