using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariablesWithDatatype
{
    class Program
    {
        string name;
        static double salary;
        static void Main(string[] args)
        {
            int i=4;
            int[] a = new int[4] { 2, 4, 6, 8 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            object o1 = 100;
            o1 = 'a';
            o1 = 12.3;
            int k = 10;
            string name = "Rohan";
            Console.WriteLine("Name:{0} Age:{1}", name, k);
            Console.ReadKey();
        }
    }
}
