using System;
namespace Homework3.Entities.Abstract
{
    public interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
