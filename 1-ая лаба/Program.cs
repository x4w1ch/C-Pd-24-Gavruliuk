
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _1_ая_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double I, U, R, x, y, buf, buf1, min=0, max=0;
            int N, m, n, u;

            /*  Перше завдання
             
                        Console.Write("Введіть напругу:");
                        U = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть силу струму:");
                        I = Convert.ToDouble(Console.ReadLine());

                        R = U / I;

                        Console.WriteLine("Опір:" + R);

            */

/*  Третє завдання
 *  
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

*/

/* Четверте завдання
 * 
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
            }

*/
/* П'яте завдання

        Console.WriteLine("m:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("n:");
        n = Convert.ToInt32(Console.ReadLine());

        double[,] C = new double[m, n];
        double[,] B = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for(u = 0; u < n; u++)
            { 
                Console.WriteLine("Введіть елемент масиву:");
                B[i,u] = Convert.ToDouble(Console.ReadLine());
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
////////
*/





Console.ReadKey();
}
}
}
