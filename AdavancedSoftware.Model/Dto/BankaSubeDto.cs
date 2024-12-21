using AdavancedSoftware.Model.Entities.Base;
using AdavancedSoftware.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Dto
{
    [NotMapped]
    public class BankaSubeS : BankaSube
    {

        public string BankaAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }

    }

    public class BankaSubeL : BaseEntity
    {
        public string SubeAdi { get; set; }
        public string BankaAdi { get; set; }
        public string OzelKod1Adi { get; set; }
        public string OzelKod2Adi { get; set; }

        public string Aciklama { get; set; }
    }
}
