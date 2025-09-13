using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class HizmetS : Hizmet
    {
        public string HizmetTuruAdi { get; set; }
    }

    public class HizmetL: BaseEntity
    {
        public string Kod { get; set; }
        public string HizmetAdi { get; set; }
        public long HizmetTuruId { get; set; }
        public string HizmetTuruAdi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
      
        public string Aciklama { get; set; }
    }
}
