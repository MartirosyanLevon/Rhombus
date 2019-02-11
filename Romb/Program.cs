using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first digit:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write your second digit:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 1;

            for (int i = 0; i < (x + x + 1); i++)
            {
                if (i < x)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    y -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    y += 1;
                    z -= 2;
                    Console.WriteLine();

                }
            }
            Console.ReadKey();

        }
    }
}
