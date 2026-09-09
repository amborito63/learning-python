// grade system I/O
using System;
namespace IfStatementProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if (a >= 80)
            {
                Console.WriteLine("Grade is B");
            }
            else if (a >= 70)
            {
                Console.WriteLine("Grade is C");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }  
}
//output is failed, score choice is disabled, 
//a is defined as 60, based on the if statements, the output is failed.