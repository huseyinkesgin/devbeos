using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Arac : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(50), ZorunluAlan("Araç Plaka", "txtAracPlaka")]
        public string PlakaNo { get; set; }
        public DateTime IlkTescilTarihi { get; set; }
        public string TescilSiraNo { get; set; }
        public DateTime TescilTarihi { get; set; }
        public long MarkaId { get; set; }
        public long ModelId { get; set; }
        public string ModelYil { get; set; }
        public string Sinifi { get; set; }
        public string Cinsi { get; set; }
        public string AracRenk { get; set; }
        public string AracMotorNo { get; set; }
        public string AracSasiNo { get; set; }
        public string SilindirHacmi { get; set; }
        public string MotorGucu { get; set; }
        public YakitCinsi YakitCinsi { get; set; } = YakitCinsi.Benzin;
        public VitesTuru VitesTuru { get; set; } = VitesTuru.Otomatik;
        public string BelgeNo { get; set; }
        public string SeriNo { get; set; }










        [StringLength(500)]
        public string Aciklama { get; set; }

        public Marka Marka { get; set; }
        public Model Model { get; set; }
    }
}
