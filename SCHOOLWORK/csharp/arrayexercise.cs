string[,] myteam = new string[2, 3] {
    { "John", "Jane", "Bob" },
    { "Alice", "Charlie", "David" }
    };

for (int i = 0; i < myteam.GetLength(0); i++)
{
    for (int j = 0; j < myteam.GetLength(1); j++)
    {
        Console.Write(myteam[i, j] + " ");
    }
}
