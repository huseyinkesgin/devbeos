using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class AracSinifBll : BaseGenelBll<AracSinif>, IBaseGenelBll, IBaseCommonBll
    {
        public AracSinifBll():base(KartTuru.AracSinif) { }

        public AracSinifBll(Control ctrl) : base(ctrl, KartTuru.AracSinif) { }

      
    }
}
