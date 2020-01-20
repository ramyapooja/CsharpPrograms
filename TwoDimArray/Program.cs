using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[5, 3];
            
            for(int row=0;row<5;row++)
            {
                Console.WriteLine("Enter marks of student" + (row + 1));
                for(int col=0;col<3;col++)
                {
                    Console.WriteLine("Enter sub" + (col + 1));
                    marks[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    Console.WriteLine(marks[row, col]);
                }
                Console.WriteLine();
            }
            /* foreach(int x in marks)
             {
                 Console.WriteLine(x);
             }
             Console.ReadKey();*/
            
            for(int col=0;col<3;col++)
            {
                int topscore = 0;
                for(int row=0;row<5;row++)
                {
                    if (row == 0)
                        topscore = marks[row, col];
                    else
                    {
                        if (marks[row, col] > topscore)
                            topscore = marks[row, col];
                    }

                }
                Console.WriteLine("Highest for subject" + (col + 1) + " is " + topscore);
            }
            Console.ReadKey();
        }
    }
}
