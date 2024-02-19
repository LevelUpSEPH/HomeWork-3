using System;
using System.Collections.Generic;
using Homework3.Entities.Abstract;

namespace Homework3.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<IEntity> GetAll();
        void Add(IEntity entityToAdd);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
