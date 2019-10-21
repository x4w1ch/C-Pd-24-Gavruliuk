using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_лабка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double sum = 0, k, target;

            Console.WriteLine("Введіть границю:");
            target= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть крок:");
            k = Convert.ToDouble(Console.ReadLine());

            while(k<target && k>0)
            {
                    sum = sum + (Math.Pow(k, 2) - Math.Pow((-1), (k + 1)) * Math.Pow(k, 3)) / (Math.Pow(k, 2) + k + 1);
                k = k + k;
            }
            Console.WriteLine("Сума ряду:" + sum);
            Console.ReadKey();
        }
    }
}
