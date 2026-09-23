string userChoice;
do
{
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Show Current Date and Time");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice (1-3): ");
        userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                Console.WriteLine("Hello, User!");
                break;
            case "2"  :
                Console.WriteLine($"Current Date and Time: {DateTime.Now}");
                break;
            case "3":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                break;
        }
        if (userChoice != "3")
        {
            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
        }}
while (userChoice != "3");