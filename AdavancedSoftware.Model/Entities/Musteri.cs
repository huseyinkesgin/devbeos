using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedSoftware.Common.Enums;

namespace AdavancedSoftware.Model.Entities
{
    public class Musteri : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

        public MusteriTuru MusteriTuru { get; set; } = MusteriTuru.Bireysel;

        [ZorunluAlan("Kategori Adı", "txtKategoriAdi")]
        public long KategoriId { get; set; }

        [Required, StringLength(50), ZorunluAlan("Müşteri Adı", "txtAd")]
        public string Ad { get; set; }
        [Required, StringLength(50), ZorunluAlan("Müşteri Soyadi", "txtSoyad")]
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        [ZorunluAlan("İl", "txtIl")]
        public long IlId { get; set; }

        [ZorunluAlan("İlçe", "txtIlce")]
        public long IlceId { get; set; }
        public string Adres { get; set; }
        
        public long? FirmaId { get; set; }

        public string Websitesi { get; set; }
        [StringLength(150)]
        public string Facebook { get; set; }
        [StringLength(150)]
        public string Twitter { get; set; }
        [StringLength(150)]
        public string Instagram { get; set; }
        [StringLength(150)]
        public string Linkedin { get; set; }
        [StringLength(150)]
        public string Youtube{ get; set; }
        [StringLength(150)]
        public string Tiktok { get; set; }
        [StringLength(150)]
        public string VK { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }



        public  Kategori Kategori { get; set; }
        public Firma Firma { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }


        [NotMapped]
        public string AdSoyad
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }
    }
}
