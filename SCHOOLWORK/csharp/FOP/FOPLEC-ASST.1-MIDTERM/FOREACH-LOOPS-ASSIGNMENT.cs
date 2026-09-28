//1. Main subject display
Console.WriteLine("CODE BLOCK 1.");
Console.WriteLine("Printing subjects needed to be studied:");
string[] subjects = { "Fundamentals of Programming", "Data Structures", "Algorithms", "Database Systems", "Operating Systems" };
Console.WriteLine("Displaying subjects:");
foreach (string subject in subjects)
{
    Console.WriteLine("Main Subjects: " + subject);
}
Console.ReadKey();

//2. Student names display
Console.WriteLine();
Console.WriteLine("CODE BLOCK 2.");
Console.WriteLine("MASTERLIST OF STUDENTS");
string[] students = { "Alice", "Bob", "Charlie", "David", "Eve" };
foreach (string student in students)
{
    Console.WriteLine("Goodmorning! " + student);
}
Console.ReadKey();

//3. Print only even numbers in an array
Console.WriteLine();
Console.WriteLine("CODE BLOCK 3.");
Console.WriteLine("Printing even numbers from an array:");
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Even number: " + number);
    }
}
Console.ReadKey();

//4. Read and display fruits from an array
Console.WriteLine();
Console.WriteLine("CODE BLOCK 4.");
Console.WriteLine("Displaying fruits from an array:");
string[] fruits = { "Apple", "Banana", "Cherry", "Banana"};
foreach (string fruit in fruits)
{
    Console.WriteLine("Fruit: " + fruit);
}
Console.ReadKey();

//5. Calculate the total average of grades in an array
Console.WriteLine();
Console.WriteLine("CODE BLOCK 5.");
Console.WriteLine("Calculating the average of grades:");
double[] grades = { 85.5, 90.0, 78.5, 92.0, 88.5 };
double total = 0;
foreach (double grade in grades)
{
    total += grade;
}
double average = total / grades.Length;
Console.WriteLine("Average grade: " + average);
Console.ReadKey();