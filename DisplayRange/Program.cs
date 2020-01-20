using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter upper and lower range:");
            int range1 = int.Parse(Console.ReadLine());
            int range2 = int.Parse(Console.ReadLine());
            for(int i=range1+1;i<range2;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
