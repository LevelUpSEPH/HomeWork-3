using System;
using System.Collections.Generic;
using Homework3.DataAccess.Abstract;
using Homework3.Entities.Abstract;

namespace Homework3.DataAccess.Concrete
{
    public class CategoryDal:IProductDal
    {
        private List<IEntity> _categories;

        public CategoryDal()
        {
            _categories = new List<IEntity>();
        }

        public void Add(IEntity entityToAdd)
        {
            _categories.Add(entityToAdd);
            Console.WriteLine("Added category");
        }

        public void Delete(IEntity entity)
        {
            _categories.Remove(entity);
            Console.WriteLine("Deleted category");
        }

        public List<IEntity> GetAll()
        {
            return _categories;
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Updated category");
        }
    }
}
