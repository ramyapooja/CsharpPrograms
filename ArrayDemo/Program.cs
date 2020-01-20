using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter a[{0}]:" + i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int min = 0, max = 0;
            for(int i=0;i<n;i++)
            {
                if(i==0)
                {
                    min = a[0];
                    max = a[0];
                }
                if(a[i]>max)
                {
                    max = a[i];    
                }
                if(a[i]<min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Largest=" + max);
            Console.WriteLine("Smallest=" + min);
            Console.ReadKey();
        }
    }
}
