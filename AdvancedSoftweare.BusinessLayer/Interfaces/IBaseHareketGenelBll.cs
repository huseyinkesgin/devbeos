using AdavancedSoftware.Model.Entities.Base;
using System.Collections.Generic;

namespace AdvancedSoftweare.BusinessLayer.Interfaces
{
    public interface IBaseHareketGenelBll
    {
        bool Insert(IList<BaseHareketEntity> entities);
        bool Update(IList<BaseHareketEntity> entities);
        bool Delete(IList<BaseHareketEntity> entities);
    }
}
