using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;

namespace D01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a C# Sharp program to print the sum of two numbers. //string interpolation.
            int x = 10;
            int y = 20;
            int sum = x + y;
            //Write a C# Sharp program to print the result of the specified operations. Test data:
            //○ -1 + 4 * 6
            //○ (35 + 5) % 7
            //○ 14 + -4 * 6 / 11
            //○ 2 + 15 / 6 * 1 - 7 % 2
            Console.WriteLine($"The sum of two numbers is {sum}");
            Console.WriteLine("-1 + 4 * 6= {0}", -1 + 4 * 6);
            Console.WriteLine("( 35+ 5 ) % 7= {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11= {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2= {0}", 2 + 15 / 6 * 1 - 7 % 2);
            //Write a C# program to print the comparing results between three integer values. [At least 5 complex expressions]
            // Declare three integer values
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            bool isNum1Largest = (num1 > num2) && (num1 > num3);
            Console.WriteLine($"Is {num1} the largest? {isNum1Largest}");

            bool isNum2Smallest = (num2 < num1) && (num2 < num3);
            Console.WriteLine($"Is {num2} the smallest? {isNum2Smallest}");

            bool isNum3Between = (num3 > num1) && (num3 < num2);
            Console.WriteLine($"Is {num3} between {num1} and {num2}? {isNum3Between}");

            bool areAnyEqual = (num1 == num2) || (num1 == num3) || (num2 == num3);
            Console.WriteLine($"Are any of the numbers equal? {areAnyEqual}");

            bool isSumGreaterThanNum3 = (num1 + num2) > num3;
            Console.WriteLine($"Is the sum of {num1} and {num2} greater than {num3}? {isSumGreaterThanNum3}");
        }
    }
}
