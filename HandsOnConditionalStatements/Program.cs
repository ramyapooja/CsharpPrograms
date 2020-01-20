using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStatements
{
    class Program
    {
        public static string EvenorOdd(int i)
        {
            if (i % 2 == 0)
            {
               return "Even";

            }
            else
            {
                return "Odd";
            }
        }
        public static int Max(int i,int j, int k)
        {
            if(i>j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1,double m2,double m3,double m4,double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg >= 70)
            {
                return "Distinction with " + avg +"%";
            }
            else if ((avg >= 60) && (avg < 70))
            {
                return "First class with " + avg +"%";
            }
            else if ((avg >= 50) && (avg < 60))
            {
                return "Second class with " + avg+"%";
            }
            else
                return "Fail";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no:");
            int i = int.Parse(Console.ReadLine());
            string result = EvenorOdd(i);
            Console.WriteLine(result);
            Console.WriteLine(Max(4, 3, 5));
            Console.WriteLine(Result(50, 60, 65, 87, 79));
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());
            double m4 = Convert.ToDouble(Console.ReadLine());
            double m5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Result(m1, m2, m3, m4, m5));
            Console.ReadKey();
        }
    }
}
