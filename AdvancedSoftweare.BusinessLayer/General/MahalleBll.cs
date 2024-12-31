using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class MahalleBll : BaseGenelBll<Mahalle>, IBaseCommonBll
    {
        public MahalleBll() : base(KartTuru.Mahalle) { }

        public MahalleBll(Control ctrl) : base(ctrl, KartTuru.Mahalle) { }

    }
}
