using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(i, n - i + 1);
            }              
            
           
            Console.WriteLine("Сумма: " +sum);

        }      
            
        }
    }

