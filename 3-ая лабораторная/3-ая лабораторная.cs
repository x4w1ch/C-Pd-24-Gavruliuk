using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ая_лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            double x, y;

            Console.Write("Введіть x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть y:");
            y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.Write("1-квадранта");
            }
            if (x < 0 && y > 0)
            {
                Console.Write("2-квадранта");
            }
            if (x < 0 && y < 0)
            {
                Console.Write("3-квадранта");
            }
            if (x > 0 && y < 0)
            {
                Console.Write("4-квадранта");
            }

            Console.ReadKey();
        }
    }
}
