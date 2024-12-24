﻿using AdavancedSoftware.Model.Attributes;
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

        [Required, StringLength(50), ZorunluAlan("Müşteri Adı", "txtMusteriAdi")]
        public MusteriTuru MusteriTuru { get; set; } = MusteriTuru.Bireysel;

        public long MusteriGrupId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }

        public long IlId { get; set; }
        public long IlceId { get; set; }
        public string Adres { get; set; }

        public long? FirmaId { get; set; }

        public string Websitesi { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Youtube{ get; set; }
        public string Tiktok { get; set; }
        public string VK { get; set; }


        public  MusteriGrup MusteriGrup { get; set; }
        public Firma Firma { get; set; }
        public Il Il { get; set; }
        public Ilce Ilce { get; set; }
       
        
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
