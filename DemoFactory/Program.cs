using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    //product interface
    interface IFactory
    {
        void Manufacture(int cnt);

    }
    //creation of product class
    class Bike : IFactory
    {
        public void Manufacture(int cnt)
        {
            Console.WriteLine("Bike Manufacturing No: " + cnt);
        }
    }
    //creation of product class
    class Car : IFactory
    {
        public void Manufacture(int cnt)
        {
            Console.WriteLine("Car Manufacturing No: " + cnt);
        }
    }
   //create
    abstract class VehicleFactory
    {
        public abstract IFactory generateVehicles(string type);
    }
    //actual creation class
    class ConcreteVehicleFactory:VehicleFactory
    {
        public override IFactory generateVehicles(string type)
        {
            if (type == "Bike")
                return new Bike();
            else 
                return new Car();
             
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConcreteVehicleFactory();
            IFactory myvehicle = obj.generateVehicles("Bike");
            myvehicle.Manufacture(10);
            myvehicle = obj.generateVehicles("Car");
            myvehicle.Manufacture(20);
            Console.ReadLine();
        }
    }
}
