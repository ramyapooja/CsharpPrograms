using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery obj = new Delivery();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Player details of the delivery");
            Console.WriteLine("2.Run details of the delivery");
            int ch = int.Parse(Console.ReadLine());
            string bowler;
            string batsman;
            int runs;
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the bowler name");
                    bowler = Console.ReadLine();
                    Console.WriteLine("Enter the batsman name");
                    batsman = Console.ReadLine();
                    obj.DisplayDeliveryDetails(bowler,batsman);
                    break;
                case 2:
                    Console.WriteLine("Enter no of runs");
                    runs = int.Parse(Console.ReadLine());
                    obj.DisplayDeliveryDetails(runs);
                    break;
                default:
                    Console.WriteLine("Invald input");
                    break;
            }
            Console.ReadKey();
            
        }
    }
    class Delivery
    {
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Player details of the delivery:");
            Console.WriteLine( bowler + " - " + batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            Console.WriteLine("Runs details of the delivery:");
            if (runs == 4)
                Console.WriteLine("It is a four");
            else if (runs == 6)
                Console.WriteLine("It is a six");
            else
                Console.WriteLine("Runs=" + runs);
        }
    }
}
