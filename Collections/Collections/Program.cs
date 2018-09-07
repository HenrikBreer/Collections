using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> listPerson = new List<Person>();

            Person P1 = new Person { Id = 1, Navn = "Henrik" };
            Person P2 = new Person { Id = 2, Navn = "Børge" };
            Person P3 = new Person { Id = 3, Navn = "Lise" };
            Person P4 = new Person { Id = 4, Navn = "Viggo" };

            listPerson.Add(P1);
            listPerson.Add(P2);
            listPerson.Add(P3);
            listPerson.Add(P4);

            foreach (var p in listPerson)
            {
                Console.WriteLine(p.Navn);
            }

            Console.ReadKey();

            Dictionary<int,Person> dp = new Dictionary<int,Person>();
            dp.Add(10, P1);
            dp.Add(20, P2);
            dp.Add(30, P3);
            dp.Add(40, P4);

            Console.WriteLine("10: "+dp[10].Navn);
            Console.WriteLine("20: " + dp[20].Navn);

            Console.ReadKey();

        }




    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }

}
