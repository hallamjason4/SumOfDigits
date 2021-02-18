using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to sum: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
