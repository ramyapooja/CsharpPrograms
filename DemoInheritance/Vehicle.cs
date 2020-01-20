using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    abstract class Vehicle
    {
        protected string color;
        public Vehicle()//parent default constructor invoke automatically for all child object
        {
            this.color = "white";
            Console.WriteLine("constructor from vehicle");
        }
        public Vehicle(string clr)//parent parameter constructor has to be invoked using base keyword and providing value
        {
            this.color = clr;
            Console.WriteLine("parameterized constructor");
        }
        public abstract void fill_fuel();//child should compulsory override
        public virtual void start()//child may or may not override
        {
            Console.WriteLine("Vehicle started");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle stopped");
        }

    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus():base("Red")
        {
            this.seating = 80;
            this.speed = 120;
            Console.WriteLine("constructor from bus");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("filled diesel");
        }    

        public void Run()
        {
            Console.WriteLine(this.color+"Bus is running at speed"+this.speed+" with "+seating+" passengers");
        }
        public override void start()
        {
            Console.WriteLine("Bus is starting");
        }
    }
    class Car:Vehicle
    {
        string type;
        int speed;
        public Car()
        {
            this.speed = 154;
            this.type = "standard";
            Console.WriteLine("constructor from car");
        }
        public Car(string clr,int spd,string type):base(clr)
        {
            this.speed = spd;
            this.type = type;

        }
        public override void fill_fuel()
        {
            Console.WriteLine("filled diesel/petrol/gas");
        }
        public void Drive()
        {
            Console.WriteLine(this.color+"Car is driving at speed"+speed+" type"+this.type);
        }
    }
}
