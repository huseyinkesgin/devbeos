using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class AltyapiBll : BaseGenelBll<Altyapi>, IBaseGenelBll, IBaseCommonBll
    {
        public AltyapiBll():base(KartTuru.Altyapi) { }

        public AltyapiBll(Control ctrl) : base(ctrl, KartTuru.Altyapi) { }

      
    }
}
