using System;

public class MIDTERM1 {
    public static void Main(string[] args) {

Console.Write("Enter your Username: ");
string username = Console.ReadLine();
Console.Write("Enter your password: ");
string password = Console.ReadLine();
 // User in this case is AGENT0802, with a common prefix and a unique ID
 // Password in this case is S013V-COMP, with a unique ID and a common suffix

if (password.StartsWith("S013V"))
{  
    if (username.EndsWith("0802"))
    {
        Console.WriteLine("Access Granted! Welcome, " + username);
    }
    else
    {
        Console.WriteLine("Incorrect Password or Username, please try again.");
    }
}
else
{
    Console.WriteLine("Incorrect Password or Username, please try again.");
}
Console.ReadLine();
    }
}

