using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            Console.ReadKey();


        }

     }

    public class Kort
    {
        public string Kulør { get; set; }
        public int  Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> Kortbunke= new Stack<Kort>();
        public void TilføjKort(Kort k)
        {
            Kortbunke.Push(k);
        }
        public Kort FjernKort()
        {
            return Kortbunke.Pop();
        }

        public void Vis()
        {
            foreach (var k in Kortbunke)
            {
                Console.WriteLine(k.ToString());
            }

        }

        

    }
}
