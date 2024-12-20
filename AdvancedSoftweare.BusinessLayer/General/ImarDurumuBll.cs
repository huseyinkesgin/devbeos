using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class ImarDurumuBll : BaseGenelBll<ImarBilgisi>, IBaseGenelBll, IBaseCommonBll
    {
        public ImarDurumuBll() : base(KartTuru.ImarDurumu) { }
        public ImarDurumuBll(System.Windows.Forms.Control ctrl) : base(ctrl, KartTuru.ImarDurumu) { }
    }
}
