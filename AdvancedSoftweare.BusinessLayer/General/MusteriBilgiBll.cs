

using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class MusteriBilgiBll : BaseGenelBll<MusteriBilgi>, IBaseGenelBll, IBaseCommonBll
    {
        public MusteriBilgiBll() : base(KartTuru.MusteriBilgi) { }

        public MusteriBilgiBll(Control ctrl) : base(ctrl, KartTuru.MusteriBilgi) { }
    }
}
