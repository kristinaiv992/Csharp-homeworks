using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace homework1
{
    class Program
    {
        static void Main()
        {
            ------Task 0 christmas tree(already solved in my previous 2 files attached here(find in program.cs)----// 
            int i, j, space = 10, space1 = 1;
            for (i = 0; i < space; i++)
            {
                for (j = i; j < space; j++)
                {
                    Console.Write(" ");
                }

                for (j = 0; j < space1; j++)
                {
                    Console.Write(" *");
                }
                space1 = space1 + 1;
                Console.Write("\n");
            }

            -------------------Task 1 easy star pattern------------------------------------ -// 

            var oldColor = Console.ForegroundColor;
            int i, j, space = 10;
            for (i = 0; i < space; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                    Thread.Sleep(50);
                }
                Console.Write("\n");
                Console.ForegroundColor = oldColor;
            }
            Console.ReadLine();

            ----------Task 2 easy star pattern(The same pattern in different direction)------ -// 

            int i, j, space = 10, star = 1;
            var myOldColour = Console.ForegroundColor;
            for (i = 0; i < space; i++)
            {
                for (i = space; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < star; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("*");
                    Thread.Sleep(50);

                }
                space--;
                star++;
                Console.Write("\n");
                Console.ForegroundColor = myOldColour;

            }
            Console.ReadLine();


            -------------------Task 3 easy star pattern------------------------------------ -// 
            int i, j, stars = 10;

            for (i = stars; i >= 0; i--)
            {
                for (j = stars; j > 0; j--)
                {
                    Console.Write("*");
                }
                stars--;
                Console.Write("\n");
            }

            Console.ReadLine();

            -------------------Task 4 double star pattern diamond-------------------------------------// 

            int i, j, space = 10;
            for (i = 0; i < 11; i++)
            {
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                space--;
                Console.Write("\n");
            }
            space = 0;
            int stars = 11;
            for (i = 11; i > 0; i--)
            {
                for (j = 0; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                space++;
                Console.Write("\n");

            }

            -------------------Task 5 inverted star pattern------------------------------------ -// 

                var oldColour = Console.ForegroundColor;
            int i, j, space = 1;
            for (i = 10; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("* ");
                }
                for (j = 0; j < space; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(". ");
                }
                for (j = 0; j < i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("* ");
                }
                Console.Write("\n");
                space += 2;
            }
            -------------------Task 6 empthy triangle star pattern -------------------------------------// 

            int i, j, space = 10;
            for (i = 0; i <= space; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i || i == space)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.Write("\n");
            }

            -------------------Task 7 empthy inverted triangle star pattern------------------------------------ -// 

            int i, j, space = 11;
            for (i = 1; i <= space; i++)
            {
                for (j = i; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    if (i == space || j == 1 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

            -------------------Task 8 aside triagle-------------------------------------// 

            int i, j, space = 1, space1 = 9;
            for (i = 0; i < 11; i++)
            {
                for (j = 0; j < space; j++)
                {
                    Console.Write("* ");
                }
                space++;
                Console.Write("\n");
            }
            for (i = 0; i < 11; i++)
            {
                for (j = space1; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                space1--;
                Console.Write("\n");
            }

            -------------------Task 9 half pyramide made of binary numbers LOOOL------------------------------------ -// 

            int i, j, k, space = 10, space1 = 0;
            for (i = 0; i < space; i++)
            {
                for (j = i; j < space; j++)
                {
                    Console.Write(' ');
                }
                for (k = 0; k <= space1; k++)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.Write("\n");
                space1++;
            }
            -------------------Task 10 number pyramid-------------------------------------//

            int i, j, k, l = 1, space = 5;
            for (i = 0; i < space; i++)
            {
                for (j = i; j < space; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= l; k++)
                {
                    Console.Write(k);
                }
                l = l + 2;
                Console.Write("\n");
            }

            -------------------Task 11 alphabetical pyramid-------------------------------------//

            int i, j, space = 10;
            char ch = 'a';
            for (i = 0; i < space; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write(ch++);
                }

                Console.Write("\n");
            }

            -------------------Task 12 empthy diamond-------------------------------------//


            int i, j;
            int space = 10;
            for (i = 1; i <= space; i++)
            {
                for (j = space; j > i; j--)
                {
                    Console.Write(" ");
                }
                Thread.Sleep(350);
                Console.Write("*");
                for (j = 1; j < (i - 1) * 2; j++)
                {
                    Console.Write(" ");
                }
                if (i == 1) Console.WriteLine();
                else
                    Console.WriteLine("*");
            }
            //---//
            for (i = space; i >= 1; i--)
            {
                for (j = space; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (j = 1; j < (i - 1) * 2; j++)
                {
                    Console.Write(" ");
                }
                if (i == 1) Console.WriteLine();
                else Console.WriteLine("*");
            }

            -------------------Task 13 empthy triangle-------------------------------------//
            int i, j;
            int MAX = 10;
            for (i = 1; i <= MAX; i++)
            {
                for (j = i; j < MAX; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    if (i == MAX || j == 1 || j == (2 * i - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }


    }
    }
            

        
    
    

