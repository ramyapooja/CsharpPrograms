using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 10;
            i[1] = 20;
            i[2] = 30;
            i[3] = 40;
            int k = i[2];
            Console.WriteLine(i[1]);
            for(int a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
            }
            foreach(int no in i)
            {
                Console.WriteLine(no);
            }
            Console.ReadKey();

        }
    }
}
