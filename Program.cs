using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10_Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите римскую цифру в эквиваленте от 1 до 3999,\nиспользуя символы 'I','V','X','L','C','D','M':");
            Console.WriteLine();
            while (true)
            {
                string rim = Console.ReadLine();
                int summa = 0;

                for (int i = 0; i < rim.Length; i++)
                {
                    if (i < rim.Length - 1 && rim[i] == 'I' && rim[i + 1] != 'I') continue;
                    else if (rim[i] == 'I')
                        summa += 1;
                    else if (rim[i] == 'V')
                    {
                        if (i > 0 && rim[i - 1] == 'I') summa += 4;
                        else summa += 5;
                    }

                    else if (rim[i] == 'X')
                    {
                        if (i > 0 && rim[i - 1] == 'I') summa += 9;
                        else if (i < rim.Length - 1 && (rim[i + 1] == 'L' || rim[i + 1] == 'C')) continue;
                        else summa += 10;
                    }

                    else if (rim[i] == 'L')
                    {
                        if (i > 0 && rim[i - 1] == 'X') summa += 40;
                        else summa += 50;
                    }

                    else if (rim[i] == 'C')
                    {
                        if (i > 0 && rim[i - 1] == 'X') summa += 90;
                        else if (i < rim.Length - 1 && (rim[i + 1] == 'D' || rim[i + 1] == 'M')) continue;
                        else summa += 100;
                    }
                    else if (rim[i] == 'D')
                    {
                        if (i > 0 && rim[i - 1] == 'C') summa += 400;
                        else summa += 500;
                    }

                    else if (rim[i] == 'M')
                    {
                        if (i > 0 && rim[i - 1] == 'C') summa += 900;
                        else summa += 1000;
                    }

                }
                Console.WriteLine(summa);
                Console.WriteLine("*****");
            }
        }
    }
}
