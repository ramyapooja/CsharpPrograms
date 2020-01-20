using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            string[] names = new string[8] { "Rohan", "Rajan", "Suren", "Jeson", "Monica", "Sachin", "Komal", "David" };
            /*string[] names = new string[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Enter name{0}:"i + 1);
                names[i] = Console.ReadLine();
            }*/
            string input = Console.ReadLine();
            int flag = 0,i=1;
            foreach(string s in names)
            {
                if(s==input)
                {
                    
                    flag = 1;
                    break;
                }
                i++;
            }
            if (flag == 1)
                Console.WriteLine("Name exists in array at position"+i);
            else
                Console.WriteLine("Name doesn't exist in array");
            Console.ReadKey();
        }
    }
}
