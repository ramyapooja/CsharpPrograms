using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            i = 20;
            dynamic x;
            x = 67;
            x = "abc";
            ArrayList a1 = new ArrayList();
            a1.Add(5);
            a1.Add("Ramya");
            a1.Add(2.3);
            a1.Add('d');
            foreach (var val in a1)
                Console.WriteLine(val);
            a1.Remove(2.3);
            Console.WriteLine();

            foreach (var val in a1)
                Console.WriteLine(val);
            Queue qlist = new Queue();
            qlist.Enqueue(10);
            qlist.Enqueue("Pooja");
            qlist.Enqueue('V');
            Console.WriteLine();
            foreach (var val in qlist)
                Console.WriteLine(val);
            qlist.Dequeue();
            foreach (var val in qlist)
                Console.WriteLine(val);
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("Hello");
            slist.Push(23.123);
            foreach (var s in slist)
                Console.WriteLine(s);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);
            Hashtable ht = new Hashtable();
            ht.Add(1, "CTS");
            ht.Add('a', 1000);
            ht.Add("t1", 300);
            foreach(var val in ht.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);
            }
            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');//ASCII value of 'a'
            list.Add(55);
            foreach(int val in list)
            {
                Console.WriteLine(val);
            }
            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("10");
            gqlist.Enqueue("Pooja");
            gqlist.Enqueue("V");
            Console.WriteLine();
            foreach (var val in gqlist)
                Console.WriteLine(val);
            gqlist.Dequeue();
            foreach (var val in gqlist)
                Console.WriteLine(val);
            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(12.356f);
            gslist.Push(23.123f);
            foreach (var s in gslist)
                Console.WriteLine(s);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);
            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(200);
            hs.Add(30);
            hs.Add(10);
            foreach (int val in hs)
                Console.WriteLine(val);
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Ramya");
            dt.Add(2, "Pooja");
            dt.Add(3, "Sai");
            foreach(KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }
            Dictionary<string, double> dt1 = new Dictionary<string, double>();
            Console.WriteLine("Enter count of employees:");
            int count = int.Parse(Console.ReadLine());
            string name;
            double salary;
            for(int e=0;e<count;e++)
            {
                Console.WriteLine("Enter the name of the employee:");
                name = Console.ReadLine();
                Console.WriteLine("Enter the salary of the employee:");
                salary = double.Parse(Console.ReadLine());
                dt1.Add(name, salary);
            }
            double hsalary = 0;
            string hname = "";
            foreach(KeyValuePair<string,double> emp in dt1)
            {
                if(emp.Value>hsalary)
                {
                    hsalary = emp.Value;
                    hname = emp.Key;
                }
            }
            Console.WriteLine("Highest paid employee is " + hname);
            Console.ReadKey();
        }
    }
}
