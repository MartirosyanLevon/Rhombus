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
            Console.WriteLine("If you want to draw rombus");
            Console.Write("Write your first digit:");
            Console.Write(" Height = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your second digit:");
            Console.Write(" Width = ");
            int l = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            int y = 0;

            for (int i = 0; i < (x + x + 1); i++)
            {
                if (i < x)
                {
                    for (int j = 0; j < (y = l); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    l -= 1;
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < (y = l); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    l += 1;
                    z -= 2;
                    Console.WriteLine();

                }
            }
            Console.ReadKey();

        }
    }
}
