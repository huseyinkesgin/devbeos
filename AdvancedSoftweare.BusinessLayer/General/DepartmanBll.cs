using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class DepartmanBll : BaseGenelBll<Departman>, IBaseGenelBll, IBaseCommonBll
    {
        public DepartmanBll():base(KartTuru.Departman) { }

        public DepartmanBll(Control ctrl) : base(ctrl, KartTuru.Departman) { }

      
    }
}
