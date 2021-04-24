using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqJoinQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<StudentList>()
            {
                new StudentList{ studentName = "jhon", Age = 20, standardId = 1, studentId = 1 },
                new StudentList{ studentName = "cena", Age = 22, standardId = 1, studentId = 2},
                new StudentList{ studentName = "dawayne", Age = 21, studentId = 3, standardId=2},
                new StudentList{ studentName = "jhonson", Age = 19, standardId = 2, studentId=4},
                new StudentList{ studentName = "Rock", Age = 20, studentId = 5, standardId = 3},
                new StudentList{ studentName = "Randy", Age = 19, standardId = 3, studentId = 6},
                new StudentList{ studentName = "Orton", Age = 21, studentId = 7, standardId = 4},
                new StudentList{ studentName = "Smith", Age = 19, standardId = 4, studentId = 8}
            };

            var list2 = new List<StudentList>()
            {
                new StudentList{ studentName = "jhon", Age = 20, standardId = 1, studentId = 1 },
                new StudentList{ studentName = "cena", Age = 22, standardId = 1, studentId = 2 },
                new StudentList{ studentName = "dawayne", Age = 21, studentId = 3, standardId = 2}
            };

            var list3 = new List<StandadList>()
            {
                new StandadList{ standardID=1, standardName = "Standard-1"},
                new StandadList{ standardID=2, standardName = "Standard-2"},
                new StandadList{ standardID=3, standardName = "Standard-3"},
                new StandadList{ standardID=4, standardName = "Standard-4"}
            };

            //query1:joining by query union syntax
            var result1 = list1.Union(list2).ToList();

            //printing query1 result
            foreach(var s in result1)
            {
                Console.WriteLine(s.studentName + " " + s.studentId);
            }

            //query2:joining by query join syntax
            var result2 = from s in list1
                          join st in list3
                          on s.standardId equals st.standardID
                          select new
                            {
                                studentid = s.studentId,
                                standardId=st.standardID,
                                age = s.Age,
                                studentName = s.studentName,
                                standardName = st.standardName

                            };

            //printing qurey2 result
            Console.WriteLine("------------------------");
            Console.WriteLine("----------query-2-------");
            foreach(var s in result2)
            {
                Console.WriteLine("Id:" + s.studentid + "  StandardName:" + s.standardName + "  Name:" + s.studentName + "  Age:" + s.age);
            }

            //query3:joining by query join syntax
            var result3 = from student in list1
                          group student by student.standardId;

            //printing qurey3 result
            Console.WriteLine("------------------------");
            Console.WriteLine("----------query-3-------");
            foreach(var s in result3)
            {
                Console.WriteLine("StandardId :" + s.Key);
                foreach(var a in s)
                {
                    Console.WriteLine("Name:" + a.studentName);
                }
                Console.WriteLine("------------------------");
            }
        }
    }
}
