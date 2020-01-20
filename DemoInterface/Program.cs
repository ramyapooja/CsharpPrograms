using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI iobj = new ICICI("ICICI 001", "Chennai", "Arun");
            SBI sobj = new SBI("SBI 003", "Hyderabad", "Jaya");
            iobj.displayDetails();
            iobj.getInterest();
            iobj.getGoldLoan();
            iobj.displayDmat();
            sobj.displayDetails();
            sobj.getInterest();
            sobj.getGoldLoan();
            sobj.displayDmat();
            Console.ReadKey();
        }
    }
    interface ILoan
    {
        void getInterest();
        
    }
    interface IGLoan : ILoan
    {
        void getGoldLoan();
    }
    interface IDmat
    {
        void displayDmat();
    }
    public abstract class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bname = bname;
            this.location = location;
        }
    }
    public class SBI:Bank,ILoan
    {
        string bHead;
        public SBI(string bname,string loc,string bmgr):base(bname,loc)
        {
            this.bHead = bmgr;
        }
        public void getInterest()
        {
            Console.WriteLine("SBI loan interest rate is 12%");
        }
        public void getGoldLoan()
        {
            Console.WriteLine("SBI gold loan interest rate is 20%");
        }
         
        public void displayDmat()
        {
            Console.WriteLine("SBI can start Dmat accounts");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bHead);
        }
    }
    public class ICICI : Bank,ILoan
    {
        string bHead;
        public ICICI(string bname, string loc, string bmgr) : base(bname, loc)
        {
            this.bHead = bmgr;
        }
        public void getInterest()
        {
            Console.WriteLine("ICICI loan interest rate is 17%");
        }
        public void getGoldLoan()
        {
            Console.WriteLine("ICICI gold loan interest rate is 22%");
        }
        public void displayDmat()
        {
            Console.WriteLine("ICICI can start Dmat accounts");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bname + " " + this.location + " " + this.bHead);
        }
    }

}
