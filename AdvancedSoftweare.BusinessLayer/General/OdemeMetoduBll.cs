using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class OdemeMetoduBll : BaseGenelBll<OdemeMetodu>, IBaseGenelBll, IBaseCommonBll
    {
        public OdemeMetoduBll() : base(KartTuru.OdemeMetodu) { }

        public OdemeMetoduBll(Control ctrl) : base(ctrl, KartTuru.OdemeMetodu) { }


    }
}
