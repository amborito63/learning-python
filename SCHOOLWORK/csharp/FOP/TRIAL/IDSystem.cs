using System;
namespace IfStatementProject
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        bool ID = false;
        if (age >= 18 || ID)
        // if (age >= 18 || ID) is true, then the user is granted entry.
        {
            Console.WriteLine("Entry Granted.");
        }
        else
        {
            Console.WriteLine("Entry Denied.");
        }
        }
    }
}
//Code is set when user has NO ID
//therefore, Entry is Denied, IF the user is under 18 OR if the user has no ID.
