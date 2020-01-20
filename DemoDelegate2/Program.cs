using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate2
{
    public delegate double calAreaPointer(double x);
    class Program
    {
       
            

        static void Main(string[] args)
        {
            //method reference  directly
            //calAreaPointer cptr = new calAreaPointer(calArea);
            //anonymous method
            calAreaPointer cptr = new calAreaPointer(delegate(double r) {
                
                return 3.14 * r * r;
            });
            //above code can simpliy in lambda
            calAreaPointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            double area = cptr(12);
            Console.WriteLine(area);
            Console.WriteLine(area1);
            //prebuild delegates Func<>,Action<>,Predicate<>
            //Func delegate can have input and output parameter
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(14);
            Console.WriteLine(area2);
            Action<string> act = (x => Console.WriteLine(x));
            act("Welcome");
            Predicate<string> pt = (y => y.Length > 3);
            int[] array = new int[] { 1, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("Ramya");
            names.Add("Pooja");
            names.Add("Sai");
            int c1 = array.Count(c => c > 2);
            Console.WriteLine(c1);
            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }
            //Console.WriteLine(pt("cts"));
            Console.ReadLine();
        }
        /*public static double calArea(double r)
        {
            return 3.14 * r * r;
        }*/
    }
}
