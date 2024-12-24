using AdavancedSoftware.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Entities
{
    public class Iletisim : BaseEntityDurum
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string BabaAdi { get; set; }
        public string AnneAdi { get; set; }
        public string KimlikSeriNo { get; set; }
        public string Telefon { get; set; }
        public string CepTelefonu { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Aciklama { get; set; }

    }
}
