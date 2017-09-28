using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber}");
                        return;
                    }
                }
            }

            Console.WriteLine("{0} combinations - neither equals {1} ", counter, magicalNumber);
        }
    }
}
