using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing list1
            var list1 = new List<Student>() { 
            new Student{Name="jahid",ClassName="bsc",Age=24,Division="dhaka",Group="science"},
            new Student{Name="Hasan",ClassName="bsc",Age=45,Division="Faridpur",Group="arts"},
            new Student{Name="Miah",ClassName="bsc",Age=85,Division="Chittagong",Group="commerce"}
            };

            // initializing list2
            var list2 = new List<Student>()
            {
                new Student{Name="sharmin",ClassName="honors",Age=24,Division="dhaka",Group="english"},
                new Student{Name="Lota",ClassName="Hons",Age=85,Division="comilla",Group="science"},
                new Student{Name="Shorno",ClassName="bss",Age=45,Division="Noakhali",Group="arts"}
            };

            //printing list1
            Console.WriteLine("--------------List-1------------");
            foreach (var Student in list1)
            {
                Console.WriteLine(Student.Name + " " + Student.ClassName + " " + Student.Age + " " + Student.Group);
            }

            //printing list2
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------List-2------------");
            foreach (var Student in list2)
            {
                Console.WriteLine(Student.Name + " " + Student.ClassName + " " + Student.Age + " " + Student.Group);
            }

            //query1: applying linq in list1
            var result = from age in list1
                         where age.Age > 30
                         select age;

            //query2: applying linq in list1
            var result1 = from classname in list2
                          where classname.ClassName == "Hons"
                          select classname;

            //query3:applying linq ascending sort on age
            var result2 = from name in list1
                          orderby name.Age
                          select name;

            //query4:applying linq joining using union
            var result3 = list1.Union(list2).ToList();

            //query5:applying linq ascending sort on name
            List<Student> result4 = new List<Student>(from name in result3
                                    orderby name.Name,name.Age descending
                                    select name);
            //query6:applying linq ascending sort on name and descending sort on age
            List<Student> result5 = new List<Student>(from student in result3
                                                      orderby student.Age
                                                      select student);

            //query7:applying linq group by age
            var result6 = from student in result3
                          group student by student.Age;
                          

            //printing query1 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-1-result----");
            foreach (var age in result)
            {
                Console.WriteLine(age.Age);
            }

            //printing query2 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-1-result----");
            foreach (var classname1 in result1)
            {
                Console.WriteLine(classname1.Name + " " +classname1.Division+" "+ classname1.Group);
            }

            //printing query3 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-3-result----");
            foreach (var nameSort in result2)
            {
                Console.WriteLine(nameSort.Name + " " + nameSort.Division + " " + nameSort.Group);
            }

            //printing query4 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-4-result----");
            foreach (var Student in result3)
            {
                Console.WriteLine(Student.Name + " " + Student.ClassName + " " + Student.Age + " " + Student.Group);
            }

            //printing query5 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-5-result----");
            foreach (var Student in result4)
            {
                Console.WriteLine(Student.Name + " " + Student.ClassName + " " + Student.Age + " " + Student.Group);
            }

            //printing query6 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-6-result----");
            foreach (var Student in result5)
            {
                Console.WriteLine(Student.Name + " " + Student.ClassName + " " + Student.Age + " " + Student.Group);
            }

            //printing query7 result
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------Query-7-result----");
            foreach (var Student in result6)
            {
                Console.WriteLine("Age: "+Student.Key);
                foreach(var s in Student)
                {
                    Console.WriteLine(s.Name + " " + s.ClassName + " " + s.Age + " " + s.Group);
                }
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
