using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class PortfoyTipiBll : BaseGenelBll<PortfoyTipi>, IBaseGenelBll, IBaseCommonBll
    {
        public PortfoyTipiBll():base(KartTuru.PortfoyTipi) { }

        public PortfoyTipiBll(Control ctrl) : base(ctrl, KartTuru.PortfoyTipi) { }

      
    }
}
