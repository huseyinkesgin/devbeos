using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class PersonelHarcama : BaseEntityDurum
    {
       
        public long PersonelId { get; set; }
        public long OdemeMetoduId { get; set; }
        public long KasaId { get; set; }
        public long KategoriId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; } = DateTime.Now;
        [Column(TypeName = "money")]
        public decimal Tutar { get; set; } = 0;
        public BelgeTuru BelgeTuru {get; set; } = BelgeTuru.Fis;
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }

        public Personel Personel { get; set; }
        public OdemeMetodu OdemeMetodu { get; set; }
        public Kasa Kasa { get; set; }
        public Kategori Kategori { get; set; }

    }
}
