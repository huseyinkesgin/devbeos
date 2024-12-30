using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;

namespace AdavancedSoftware.Model.Entities
{
    public class PersonelHarcama : BaseEntityDurum
    {
       
        public long PersonelId { get; set; }
        public long OdemeTuruId { get; set; }
        public long KasaId { get; set; }
        public long KategoriId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public BelgeTuru BelgeTuru {get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }

        public Personel Personel { get; set; }
        public OdemeMetodu OdemeMetodu { get; set; }
        public Kasa Kasa { get; set; }
        public Kategori Kategori { get; set; }

    }
}
