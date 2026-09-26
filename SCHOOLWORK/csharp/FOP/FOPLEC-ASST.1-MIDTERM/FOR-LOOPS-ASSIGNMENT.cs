//1. Counter from 1 to 10

Console.WriteLine("Counting from 1 to 10:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

//2. Even number counter
Console.WriteLine("Counting even numbers from 1 to 20:");
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }

//3. Multiplication table generator
Console.WriteLine("Enter a number to generate its multiplication table:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Multiplication table for " + number + ":");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(number + " x " + i + " = " + (number * i));
    }

//4. Countdown from 10 to 1
Console.WriteLine("Counting down from 10 to 1:");
    for (int i = 10; i >= 1; i--)
    {
        Console.WriteLine(i);
    }

//5. Sum of numbers from 1 to 100
Console.WriteLine("Calculating the sum of numbers from 1 to 100:");
    int sum = 0;
    for (int i = 1; i <= 100; i++)
    {
        sum += i;
    }
    Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);