using System;

public static class Program
{
    public static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    public static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    public static int PromptFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    public static int SquareNumber(int number)
    {
        return number * number;
    }

    public static void DisplayResult(string name, int number, int squaredNumber)
    {
        Console.WriteLine($"Thank you {name}, the square of your favorite number ({number}) is {squaredNumber}.");
    }

    public static void Main()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptFavoriteNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, number, squaredNumber);
    }
}
