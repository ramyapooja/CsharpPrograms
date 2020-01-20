using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("Raj", "111", 10000));
            elist.Add(new Employee("Rajesh", "1q12", 20000));
            elist.Add(new Employee("John", "115", 14000));
            elist.Add(new Employee("Ajay", "116", 12000));
            List<Employee> highpay=elist.FindAll(e=>e.salary>12000);
            foreach (Employee e1 in highpay)
                Console.WriteLine(e1.ToString());
            Console.ReadLine();
        }  
    
    }
    public class Employee
    {
        string name;
        string id;
      
        
        public int salary { get; set ; }
        public Employee(string name, string id, int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }
        public override string ToString()
        {
            return (this.name + "\n" + this.id + "\n" + this.salary);
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.id == temp.id && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
