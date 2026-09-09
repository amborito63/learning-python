// pos-neg integer def
using System;
namespace IfStatementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My first activity");
            Console.WriteLine("Enter whole number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }
}
// OUTPUT IS POSITIVE IF INPUT IS POSITIVE
// OUTPUT IS NEGATIVE IF INPUT IS NEGATIVE
// OUTPUT IS ZERO IF INPUT IS ZERO