using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= n; i++) 
            sum += Math.Pow(i, k);

            Console.WriteLine("Сумма: " +sum);
        }
    }
}
