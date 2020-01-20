using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike enfield=new Bike();
            enfield.StartEngine();
            enfield.FillGas(10);
            enfield.Travel(100, 50);
            Console.ReadLine();
        }
    }
    class Bike
    {
            string name;
            string color;
            public void StartEngine()
            {
                Console.WriteLine("Bike started at " + DateTime.Now.Hour);
            }
            public void FillGas(int litre)
            {
                Console.WriteLine("Bike filled with " + litre + " litres");
            }
            public int Travel(int distance,int speed)
            {
                int time = (int)(distance / speed);
                Console.WriteLine("You will reach your destination in " + time+"hours");
                return time;
            }
        
    }
}
