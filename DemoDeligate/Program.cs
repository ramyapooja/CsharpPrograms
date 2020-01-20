using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate
{
    public delegate void deligatePointer();
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            Program p = new Program();
            deligatePointer mydeligate =p.print;
            mydeligate += p.display;//multicast delegate
            mydeligate();
            mydeligate -= p.print;//to remove print
            mydeligate();
            calAreaPointer cptr = Calculate.calArea;//create a delegate object
           
            cptr += Calculate.calDistance;//multiple return only last method
            double area = cptr(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("Welcome to delegate");
        }
        public void display()
        {
            Console.WriteLine("Welcome to multicast delegate");
        }
    }
    class Calculate
    {
        public static double calArea(double r)
        {
            Console.WriteLine("Calsarea");
            return 3.14 * r * r;
        }
        public static double calDistance(double d)
        {
            return d*100;
        }
    }
}
