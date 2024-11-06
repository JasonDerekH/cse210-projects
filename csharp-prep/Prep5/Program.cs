using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");

        string username = PromptUsername();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);


        DisplayResult(username, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");

    }

    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();

        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}