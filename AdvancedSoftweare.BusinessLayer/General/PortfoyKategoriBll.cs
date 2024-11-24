using AdavancedSoftware.Model.Entities;
using AdavancedSoftware.Model.Entities.Base;
using AdnavcedSoftware.Data.Contexts;
using AdvancedSoftware.Common.Enums;
using AdvancedSoftweare.BusinessLayer.Base;
using AdvancedSoftweare.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AdvancedSoftweare.BusinessLayer
{
    public class PortfoyKategoriBll : BaseBll<PortfoyKategori, DataContext>, IBaseGenelBll
    {
        public PortfoyKategoriBll() { }

        public PortfoyKategoriBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<PortfoyKategori, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }
        public IEnumerable<BaseEntity> List(Expression<Func<PortfoyKategori, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.PortfoyKategori);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodver(KartTuru.PortfoyKategori, x => x.Kod);
        }
    }
}
