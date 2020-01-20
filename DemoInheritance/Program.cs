using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Parent pobj=new Parent();
            Child cobj = new Child();
            GrandChild gcobj = new GrandChild();
            pobj.getvalues(12, "c#");
            pobj.Display();
            cobj.getvalues(23, "ASP.NET");
            cobj.Display();
            cobj.Calculate(30);
            gcobj.getvalues(10, "ASP.NetCore");
            gcobj.Display();
            gcobj.Calculate(20);
            gcobj.Multiply(30);*/
            //Vehicle veh = new Vehicle();
            Car alto = new Car("Blue",150,"premium");
            Bus volvo = new Bus();
            //veh.start();
            //veh.stop();
            alto.start();
            alto.Drive();
            alto.fill_fuel();
            alto.stop();
            volvo.start();
            volvo.Run();
            volvo.fill_fuel();
            volvo.stop();
            Console.ReadKey();
        }
    }
    class Parent
    {
        protected internal int a;
        protected string b;
        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public void getvalues(int x, string y)
        {
            this.A = x;
            this.b = y;
        }
        public void Display()
        {
            Console.WriteLine(this.A + " " + this.B);
        }
    }
    class Child:Parent
    {
        protected int c;
        public void Calculate(int num)
        {
            c = this.a + num;
            Console.WriteLine(c);
        }
    }
    class GrandChild:Child
    {
        int d;
        public void Multiply(int num2)
        {
            this.d = num2;
            Console.WriteLine(this.d * this.c * this.a);
        }
    }
}
namespace demoProtected
{
    class ExChild:DemoInheritance.Parent
    {
        public void ExDisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}

