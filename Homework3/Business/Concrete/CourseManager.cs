using System;
using System.Collections.Generic;
using Homework3.Business.Abstract;
using Homework3.Entities.Abstract;
using Homework3.DataAccess.Abstract;
using Homework3.DataAccess.Concrete;

namespace Homework3.Business.Concrete
{
    public class CourseManager : IProductManager
    {
        private IProductDal _productDal;

        public CourseManager(CourseDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(IEntity entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(IEntity entity)
        {
            _productDal.Delete(entity);
        }

        public List<IEntity> GetAll()
        {
            return _productDal.GetAll();
        }

        public void Update(IEntity entity)
        {
            _productDal.Update(entity);
        }
    }
}
