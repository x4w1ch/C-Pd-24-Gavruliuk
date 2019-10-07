using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double U, I, R;

            Console.Write("Введіть напругу:");
            U = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть силу струму:");
            I = Convert.ToDouble(Console.ReadLine());

            R = U / I;

            Console.WriteLine("Опір:" + R);

            Console.ReadKey();
        }
    }
}
