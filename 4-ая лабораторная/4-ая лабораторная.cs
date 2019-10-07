using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ая_лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int N;
            double buf;

            Console.WriteLine("Розмір масиву:");
            N = Convert.ToInt32(Console.ReadLine());
            double[] A = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введіть елемент масиву:");
                buf = Convert.ToDouble(Console.ReadLine());
                A[i] = buf;
            }
            for (int i = 0; i < N; i++)
            {
                if (A[i] < A[N - 1] && A[i] > A[0])
                {
                    Console.WriteLine("Знайдено комбінацію:" + A[0] + "<" + A[i] + ">" + A[N - 1]);
                }
                else
                {
                    Console.WriteLine(0);
                }

                Console.ReadKey();
            }
        }
    }
}
