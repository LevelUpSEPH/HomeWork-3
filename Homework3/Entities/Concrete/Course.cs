using System;
using Homework3.Entities.Abstract;

namespace Homework3.Entities.Concrete
{
    public class Course : IEntity, IDescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
    }
}
