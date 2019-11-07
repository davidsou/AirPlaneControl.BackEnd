using AirplaneControl.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AirpPlaneControl.Service.Base
{
    public interface IBaseService<TEntity> where TEntity:class
    {
        bool Any(Expression<Func<TEntity, bool>> filter);
        int Count(Expression<Func<TEntity, bool>> filter);
        TEntity Get(params object[] keyValues);
        IList<TEntity> GetAll();
        PagedList<TEntity> Get<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> order, int page, int itemsPerPage);
        Result<TEntity> Insert(TEntity entity);
        Result<TEntity> Update(TEntity entity);
        Result Delete(params object[] keyValues);
    }
}
