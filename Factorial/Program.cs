using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of " + num + "=" + fact);
            Console.ReadKey();
        }
    }
}
