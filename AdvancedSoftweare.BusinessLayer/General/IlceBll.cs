﻿using AdavancedSoftware.Model.Entities;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer.General
{
    public class IlceBll : BaseGenelBll<Ilce>, IBaseCommonBll
    {
        public IlceBll():base(KartTuru.Ilce) { }

        public IlceBll(Control ctrl) : base(ctrl, KartTuru.Ilce) { }
      
    }
}
