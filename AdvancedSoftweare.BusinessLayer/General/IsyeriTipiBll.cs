using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class IsyeriTipiBll : BaseGenelBll<IsyeriTipi>, IBaseGenelBll, IBaseCommonBll
    {
        public IsyeriTipiBll() : base(KartTuru.IsyeriTipi) { }

        public IsyeriTipiBll(Control ctrl) : base(ctrl, KartTuru.IsyeriTipi) { }

    }
    }