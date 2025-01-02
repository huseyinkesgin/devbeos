using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class YakitHarcamaS : YakitHarcama
    {
        public string AracPlakaNo { get; set; }
        public string PersonelAdi { get; set; }
        public string OdemeMetoduAdi { get; set; }
        public string KasaAdi { get; set; }
    }
   
    public class YakitHarcamaL : BaseEntity
    {
        public string AracPlakaNo { get; set; }
        public string PersonelAdi { get; set; }
        public string OdemeMetoduAdi { get; set; }
        public string KasaAdi { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public decimal Litre { get; set; }
        public YakitCinsi YakitCinsi { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }


    }
}
