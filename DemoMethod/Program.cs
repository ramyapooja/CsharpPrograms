using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(cal.Add(x, y));
            cal.Subtract(x, y, out int sub);
            Console.WriteLine(sub);
            cal.Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        int val1;
        int val2;
        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }
        public Calculator()
        {

        }
        public Calculator(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public int Add(int num1,int num2)
        {
            return (num1 + num2);
        }
        public int Subtract(int num1,int num2,out int res)
        {
            res= num1 - num2;
            return res;
        }
        /*public void Swap(int num1,int num2)//call by value
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }*/
        public void Swap(ref int num1, ref int num2)//call by reference
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

    }
}
