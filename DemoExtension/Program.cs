using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtension
{
    static class StringHelper//by using extension method we can extend the function
    {//helper class must be static
        public static string FirstCaseChange(this string name)//this should be used as parameter
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
            return new string(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.FirstCaseChange());
            var anonymousType = new { property1 = "Ajay", property2 = 12, property3 = true };
            Console.WriteLine(anonymousType.GetType());
            Console.ReadLine();
        }
    }
}
