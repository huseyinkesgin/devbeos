using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class OzelKodBll : BaseGenelBll<OzelKodlar>, IBaseCommonBll
    {
        public OzelKodBll() : base(KartTuru.OzelKod) { }

        public OzelKodBll(Control ctrl) : base(ctrl, KartTuru.OzelKod) { }
      
    }
}
