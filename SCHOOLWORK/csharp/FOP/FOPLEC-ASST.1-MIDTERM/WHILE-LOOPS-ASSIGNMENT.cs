//1. Countdown from 50 to 1
Console.WriteLine("CODE BLOCK 1.");
Console.WriteLine("Counting down from 10 to 1:");
    int count = 10;
    while (count >= 1)
    {
        Console.WriteLine(count);
        count--;
    }

//2. Sum of numbers from 1 to 100
Console.WriteLine();
Console.WriteLine("CODE BLOCK 2.");
Console.WriteLine("Calculating the sum of numbers from 1 to 100:");
    int sum = 0;
    int i = 1;
    while (i <= 100)
    {
        sum += i;
        i++;
    }
    Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);

//3. Password attempt
Console.WriteLine();
Console.WriteLine("CODE BLOCK 3.");
Console.Write("Enter the password:");
    string password = "secret";
    string userInput;
    int attempts = 3;
    while (attempts > 0)
    {
        userInput = Console.ReadLine();
        if (userInput == password)
        {  
            Console.WriteLine("Access granted.");
            break;
        }
        else
        {
            attempts--;
            Console.WriteLine("Incorrect password. Try Again. Attempts remaining: " + attempts);           
        }
    }

//4. Savings goal
Console.WriteLine();
Console.WriteLine("CODE BLOCK 4.");
Console.Write("Enter your savings goal: ");
    double goal = Convert.ToDouble(Console.ReadLine());
    double current = 0;
    while (current < goal)
    {
        Console.Write("Enter the amount you want to save:");
        double amount = Convert.ToDouble(Console.ReadLine());
        current += amount;
        Console.WriteLine("Current savings: " + current);
    }
    Console.WriteLine("Congratulations! You have reached your savings goal.");

//5. Dice roll simulation
// Simulating rolling a die until a 6 is rolled
Console.WriteLine();
Console.WriteLine("CODE BLOCK 5.");
Console.WriteLine("Rolling a die until a 6 is rolled:");
    Random rand = new Random();
    int roll;
    do
    {
        roll = rand.Next(1, 7); // Generates a number between 1 and 6
        Console.WriteLine("Rolled: " + roll);
    } while (roll != 6);
    Console.WriteLine("You rolled a 6! Game over.");