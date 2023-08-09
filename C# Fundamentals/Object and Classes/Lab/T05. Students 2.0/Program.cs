using System;
using System.Collections.Generic;

namespace T05._Students_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string firstName = "";
            string lastName = "";
            int age = 0;
            string homeTown = "";
            List<Student> list = new List<Student>();
            while (text != "end")
            {
                string[] data = text.Split(' ');
                firstName = data[0];
                lastName = data[1];
                age = int.Parse(data[2]);
                homeTown = data[3];                                
                if (IsStudentExisting(list, firstName, lastName))
                {
                    Student student = GetStudent(list, firstName, lastName);
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    list.Add(student);
                }
                text = Console.ReadLine();
            }
            string cityname = Console.ReadLine();
            foreach (Student student in list)
            {
                if (student.HomeTown == cityname)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        public class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
        static bool IsStudentExisting(List<Student> list,string firstName,string lastName)
        {
            foreach (Student student in list)
            {
                if(student.FirstName == firstName&& student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> list, string firstName, string lastName) 
        {
            Student existingStudent = null;
            foreach (Student student in list)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        
        }

    }
}
