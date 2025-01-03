using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Entities
{
    public class Firma : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        [Required, StringLength(100), ZorunluAlan("Firma Adı", "txtFirmaAdi")]
        public string FirmaAdi { get; set; }

        [Required, StringLength(100), ZorunluAlan("Fatura Adı", "txtFaturaAdi")]
        public string FaturaAdi { get; set; }
        [Required, StringLength(30), ZorunluAlan("Vergi Dairesi", "txtVergiDairesi")]
        public string VergiDairesi { get; set; }
        [Required, StringLength(11), ZorunluAlan("Vergi Numarası", "txtVergiDairesi")]
        public string VergiNo { get; set; }
        public string MersisNo { get; set; }
        public string KepAdresi { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        [ZorunluAlan("İl", "txtIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe", "txtIlce")]
        public long IlceId { get; set; }
        [ZorunluAlan("Mahalle", "txtMahalle")]
        public long MahalleId { get; set; }

        public string Adres { get; set; }

        public string Websitesi { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string VK { get; set; }
        public string Youtube { get; set; }
        public string Tiktok { get; set; }
       
        [StringLength(500)]
        public string Aciklama { get; set; }

        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }


    }
}
