using System;
using Homework3.Entities.Abstract;

namespace Homework3.Entities.Concrete
{
    public class Instructor : IEntity, IDescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
    }
}
