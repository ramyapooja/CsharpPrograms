using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account number,name,account type,transaction type(d/w),amount and balance:");
            int accno = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string acctype = Console.ReadLine();
            char transtype = char.Parse(Console.ReadLine());
            int amt = int.Parse(Console.ReadLine());
            int balance = int.Parse(Console.ReadLine());
            Accounts c1 = new Accounts(accno, name, acctype, transtype, amt, balance);
            if (transtype == 'd')
            {
                c1.Credit();
                c1.Display();
            }
            else if (transtype == 'w')
            {
                c1.Debit();
                c1.Display();
            }
            else
                Console.WriteLine("Plz enter transaction type as 'd' or 'w'");
          
            Console.ReadKey();
        }
    }
    class Accounts
    {
        static string bName;
        int accno;
        string name;
        string acctype;
        char transtype;
        int amt;
        int balance;
        static Accounts()//static constructor used to initialize static variable
        {
            bName = "SBI";
        }
        public Accounts(int accno,string name,string acctype,char transtype,int amt,int balance)
        {
            this.accno = accno;
            this.name = name;
            this.acctype = acctype;
            this.transtype = transtype;
            this.amt = amt;
            this.balance = balance;
        }
        
        public void Credit()
        {
            balance = balance + amt;
            
        }
        public void Debit()
        {
                balance = balance - amt;
                
        }
        public void Display()
        {
            Console.WriteLine("Bank name is " + bName);
            Console.WriteLine("Account no=" + accno);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Account type is " + acctype);
            Console.WriteLine("Transaction type is " + transtype);
            Console.WriteLine("Balance=" + balance);
        }
    }
}
