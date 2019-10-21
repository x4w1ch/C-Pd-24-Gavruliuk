using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ая_лабораторная
{
    class Program
    {
        static void Main(string[] args)
        {
            string key; // Інформація про нажату клавішу
            bool counter_OemPeriod = false; // Змінна для перевірки нажаття плаваючої коми
            char [] letters = new char [50]; // Масив символів
            string symbols; // Буферний рядок для формування кіцевого рядка
            string text = ""; // Кінцевий рядок (операція обернення проводиться з ним
            int i = 0; // Лічильник натиснутих допустимих клавіш (використовується для звернення до елементу масиву)
            char o; // Undefined array void????

            do
            {
                key = Convert.ToString(Console.ReadKey().Key);
                // Перевірка чи нажата клавіша допустима для вводу
                if (key == "Tab" || key == "D1" || key == "D2" || key == "D3" || key == "D4" || key == "D5" || key == "D6" || key == "D7" || key == "D8" || key == "D9" || key == "D0" || (key == "OemPeriod" && counter_OemPeriod == false) || key == "S" || key == "Q" || key == "W" || key == "E" || key == "R" || key == "T" || key == "Y" || key == "U" || key == "I" || key == "O" || key == "P" || key == "A" || key == "D" || key == "F" || key == "G" || key == "H" || key == "J" || key == "K" || key == "L" || key == "Z" || key == "X" || key == "C" || key == "V" || key == "B" || key == "N" || key == "M")
                {
                    if (key == "Tab")
                    {
                        break;
                    }
                        // Внесення цифр до масиву символів
                        if (key == "D1" || key == "D2" || key == "D3" || key == "D4" || key == "D5" || key == "D6" || key == "D7" || key == "D8" || key == "D9" || key == "D0")
                        { 
                        letters[i] = Convert.ToChar(key.Remove(0,1));
                        }
                        else
                        {   
                            // Внесення точки до масиву символів
                            if(key == "OemPeriod")
                            {
                            letters[i] = '.';
                            }
                            else
                            // Внесення всіх інших символів до масиву символів
                            { letters[i] = Convert.ToChar(key);}
                        }
                    // Перевірка нажаття плаваючої коми
                    if (key == "OemPeriod")
                    {
                        counter_OemPeriod = true;
                    }
                    i++;
                }
                else
                {
                    Console.Write("\b");
                }
            }
            while (key != "Tab"); // Вихід з перевірки допустимих клавіш (при нажатті клавіші TAB)

            Console.Clear();

            o = letters[49]; // Отримую символ, який відповідає за пробіл в масиві символів

            foreach(char s in letters)
            {
                if(s!=o)
                {
                    symbols = s.ToString();
                    text = text + symbols;
                }
                else
                {
                    break;
                }
            }
                // Використовую метод Reverse() для обернення рядка
                Console.WriteLine(text.Reverse().ToArray());

            Console.WriteLine(text.Length);

                // Використовую власний метод Reverse для обернення рядка
                Console.WriteLine(Reverse(text, letters));
            
            Console.ReadKey();
        }
        static char[] Reverse(string text,char [] letters)
        {
            int y=text.Length;
            char a;
            int z;
            z = (y-1);

            for(int i=0;i<y-(y/2);i++)
            {
                a = letters[i];
                letters[i] = letters[z];
                letters[z] = a;
                    z = z - 1;               
            }
            return (letters);
        }
    }
}
