using System;
using System.Collections.Generic;
using Homework3.DataAccess.Abstract;
using Homework3.Entities.Abstract;

namespace Homework3.DataAccess.Concrete
{
    public class InstructorDal:IProductDal
    {
        private List<IEntity> _instructors;

        public InstructorDal()
        {
            _instructors = new List<IEntity>();
        }

        public void Add(IEntity entityToAdd)
        {
            _instructors.Add(entityToAdd);
            Console.WriteLine("Added to instructors");
        }

        public void Delete(IEntity entity)
        {
            _instructors.Remove(entity);
            Console.WriteLine("Removed from instructors");
        }

        public List<IEntity> GetAll()
        {
            return _instructors;
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Updated from instructors");
        }
    }
}
