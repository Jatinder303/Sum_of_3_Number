using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_3_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1 – Enter the first number, save as num1.
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());

            // Step 2 - Enter the second number, save as num2.
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            // Step 3 - Enter the third number, save as num3.
            Console.WriteLine("Enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            // Step 4 – Add num1, num2 and num3, save as Sum.
            int Sum = num1 + num2 + num3;

            // Step 5 – Display the Sum.
            Console.WriteLine("Addition of 3 numbers are " + Sum);
            Console.ReadKey();
        }
    }
}
