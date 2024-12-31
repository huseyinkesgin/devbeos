using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
    public class Personel : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }

     
        [Required, StringLength(50), ZorunluAlan("Müşteri Adı", "txtAd")]
        public string Ad { get; set; }
        [Required, StringLength(50), ZorunluAlan("Müşteri Soyadi", "txtSoyad")]
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public Cinsiyet Cinsiyet { get; set; } = Cinsiyet.Erkek;
        [Column(TypeName = "date")]
        public DateTime DogumTarihi { get; set; } = DateTime.Now;
        public string DogumYeri { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public MedeniDurum MedeniDurum { get; set; } = MedeniDurum.Bekar;
        public CocukVarmi CocukVarmi { get; set; } = CocukVarmi.Yok;
        public int CocukSayisi { get; set; }
        public KanGrubu KanGrubu { get; set; } = KanGrubu.Bilinmiyor;
        public string Ehliyet { get; set; }

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
        [StringLength(150)]
        public string Facebook { get; set; }
        [StringLength(150)]
        public string Twitter { get; set; }
        [StringLength(150)]
        public string Instagram { get; set; }
        [StringLength(150)]
        public string Linkedin { get; set; }
        [StringLength(150)]
        public string Youtube { get; set; }
        [StringLength(150)]
        public string Tiktok { get; set; }
        [StringLength(150)]
        public string VK { get; set; }
        [StringLength(500)]
        public string Aciklama { get; set; }

        public long? DepartmanId { get; set; }
        public long? UnvanId { get; set; }
        public long? BankaId { get; set; }
        public long? SubeId { get; set; }
        public string IBAN { get; set; }
        public PersonelDurumu PersonelDurumu { get; set; } = PersonelDurumu.Calisiyor;
        [Column(TypeName = "date")]
        public DateTime IseGirisTarihi { get; set; } = DateTime.Now;
        [Column(TypeName = "date")]
        public DateTime? IstenCikisTarihi { get; set; } = null;

        public long? OzelKod1Id { get; set; }
        public long? OzelKod2Id { get; set; }
        public long? OzelKod3Id { get; set; }
        public long? OzelKod4Id { get; set; }
        public long? OzelKod5Id { get; set; }



        public Departman Departman { get; set; }
        public Unvan Unvan { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
        public Mahalle Mahalle { get; set; }
        public Banka Banka { get; set; }
        public BankaSube Sube { get; set; }

        public OzelKod OzelKod1 { get; set; }
        public OzelKod OzelKod2 { get; set; }
        public OzelKod OzelKod3 { get; set; }
        public OzelKod OzelKod4 { get; set; }
        public OzelKod OzelKod5 { get; set; }
    }
}
