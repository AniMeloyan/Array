using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers.");
        string input = Console.ReadLine();              
        string[] parts = input.Split(' ');              
        int[] numbers = new int[parts.Length];          
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);          
        }

        while (true)
        {
            Console.WriteLine("\n Select an action:");
            Console.WriteLine("1. Print array");
            Console.WriteLine("2. Find the max element");
            Console.WriteLine("3. Calculate the average");
            Console.WriteLine("4. Reverse the array");
            Console.WriteLine("5. Delete duplicate elements");
            Console.WriteLine("6. Print even items");
            Console.WriteLine("0. Exit");

            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintArray(numbers);
                    break;
                case "2":
                    Console.WriteLine("Max " + FindMax(numbers));
                    break;
                case "3":
                    Console.WriteLine("Average՝ " + Average(numbers));
                    break;
                case "4":
                    numbers = ReverseArray(numbers);
                    Console.WriteLine("Reverse arry․");
                    PrintArray(numbers);
                    break;
                case "5":
                    numbers = RemoveDuplicates(numbers);
                    Console.WriteLine("Remove Duplicates․");
                    PrintArray(numbers);
                    break;
                case "6":
                    Console.WriteLine("Even items․");
                    PrintArray(GetEvenNumbers(numbers));
                    break;
                case "0":
                    Console.WriteLine("The program is over.");
                    return;
                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }
    }

    

    static void PrintArray(int[] arr) =>
        Console.WriteLine(string.Join(", ", arr));

    static int FindMax(int[] arr) =>
        arr.Max();

    static double Average(int[] arr) =>
        arr.Average();

    static int[] ReverseArray(int[] arr)
    {
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }

    static int[] RemoveDuplicates(int[] arr) =>
        arr.Distinct().ToArray();

    static int[] GetEvenNumbers(int[] arr)
    {
        List<int> result = new();
        foreach (int n in arr)
            if (n % 2 == 0)
                result.Add(n);
        return result.ToArray();
    }
}
