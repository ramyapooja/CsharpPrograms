using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton();
            Singleton s1 = Singleton.GetInstance;
            s1.printDetails("hi");
            //Singleton s2 = new Singleton();
            Singleton s2 = Singleton.GetInstance;
            s2.printDetails("Welcome");
            Console.ReadLine();
        }
    }
    sealed class Singleton
    {
        static int count = 0;
        public static Singleton Instance=null;//memory not allotted so object does not exist
        public static Singleton GetInstance
        {
            get
            {
                //instance is null memory will be allotted
                if (Instance == null) return new Singleton();
                else return Instance;//existing instance ref returned
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            
            Console.WriteLine("Printing " + s);
        }
    }
}
