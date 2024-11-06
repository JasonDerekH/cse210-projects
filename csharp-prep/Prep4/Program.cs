using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        //Random number to declare newNumber
        int newNumber = -5;

        do{
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());

            if(newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }while(newNumber != 0);

        numbers.Sort();

        Console.WriteLine($"The sum is: {GetSum(numbers)}");
        Console.WriteLine($"The average is: {GetAverage(numbers)}");

        Console.WriteLine($"The largest number is: {FindLargest(numbers)}");
        Console.WriteLine($"The smallest positive number is: {FindSmallestPositive(numbers)}");
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static double GetAverage(List<int> numbers)
    {
        double average = 0;
        foreach (int number in numbers)
        {
            average += number;
        }

        average /= numbers.Count();
        return average;
    }

    static int GetSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    //Create function to find largest number
    static int FindLargest(List<int> numbers)
    {
        return numbers[numbers.Count() - 1];
    }
    //Create function to find smallest number
    static int FindSmallestPositive(List<int> numbers)
    {
        //declare the variable with a random value.
        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallest)
            {
                smallest = number;
            }
        }

        return smallest;
    }
    //Create funtion to print out the list
    static void PrintNumbers(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}