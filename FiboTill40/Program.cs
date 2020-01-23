using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiboTill40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c=0;
            Console.Write(a + " " + b + " ");
            while(c<=40)
            {
                c = a + b;
                a=b;
                b=c;
                if(c<=40)
                 Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
