//1. Ask for positive number
Console.Write("Enter a positive number: ");
int number = int.Parse(Console.ReadLine());
do
{
    if (number <= 0)
    {
        Console.WriteLine("Invalid input. Please enter a positive number.");
        Console.Write("Enter a positive number: ");
        number = int.Parse(Console.ReadLine());
    }
} while (number <= 0);

//2. Password validation
string password = "secret";
string userInput;
do
{
    Console.Write("Enter the password: ");
    userInput = Console.ReadLine();
    if (userInput != password)
    {
        Console.WriteLine("Incorrect password. Please try again.");
    }
} while (userInput != password);

//3. Sum of numbers from 1 to n
Console.Write("Enter a positive number to calculate the sum from 1 to n: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
do
{
    sum += n;
    n--;
    Console.WriteLine("Current tally(" + n + "):" + sum);
} while (n > 0);
Console.WriteLine("The sum of numbers from 1 to n is: " + sum);

//4. Continue playing system
char playAgain;
do
{
    Console.WriteLine("Playing the game...");
    Console.WriteLine("Game over!");
    Console.Write("Do you want to play again? (y/n): ");
    playAgain = char.Parse(Console.ReadLine().ToLower());
} while (playAgain == 'y');

//5. Number guessing game
Random random = new Random();
int targetNumber = random.Next(1, 101);
int guess;
do
{
    Console.Write("Guess a number between 1 and 100: ");
    guess = int.Parse(Console.ReadLine());
    if (guess < targetNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > targetNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
} while (guess != targetNumber);
Console.WriteLine("Congratulations! You guessed the number.");