using AdavancedSoftware.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Dto
{
    public class IsyeriS : Isyeri
    {
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string MusteriGrupAdi { get; set; }
        public string FirmaAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }
}
