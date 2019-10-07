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

            char buf='0';
            int index=-1;
            List<char> variables = new List<char>();

            Console.WriteLine("Введіть бажані значення(через пробіл):");
            string text = Convert.ToString(Console.ReadLine());

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                buf = Convert.ToChar(s);
                variables.Add(buf);
            }

            Console.Write("Введіть елемент для пошуку:");
            char sym = Convert.ToChar(Console.ReadLine());

            foreach (char c in variables)
            {
                index = variables.IndexOf(sym, (index+1));
                if(index == -1)
                {
                    break;
                }
                else
                { 
                Console.WriteLine(index);
                }
            }

            Console.ReadKey();
        }
    }
}
