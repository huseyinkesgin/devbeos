using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedSoftware.Model.Attributes
{
    public class Kod : Attribute
    {
        public string Description { get; }
        public string ControlName { get; }

        /// <summary>
        /// Zorunlu alan kontrolü yapılacak property'nin açıklaması ve kontrol adı
        /// </summary>
        /// <param name="description"> Uyarı mesajında gösterilcek olan açıklama</param>
        /// <param name="controlName">Uyarı mesajı sonrası focuslanacak control adı</param>
        public Kod(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
