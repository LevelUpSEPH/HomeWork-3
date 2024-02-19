using System;
using System.Collections.Generic;
using Homework3.Entities.Abstract;
using Homework3.DataAccess.Abstract;

namespace Homework3.DataAccess.Concrete
{
    public class CourseDal:IProductDal
    {
        private List<IEntity> _courses;

        public CourseDal()
        {
            _courses = new List<IEntity>();
        }

        public void Add(IEntity entityToAdd)
        {
            _courses.Add(entityToAdd);
            Console.WriteLine("Added to courses");
        }

        public void Delete(IEntity entity)
        {
            _courses.Remove(entity);
            Console.WriteLine("Removed from courses");
        }

        public List<IEntity> GetAll()
        {
            return _courses;
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Updated from courses");
        }
    }
}
