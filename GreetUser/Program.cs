﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi! " + name);
            Console.WriteLine("Welcome to the world of c#");
            Console.ReadKey();

        }
    }
}
