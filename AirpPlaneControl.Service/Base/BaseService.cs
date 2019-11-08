using AirplaneControl.Domain.Common;
using AirPlaneControl.Repository;
using AirPlaneControl.Repository.Infra;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AirpPlaneControl.Service.Base
{
    public class BaseService<TEntity>: IBaseService<TEntity> where TEntity:class
    {
        protected readonly IRepositoryBase<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IValidator<TEntity> _validator;

        public BaseService(IRepositoryBase<TEntity> repository, IUnitOfWork unitOfWork, IValidator<TEntity> validator)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public bool Any(Expression<Func<TEntity, bool>> filter) => _repository.Any(filter);
        public int Count(Expression<Func<TEntity, bool>> filter) => _repository.Count(filter);
        public IList<TEntity> GetAll() => _repository.Get().ToList();
        public virtual TEntity Get(params object[] keyValues) => _repository.Get(keyValues);
        public PagedList<TEntity> Get<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> order, int page, int itemsPerPage) => _repository.Get(filter, order, page, itemsPerPage);



        protected Result<TEntity> Validate(TEntity entity) => new Result<TEntity>(_validator.Validate(entity));
        protected Result<TEntity> Validate(TEntity entity, params Expression<Func<TEntity, object>>[] filter) => new Result<TEntity>(_validator.Validate(entity, filter));


        public virtual Result<TEntity> Insert(TEntity entity)
        {
            var result = Validate(entity);

            if (result.Success)
                result.Value = _repository.Insert(entity);

            return result;
        }
        public virtual Result<TEntity> Update(TEntity entity)
        {
            var result = Validate(entity);

            if (result.Success)
                result.Value = _repository.Update(entity);

            return result;
        }
        public Result Delete(params object[] keyValues)
        {
            _repository.Delete(keyValues);
            return new Result();
        }

        
        
    }
}
