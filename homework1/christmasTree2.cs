using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_kristinaivanova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Christmas Tree\n");
            var oldColor = Console.ForegroundColor;
            int i, j, k, rows, cols;
            for (i = 0; i <= 4; i++)
            {
                for (j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for(rows=0; rows<2; rows++)
            {
                for(cols=0; cols<3; cols++)
                {
                    Console.Write(" ");
                }
                for (k = 0; k < 2; k++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = oldColor;


            Console.ReadLine();

        }
    }
}

