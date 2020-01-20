using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string str = "welcome";
            Console.WriteLine(str.Length + " " + str.Replace("e", "k") + str.ToLower());
            Console.WriteLine(str.Contains("lc"));
            Console.WriteLine(String.Compare("Hello", "hello"));
            string str2 = "WELCOME";
            Console.WriteLine(str.Equals(str2,StringComparison.InvariantCultureIgnoreCase));
            string input = Console.ReadLine();
            string[] data = input.Split(' ','/');
            int[] num2 = Array.ConvertAll(data, Convert.ToInt32);
            int[] num = new int[data.Length];
            for(int j=0;j<data.Length;j++)
            {
                num[j] = Convert.ToInt32(data[0]);
            }
            foreach(string val in data)
            {
                Console.WriteLine(val);
                
            }
            int k = 90;
            double d = 2.345;
            Console.WriteLine(k.ToString() + " " + d.ToString());
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dd/mm/yyyy") + " " + dt.ToString("MMM,dd/MM/yyyy HH:mm:ss"));*/
            
            Employee[] eArray = new Employee[3] { new Employee("arun", "100", 20000),
                                              new Employee("raj","200",30000),
                                               new Employee("renu","300",40000)};
            foreach(Employee e in eArray)
            {
                Console.WriteLine(e.ToString());
            }
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("Ram", "100", 10000));
            elist.Add(new Employee("Ramya", "200", 30000));
            elist.Add(new Employee("Sai", "300", 50000));
            Employee e1 = new Employee("Ram", "100", 10000);
            Employee e2 = new Employee("Ram", "100", 10000);
            if(e1.Equals(e2))
            {
                Console.WriteLine("Both are same employees");
            }
            else
            {
                Console.WriteLine("not same employees");
            }
            Console.ReadKey();
        }
    }
    class Employee
    {
        string name;
        string empid;
        int salary;
        public Employee()
        {

        }
        public Employee(string name,string empid,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return (this.name+"\n"+this.empid+"\n"+this.salary);
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empid == temp.empid && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
