using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Entities
{
    public class FaturaHarcama : BaseEntityDurum
    {
        public long KasaId { get; set; }
        public long OdemeMetoduId { get; set; }
        public long FirmaId { get; set; }
        public long KategoriId { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public DateTime SonOdemeTarihi { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }
       
        public Kasa Kasa { get; set; }
        public OdemeMetodu OdemeMetodu { get; set; }
        public Firma Firma { get; set; }
        public Kategori Kategori { get; set; }
    }
}
