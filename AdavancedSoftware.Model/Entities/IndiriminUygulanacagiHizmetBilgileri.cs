﻿using AdavancedSoftware.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities
{
   
    public class IndiriminUygulanacagiHizmetBilgileri : BaseHareketEntity
    {
        public long IndirimId { get; set; }
        public long HizmetId { get; set; }
        [Column(TypeName ="money")]
        public decimal IndirimTutari { get; set; }

        public decimal IndirimOrani { get; set; }
        public long SubeId { get; set; }

        public Indirim Indirim { get; set; }
        public Hizmet Hizmet { get; set; }
        public Sube Sube { get; set; }
    }
}
