// age checker
using System;
namespace IfStatementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My First Activity");
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age <= 17)
            {
                Console.WriteLine("Young");
            }
            else if (age <= 25)
            {
                Console.WriteLine("still young");
            }
            else
            {
                Console.WriteLine(" adult");
            }
        }
    }
}
//WHAT WAS DEBUGGED :
// 1. The defined variable was different for the if-else statements, it was a and b, when it should have been age.
// 2. The boolean logic in the if statements were reversed, causing the output to be incorrect.
// 3. made the formatting prettier :D