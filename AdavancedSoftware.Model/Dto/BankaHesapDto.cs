using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace AdavancedSoftware.Model.Dto
{
    public class BankaHesapS : BankaHesap
    {
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
    }

    public class  BankaHesapL : BaseEntity
    {
        public string HesapAdi { get; set; }
        public BankaHesapTuru HesapTuru { get; set; }
        public string BankaAdi { get; set; }
        public string BankaSubeAdi { get; set; }
        public DateTime HesapAcilisTarihi { get; set; } 
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public string MusteriNo { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string Aciklama { get; set; }
      
    }
}
