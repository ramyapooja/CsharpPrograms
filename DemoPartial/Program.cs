using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            obj.print();
            Console.ReadLine();
        }
    }
    partial class ClassA//partial method only be created in partial calss
    {
        partial void setData();//partial method declaration
        public void print()
        {
            Console.WriteLine("classA printing");
            setData();//partial method should be private
        }
    }
    partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("Data is assigned using partial");
        }
    }
}
