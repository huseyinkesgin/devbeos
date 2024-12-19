using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class TapuTipiBll : BaseGenelBll<TapuTipi>, IBaseCommonBll
    {
        public TapuTipiBll() : base(KartTuru.TapuTipi) { }

        public TapuTipiBll(Control ctrl) : base(ctrl, KartTuru.TapuTipi) { }
    }
}
