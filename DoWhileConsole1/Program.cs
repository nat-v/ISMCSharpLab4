using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a;                        
            do {
                Console.Write("Введите целое число: ");
                int i = int.Parse(Console.ReadLine());
                a = i;
                sum += a;
            }
            while (a != 0);

            Console.WriteLine("Сумма введенных чисел: " + sum);
        }
    }
}
