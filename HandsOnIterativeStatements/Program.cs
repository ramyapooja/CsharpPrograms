using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
        public static void Greet(string name)
        {
            int flag = 1;
            while(flag<=5)
            {
                Console.WriteLine("Hello " + name);
                flag++;
            }
        }
        public static void DisplayNaturalNos(int i)
        {
            int flag = 1;
            while(flag<=i)
            {
                Console.Write(flag + " ");
                flag++;
            }
        }
        public static void DisplayWholeNos(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFactorial(int k)
        {
            int fact = 1;
            int i = 1;
          /*  for(int i=1;i<=k; i++)
            {
                fact *= i;
            }
            return fact;*/
            for(; ; )
            {
                if(i<=k)
                {
                    fact *= i;
                    i++;
                }
                else
                {
                    break;
                }
            }
            return fact;
        }
        public static void DisplayEven(int no)
        {
            for(int j=1;j<=no;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.Write(j + "\t");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid input";
                    break;

            }
            return result;
        }
       
        static void Main(string[] args)
        {
            //Greet("Ramya");
           // DisplayNaturalNos(5);
           // DisplayWholeNos(5);
            //Console.WriteLine();
           // Console.WriteLine(ReturnFactorial(5));
           // DisplayEven(10);
            Console.WriteLine(CheckVowel('a'));
            Console.ReadKey();
        }
    }
}
