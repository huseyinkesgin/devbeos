using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class GabariBll : BaseGenelBll<Gabari>, IBaseGenelBll, IBaseCommonBll
    {
        public GabariBll():base(KartTuru.Gabari) { }

        public GabariBll(Control ctrl) : base(ctrl, KartTuru.Gabari) { }

      
    }
}
