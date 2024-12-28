﻿using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdvancedSoftware.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class PersonelS : Personel
    {
        public string DepartmanAdi { get; set; }
        public string UnvanAdi { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }
   

    public class PersonelL : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public MedeniDurum MedeniDurum { get; set; }
        public CocukVarmi CocukVarmi { get; set; } 
        public int CocukSayisi { get; set; }
        public KanGrubu KanGrubu { get; set; }
        public string Ehliyet { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string Adres { get; set; }
        public string Websitesi { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public string Tiktok { get; set; }
        public string VK { get; set; }
        public string Aciklama { get; set; }
        public string DepartmanAdi { get; set; }
        public string UnvanAdi { get; set; }
        public string BankaAdi { get; set; }
        public string SubeAdi { get; set; }
        public string IBAN { get; set; }
        public PersonelDurumu PersonelDurumu { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }
        public string OzelKod3Adi { get; set; }
        public string OzelKod4Adi { get; set; }
        public string OzelKod5Adi { get; set; }
    }
}
