using System;
using System.Collections.Generic;
using Homework3.Entities.Abstract;

namespace Homework3.Business.Abstract
{
    public interface IProductManager
    {
        List<IEntity> GetAll();
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
