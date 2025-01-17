﻿using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class DonemBll : BaseGenelBll<Donem>, IBaseGenelBll, IBaseCommonBll
    {
        public DonemBll():base(KartTuru.Donem) { }

        public DonemBll(Control ctrl) : base(ctrl, KartTuru.Donem) { }

      
    }
}
