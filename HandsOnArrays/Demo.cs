using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            
            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
