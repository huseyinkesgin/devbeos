using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class YakitHarcama : BaseEntityDurum
    {
        public long AracId { get; set; }
        public long PersonelId { get; set; }
        public long OdemeMetoduId { get; set; }
        public long KasaId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; } = DateTime.Now;
        public decimal Tutar { get; set; } = 0;
        public decimal Litre { get; set; }
        public YakitCinsi YakitCinsi { get; set; } = YakitCinsi.Benzin;
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }

        public Arac AracPlakaNo { get; set; }  
        public Personel Personel { get; set; }
        public OdemeMetodu OdemeMetodu { get; set; }
        public Kasa Kasa { get; set; }
     
    }
}
