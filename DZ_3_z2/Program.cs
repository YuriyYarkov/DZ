//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        int size = 10;
        int[] arr = GenerateRandomArray(size, rnd);

        PrintArray(arr);
        int evenCount = CountEvenNum(arr);
        Console.WriteLine($"Количество четных чисел в массиве {evenCount}: ");
    }

    static int[] GenerateRandomArray(int size, Random rnd)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rnd.Next(100, 999);
        }
        return arr;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int e in arr)
        {
            Console.WriteLine(e);
        }
    }

    static int CountEvenNum(int[] arr)
{
    int evenCount = 0;
    foreach (int e in arr)
    {
        if (e % 2 == 0)
        {
            evenCount++;
        }
    }
    return evenCount;
}
}

