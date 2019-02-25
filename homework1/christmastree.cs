using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main()
        {
           int i, j;
            int space = 20;
            int stars = 1;
            var oldColor = Console.ForegroundColor;
            for (i = 0; i < space; i++)
            {
                
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < stars; j++)
                {
                Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                }
                    stars++;
                Console.WriteLine();
                space--;   
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                    ||");
            Console.WriteLine("                    ||");
            Console.ForegroundColor = oldColor;
            Console.ReadKey();

        }
        }
    }

