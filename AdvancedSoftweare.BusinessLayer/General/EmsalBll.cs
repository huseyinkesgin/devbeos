using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class EmsalBll : BaseGenelBll<Emsal>, IBaseGenelBll, IBaseCommonBll
    {
        public EmsalBll():base(KartTuru.Emsal) { }

        public EmsalBll(Control ctrl) : base(ctrl, KartTuru.Emsal) { }

      
    }
}
