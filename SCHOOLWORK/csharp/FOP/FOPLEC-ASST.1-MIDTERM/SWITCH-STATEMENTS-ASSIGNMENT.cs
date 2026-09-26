//1. Simple Menu
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

//2. Day of the week identifier
Console.WriteLine("Enter a number (1-7) to identify the day of the week:");
int dayNumber = Convert.ToInt32(Console.ReadLine());
switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("That is not a day of the week. Please enter a number between 1 and 7.");
        break;
}

//3. Simple Calculator
Console.WriteLine("Enter the first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Select an operation (+, -, *, /):");
    char operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+':
        Console.WriteLine("Result: " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine("Result: " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine("Result: " + (num1 * num2));
        break;
    case '/':
        if (num2 != 0)
            Console.WriteLine("Result: " + (num1 / num2));
        else
            Console.WriteLine("Error: Division by zero is not allowed.");
        break;
    default:
        Console.WriteLine("Invalid operation. Please select a valid operation (+, -, *, /).");
        break;
}

//4. Simple Grade Identifier
Console.WriteLine("Enter your grade (0-100):");
    int grade = Convert.ToInt32(Console.ReadLine());

switch (grade)
{
    case int n when (n >= 90 && n <= 100):
        Console.WriteLine("You got an A!");
        break;
    case int n when (n >= 80 && n < 90):
        Console.WriteLine("You got a B!");
        break;
    case int n when (n >= 70 && n < 80):
        Console.WriteLine("You got a C!");
        break;
    case int n when (n >= 60 && n < 70):
        Console.WriteLine("You got a D!");
        break;
    case int n when (n >= 0 && n < 60):
        Console.WriteLine("You got an F!");
        break;
    default:
        Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
        break;
}

//5. Simple Attack/Defend/Heal Game
Console.WriteLine("Enter your action (attack, defend, heal):");
    string action = Console.ReadLine().ToLower();

switch (action)
{
    case "attack":
        Console.WriteLine("You chose to attack!");
        break;
    case "defend":
        Console.WriteLine("You chose to defend!");
        break;
    case "heal":
        Console.WriteLine("You chose to heal!");
        break;
    default:
        Console.WriteLine("Invalid action. Please choose attack, defend, or heal.");
        break;
}