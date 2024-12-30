using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;

namespace AdavancedSoftware.Model.Dto
{
    public class AracS : Arac
    {
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
    }

    public class AracL : BaseEntity
    {
        public string PlakaNo { get; set; }
        public string MarkaAdi { get; set; }
        public string ModelAdi { get; set; }
        public string TescilSiraNo { get; set; }
        public DateTime? TescilTarihi { get; set; }
        public DateTime? IlkTescilTarihi { get; set; }
        public string ModelYil { get; set; }
        public string Sinifi { get; set; }
        public string Cinsi { get; set; }
        public string AracRenk { get; set; }
        public string AracMotorNo { get; set; }
        public string AracSasiNo { get; set; }
        public string SilindirHacmi { get; set; }
        public string MotorGucu { get; set; }
        public YakitCinsi YakitCinsi { get; set; }
        public VitesTuru VitesTuru { get; set; }
        public string BelgeNo { get; set; }
        public string SeriNo { get; set; }
        public string Aciklama { get; set; }
    }
}
