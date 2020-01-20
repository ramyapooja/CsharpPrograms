using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            ThreadClass tobj = new ThreadClass();
            Thread th = new Thread(tobj.countEven);
            Thread th1 = new Thread(tobj.countOdd);
            //to set priority assign thread priority properties
            th.Priority = ThreadPriority.AboveNormal;
            th1.Priority = ThreadPriority.Highest;
            //thread moves runnable state
            th.Start();
            th1.Start();
            //th.Suspend();
            //Console.WriteLine("thread got suspended");
            //th.Resume();
            //if (!th1.IsAlive) th.Interrupt();
            Console.WriteLine("Main ends");
            Console.ReadLine();
        }
    }
    class SyncClass
    {
        public void display(int x)
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class ThreadClass
    {
        SyncClass sd = new SyncClass();
        public void countEven()
        {
            //lock (this)
            Monitor.Enter(this);
            {
                sd.display(20);
                /*for (int i = 0; i < 100; i += 2)
                {
                    Console.WriteLine(i);
                    if (i == 50) Thread.Sleep(300);
                }*/
            }
            Monitor.Exit(this);
        }
        public void countOdd()
        {
            /*for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }*/
            Monitor.Enter(this);
            {
                sd.display(20);
            }
            Monitor.Exit(this);
        }
    }
}
