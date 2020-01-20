using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Shape picture=new Shape();
             picture.draw();
             picture.draw(10);
             picture.draw(10, 20);
             picture.draw(12, 23, 12);
             picture.draw(1, 1, 1, "cube");*/


           /* A obj = new A();
            obj.display();
            B obj1 = new B();
            obj1.display();
            C obj2 = new C();
            obj2.display();
            Console.ReadKey();*/



            /*A obj = new A();//displays only A
            obj.display();
            obj = new B();
            obj.display();
            obj = new C();
            obj.display();*/

            A obj;
            obj = new B();//displays only B and C
            obj.display();
            obj = new C();
            obj.display();
            Console.ReadKey();
        }
    }
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()//function overloading
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int w)
        {
            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l,int w,int b)
        {
            Console.WriteLine("A box can be drawn");
        }
        public void draw(int l,int w,int b,string name)
        {
            Console.WriteLine(name+" can be drawn");
        }
    }
    abstract class A
    {
        /*public virtual void display()//function overriding
        {
            Console.WriteLine("display A class details");
        }*/
        public abstract void display();
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B class details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display C class details");
        }
    }
}
