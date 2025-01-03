﻿using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class PersonelHarcamaS : PersonelHarcama
    {
       
        public string PersonelAdi { get; set; }
        public string OdemeMetoduAdi { get; set; }
        public string KasaAdi { get; set; }
        public string KategoriAdi { get; set; }
    }

    public class PersonelHarcamaL : BaseEntity
    {
        public string PersonelAdi { get; set; }
        public string OdemeMetoduAdi { get; set; }
        public string KasaAdi { get; set; }
        public string KategoriAdi { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
        public string BelgeTuru { get; set; }
        public string BelgeNo { get; set; }
        public string Aciklama { get; set; }

    }
}
