using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Dto
{
    public class IndiriminUygulanacagiHizmetBilgileriL : IndiriminUygulanacagiHizmetBilgileri, IBaseHareketEntity
    {
        public string HizmetAdi { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
