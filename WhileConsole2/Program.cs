using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Р (0 < P < 50): ");
            double p = double.Parse(Console.ReadLine());

            double a = 10;
            int k = 1;
            double s = 10;
            while (s <= 200)
            {
                a *= (p / 100 + 1); //увеличивает длину на Р процентов
                s += a; //вычисляем суммарный пробег
                k++;
            }

            Console.WriteLine("Количество дней: " + k);
            Console.WriteLine("Суммарный пробег: " + s);
        }

        }
    }
