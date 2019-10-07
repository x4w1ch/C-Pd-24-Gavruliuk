using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ая_лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int m, n, u;
            double min=0, max=0;

            Console.WriteLine("m:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n:");
            n = Convert.ToInt32(Console.ReadLine());

            double[,] C = new double[m, n];
            double[,] B = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (u = 0; u < n; u++)
                {
                    Console.WriteLine("Введіть елемент масиву:");
                    B[i, u] = Convert.ToDouble(Console.ReadLine());
                    C[i, u] = B[i, u];
                }
            }
            //////// Мінімальне значення
            for (int a = 0; a < m; a++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (B[a, i] > B[a, i + 1])
                    {
                        B[a, i] = B[a, i + 1];
                    }
                    else
                    {
                        B[a, i + 1] = B[a, i];
                    }
                    min = B[a, i];
                }
                Console.WriteLine("Мінімальне в " + (a + 1) + ":" + min);
                ////////

                //////// Максимальне значення           
            }
            for (int a = 0; a < m; a++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (C[a, i] < C[a, i + 1])
                    {
                        C[a, i] = C[a, i + 1];
                    }
                    else
                    {
                        C[a, i + 1] = C[a, i];
                    }
                    max = C[a, i];
                }
                Console.WriteLine("Максимальне в " + (a + 1) + ":" + max);
            }

            Console.ReadKey();
        }
    }
}
