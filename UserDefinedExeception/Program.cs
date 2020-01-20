using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExeception
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Mala", "100", 0);
            double sal = double.Parse(Console.ReadLine());
            try
            {
                if (emp.sal == 0) throw new SalaryException("Salary cannot be zero");
            }
            catch(SalaryException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        string name;
        string id;
        public double sal;
        public Employee(string name,string id,double sal)
        {
            this.name = name;
            this.id = id;
            this.sal = sal;
        }

    }
    public class SalaryException:Exception
    {
        public SalaryException(string s):base(s)
        {

        }
    }
}
