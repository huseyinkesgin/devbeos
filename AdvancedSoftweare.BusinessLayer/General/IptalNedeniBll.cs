using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class IptalNedeniBll : BaseGenelBll<AdavancedSoftware.Model.Entities.IptalNedeni>, IBaseGenelBll, IBaseCommonBll
    {
        public IptalNedeniBll() : base(KartTuru.IptalNedeni) { }

        public IptalNedeniBll(Control ctrl) : base(ctrl, KartTuru.IptalNedeni) { }
    }
}
