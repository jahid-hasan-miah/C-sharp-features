using System;
using System.Collections.Generic;
using System.Linq;

namespace Resturant
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing data for 2001
            var list1 = new List<Data>()
            {
                new Data{resturantID=1,resturantName="Tajmohol",year=2001,revenue=500000},
                new Data{resturantID=2,resturantName="Rajmohol",year=2001,revenue=550000},
                new Data{resturantID=3,resturantName="Shalbon",year=2001,revenue=400000},
                new Data{resturantID=4,resturantName="Shurma",year=2001,revenue=560000},
                new Data{resturantID=5,resturantName="Kashbon",year=2001,revenue=650000},
                new Data{resturantID=6,resturantName="Handi",year=2001,revenue=750000}
            };

            //initializing data for 2002
            var list2 = new List<Data>()
            {
                new Data{resturantID=1,resturantName="Tajmohol",year=2002,revenue=400000},
                new Data{resturantID=2,resturantName="Rajmohol",year=2002,revenue=520000},
                new Data{resturantID=3,resturantName="Shalbon",year=2002,revenue=410000},
                new Data{resturantID=4,resturantName="Shurma",year=2002,revenue=760000},
                new Data{resturantID=5,resturantName="Kashbon",year=2002,revenue=630000},
                new Data{resturantID=6,resturantName="Handi",year=2002,revenue=850000}
            };

            //initializing data for 2003
            var list3 = new List<Data>()
            {
                new Data{resturantID=1,resturantName="Tajmohol",year=2003,revenue=550000},
                new Data{resturantID=2,resturantName="Rajmohol",year=2003,revenue=580000},
                new Data{resturantID=3,resturantName="Shalbon",year=2003,revenue=460000},
                new Data{resturantID=4,resturantName="Shurma",year=2003,revenue=550000},
                new Data{resturantID=5,resturantName="Kashbon",year=2003,revenue=690000},
                new Data{resturantID=6,resturantName="Handi",year=2003,revenue=950000}
            };

            //query1:joining list1 and list2 using query
            var result1 = list1.Union(list2).ToList();

            //query1:joining resul1 and list3 using query
            var result2 = from r in result1
                          join re in list3
                          on r.resturantID equals re.resturantID
                          select new
                          {
                              name=r.resturantName,
                              year=r.year,
                              revenue = r.revenue
                          };

            //query3:joining list1 and list2 using query
            var result3 = result1.Union(list3).ToList();

            //query4:ascending by revenue and descending by year
            var result4 = from r in result3
                          orderby r.revenue,r.year descending
                          orderby r.resturantName
                          select r;

            //query5:group by year
            var result5 = from r in result3
                          group r by r.year;

            //printing result2
            Console.WriteLine("----------query-2--------");
            foreach (var r in result2)
            {
                Console.WriteLine(r.name +" "+ r.year +" "+ r.revenue);
            }

            //printing result3
            Console.WriteLine("-------------------------");
            Console.WriteLine("----------query-3--------");
            foreach (var r in result3)
            {
                Console.WriteLine(r.resturantName + " " + r.year + " " + r.revenue);
            }

            //printing result4
            Console.WriteLine("-------------------------");
            Console.WriteLine("----------query-4--------");
            foreach (var r in result4)
            {
                Console.WriteLine(r.resturantName + " " + r.year + " " + r.revenue);
            }

            //printing result5
            Console.WriteLine("-------------------------");
            Console.WriteLine("----------query-5--------");
            foreach (var r in result5)
            {
                Console.WriteLine(r.Key);
                Console.WriteLine("-------------------------");
                foreach(var re in r)
                {
                    Console.WriteLine(re.resturantName + " " + re.year + " " + re.revenue);
                }
                Console.WriteLine("-------------------------");
            }
        }
    }
}
