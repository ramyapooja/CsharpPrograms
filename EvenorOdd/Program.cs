using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine(num + " is even");
            else
                Console.WriteLine(num + " is odd");
            Console.ReadKey();
        }
    }
}
