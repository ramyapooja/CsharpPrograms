using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnParse
{
    class ConvertDemo
    {
        static void Main(String[] args)
        {
            bool ii = Convert.ToBoolean("true");
            Console.WriteLine(ii);
            bool i1 = Convert.ToBoolean("false");
            Console.WriteLine(i1);
            int i = Convert.ToInt32("1009");
            short j = Convert.ToInt16("100");
            long k = Convert.ToByte("20");
            long l = Convert.ToInt64("23456");
            Console.WriteLine("{0},{1},{2}", i, j, k);
            Console.ReadKey();

        }
    }
}
