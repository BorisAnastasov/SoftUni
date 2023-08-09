using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ");
                Student student = new Student()
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Grade = double.Parse(data[2]),
                };
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(student =>student.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {(student.Grade):f2}");
            }
        }
        class Student
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
    }
}
