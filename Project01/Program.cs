using Azure;
using Microsoft.EntityFrameworkCore;
using Project01.Data;
using Project01.Models;

namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext Context = new AppDbContext();

            /*
            Loading Related Data :
            1. Eager Loading
            2. Lazy Loading 
            3. Explicit Loading 
           */

            //var Dept = Context.Departments.Include(x => x.students).FirstOrDefault(x => x.Id ==1);
            //Console.WriteLine(Dept.Name);
            //Console.WriteLine(Dept.Id);

            //foreach(var student  in Dept.students)
            //{
            //    Console.WriteLine(student.Name);
            //}
            //***********************************************************************

            //var Dept = Context.Departments.Include(x => x.students).ToList();
            //foreach (var dept in Dept)
            //{
            //    Console.WriteLine(dept.Name);
            //}
            //***********************************************************************

            var students = Context.students.Include(x => x.Departments).ToList();

                Console.WriteLine("===================================");
                Console.WriteLine($"Student Name     | Department Name");
                Console.WriteLine("===================================");


            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} | {student.Departments.Name}");
            }

                Console.WriteLine("===================================");



            //****************************************************************************
            //****************************************************************************

            //Add Department
            //Departments departments = new Departments()
            //{
            //    Name = "HR"
            //};
            //Departments departments1 = new Departments()
            //{
            //    Name = "Finance"
            //};
            //Departments departments2 = new Departments()
            //{
            //    Name = "PR"
            //};

            //Context.Departments.Add(departments);
            //Context.Departments.Add(departments1);
            //Context.Departments.Add(departments2);
            //Context.SaveChanges();

            //Add Students
            //Student student = new Student()
            //{
            //    Name = "Ahmed",
            //    Age = 30,
            //    Departments = departments
            //};

            //Student student1 = new Student()
            //{
            //    Name = "Ali",
            //    Age = 40,
            //    Departments = departments
            //};

            //Student student2 = new Student()
            //{
            //    Name = "Mohammed",
            //    Age = 20,
            //    Departments = departments
            //};

            //Student student3 = new Student()
            //{
            //    Name = "Abdullah",
            //    Age = 25,
            //    Departments = departments
            //};

            //Student student4 = new Student()
            //{
            //    Name = "Omar",
            //    Age = 45,
            //    Departments = departments
            //};

            //Context.students.Add(student);
            //Context.students.Add(student1);
            //Context.students.Add(student2);
            //Context.students.Add(student3);
            //Context.students.Add(student4);
            //Context.SaveChanges();

        }
    }
}
