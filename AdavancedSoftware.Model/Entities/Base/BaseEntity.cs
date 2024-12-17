using AdavancedSoftware.Model.Attributes;
using AdavancedSoftware.Model.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdavancedSoftware.Model.Entities.Base
{
    public class BaseEntity:IBaseEntity
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order = 1),Required, StringLength(40), Kod("Kod","txtKod"),ZorunluAlan("Kod","txtKod")]
        public virtual string Kod { get; set; }
    }
}

