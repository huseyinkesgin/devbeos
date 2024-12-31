using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Sozlesme : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public SozlesmeTuru SozlesmeTuru { get; set; }

        [Required, StringLength(50), ZorunluAlan("Firma Adı", "txtFirma")]
        public long FirmaId { get; set; }

        public string MusteriNo { get; set; }  
        public string AcenteNo { get; set; }
        public string PoliceNo { get; set; }
        public string PoliceTarihi { get; set; }
        public string BaslangicTarihi { get; set; }
        public string BitisTarihi { get; set; }




        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
