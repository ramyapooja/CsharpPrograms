using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnParse
{
    class ObjectDemo
    {
        static void Main(String[] args)
        {
            int i = 10;
            double d = 10.2;
            float f = 12.5f;
            char c = 'a';
            object o = i;
            object o1 = d;
            object o2 = f;
            object o3 = c;
            object ob = 12;
            int k=(int)ob;
            object ob1 = 12.3;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char c1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
            Console.WriteLine("{0},{1}", ob3, s);
            s = i.ToString();
            Console.WriteLine(s);
            s = d1.ToString();
            Console.WriteLine(s);
            Console.WriteLine("{0},{1},{2},{3}", i, d, f, c);
            Console.WriteLine("{0},{1},{2},{3}", o, o1, o2, o3);
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", ob, k, ob1, d1, ob2, c1);
            Console.ReadKey();
        }
    }
}
