using System;

/* Switch Statement
Switch statements are used to perform different actions based on different conditions.
*/
Console.WriteLine("=====MENU=====");
Console.WriteLine("1. Say Hello");
Console.WriteLine("2. Date and Time");  
Console.WriteLine("3. Close Program");
int userChoice = Convert.ToInt32(Console.ReadLine());
switch (userChoice)
{
    case 1:
        Console.WriteLine("Hi! Have a nice day!");
        break;
    case 2:
        Console.WriteLine("The current date and time is: " + DateTime.Now);
        break;
    case 3:
        Console.WriteLine("Closing program...");
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid option.");
        break;
}
Console.ReadKey();

// For Loop
// Counting from 1 to 10
// For loops are used to repeat a block of code a specific number of times.
// This is used when the number of repetitions is known.
Console.WriteLine("Counting from 1 to 10:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();

// While Loop
// Counting down from 10 to 1
// While loops are used to repeat a block of code based off a condition.
// This is used when the number of iterations is unknown, but a condition must be met.
Console.WriteLine("Counting down from 10 to 1:");
int count = 10;
while (count >= 1)
{
    Console.WriteLine(count);
    count--;
}
Console.ReadKey();

// Do-While Loop
// Counting from 1 to 5
// Do-while loops are similar to while loops, the difference is the
// do while loops guarantee that the code will be executed once.
// This is used when the number of iterations is unknown, but a condition must be met.
Console.WriteLine("Counting from 1 to 5:");
int doCount = 1;
do
{
    Console.WriteLine(doCount);
    doCount++;
} while (doCount <= 5);
Console.ReadKey();

//Foreach Loop
// Printing subjects in an array
// For each loops utilizes an array to iterate through each element in the array

Console.WriteLine("Printing subjects needed to be studied:");
string[] subjects = { "Fundamentals of Programming", "Data Structures", "Algorithms", "Database Systems", "Operating Systems" };
Console.WriteLine("Displaying subjects:");
foreach (string subject in subjects)
{
    Console.WriteLine(subject);
}
Console.ReadKey();
