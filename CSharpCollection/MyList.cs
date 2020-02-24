using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCollection
{
    public static class MyList
    {

        public static void GetStudentsStandardWise()
        {
            List<Student> students = new List<Student>()
        {
            new Student() { Id=1001, Name="Aa", StandardId = 1},
            new Student() { Id=1002, Name="Bb", StandardId = 2},
            new Student() { Id=1003, Name="Cc", StandardId = 1},
            new Student() { Id=1001, Name="Dd", StandardId = 1}
        };

            IEnumerable<int> standards = students.Select(x => x.StandardId).Distinct();

            string i = students.ElementAt(1).Name;
            // var standards = from num in students                      
            //         select num.StandardId;

            foreach (var standard in standards)
            {
                Console.WriteLine("Standard " + standard + " :");
                var studentList = students.Where(x => x.StandardId == standard);
                foreach (var student in studentList)
                {
                    Console.WriteLine(student.Name);
                }
            }



            int[] intArray = { 0, 1, 4, 3, 2, 6, 9, 7,0 };

            int highest = intArray.Max();

            int secHigh = (from num in intArray
                     orderby num ascending
                     select num).Distinct().Skip(1).First();

        }

    }
     
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StandardId { get; set; }


    }
}
