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
        public DateTime IlkTescilTarihi { get; set; } = DateTime.Now;
        public string TescilSiraNo { get; set; }
        public DateTime TescilTarihi { get; set; } = DateTime.Now;
        [ZorunluAlan("Marka", "txtMarka")]
        public long MarkaId { get; set; }
        [ZorunluAlan("Model", "txtModel")]
        public long ModelId { get; set; }
        [ZorunluAlan("Model Yılı", "txtModelYil")]
        public int ModelYil { get; set; } = DateTime.Now.Year;

        [ZorunluAlan("Araç Sınıfı", "txtAracSinifi")]
        public long AracSinifId { get; set; }
        public AracCinsi  AracCinsi { get; set; } = AracCinsi.Otomobil;
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
        public AracSinif AracSinif { get; set; }
    }
}
