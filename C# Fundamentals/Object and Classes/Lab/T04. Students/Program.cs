using System;
using System.Collections.Generic;

namespace T04._Students
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
            List<Student> list=new List<Student>();
            while(text != "end")
            {
                string[] data = text.Split(' ');
                firstName = data[0];
                lastName = data[1];
                age = int.Parse(data[2]);
                homeTown = data[3];                
                Student student = new Student(firstName, lastName, age, homeTown);
                list.Add(student);
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
            public int Age  { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
