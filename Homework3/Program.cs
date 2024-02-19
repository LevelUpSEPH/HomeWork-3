using System;
using Homework3.Business.Concrete;
using Homework3.Business.Abstract;
using Homework3.DataAccess.Abstract;
using Homework3.DataAccess.Concrete;
using Homework3.Entities.Concrete;
using Homework3.Entities.Abstract;

namespace Homework3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            CourseManager courseManager = new CourseManager(new CourseDal());
            InstructorManager instructorManager = new InstructorManager(new InstructorDal());

            Category category = new Category { Id = 12, Name = "Programming" };
            categoryManager.Add(category);

            Instructor instructor = new Instructor { Id = 1, Name = "Engin", LastName = "Demirog", Description = "Senior Programmer" };
            instructorManager.Add(instructor);

            Course course = new Course { Id = 2, Name = "2024 C#", Description = "Better coding bootcamp!", Category = category, Instructor = instructor };
            courseManager.Add(course);

            Console.WriteLine("-----Starting the reading operation for category entities-----");

            PrintAllNameFromManager(categoryManager);

            Console.WriteLine("-----Starting the reading operation for course entities-----");

            PrintAllNameFromManager(courseManager);

            Console.WriteLine("-----Starting the reading operation for instructor entities-----");

            PrintAllNameFromManager(instructorManager);

            Console.ReadLine();
        }

        static void PrintAllNameFromManager(IProductManager productManager)
        {
            Console.WriteLine("Starting read from entity, entity count in list is : " + productManager.GetAll().Count);
            foreach(IEntity entity in productManager.GetAll())
            {
                Console.WriteLine(entity.Name);
            }
        }
    }
}
