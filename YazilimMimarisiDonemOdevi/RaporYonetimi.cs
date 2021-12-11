using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisiDonemOdevi
{
    class RaporYonetimi
    {
        private Rapor rapor;
        public RaporYonetimi(Rapor r)
        {
            this.rapor = r;
        }
        public string Olustur()
        {
            string cikti= rapor.CiktiOlustur();
            return cikti;
        }
        public string TerstenOlustur()
        {
            string cikti = rapor.TerstenCiktiOlustur();
            return cikti;
        }
    }
}
