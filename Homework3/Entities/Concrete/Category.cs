using System;
using Homework3.Entities.Abstract;

namespace Homework3.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
