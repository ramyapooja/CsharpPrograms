using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterative1
{
    class Program
    {
        public static void Menu(int i,int j)
        {
            switch(j)
            {
                case 1:
                    if(i%2==0)
                    {
                        Console.Write("Even");
                    }
                    else
                    {
                        Console.Write("Odd");
                    }
                    break;
                case 2:
                    for(int x=1;x<=i; x++)
                    {
                        Console.Write(x+" ");
                    }
                    break;
                case 3:
                    for(int x=1;x<=10;x++)
                    {
                        Console.WriteLine(i + "*" + x + "=" + i * x);
                    }
                    break;
                case 4:

                    break;
                default:
                    Console.Write("Invalid choice");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even/odd");
            Console.WriteLine("2.Natural numbers");
            Console.WriteLine("3.Multiplication Table");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your Choice:");
            int choice = int.Parse(Console.ReadLine());
            Menu(a, choice);
            Console.ReadKey();
        }
    }
}
