using AdavancedSoftware.Model.Entities.Base;
using System;

namespace AdavancedSoftware.Model.Entities
{
    public class YakitHarcama : BaseEntityDurum
    {
        public long AracId { get; set; }
        public long PersonelId { get; set; }
        public long OdemeMetoduId { get; set; }
        public long KasaId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public decimal Litre { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }

        public Arac Arac { get; set; }  
        public Personel Personel { get; set; }
        public OdemeMetodu OdemeMetodu { get; set; }
        public Kasa Kasa { get; set; }
     
    }
}
