//Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Исходный массив:");
        PrintArray(arr);
        ReverseArray(arr);
        Console.WriteLine("\nМассив после переворота:");
        PrintArray(arr);
    }
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int e in arr)
        {
            Console.Write(e + " ");
        }
    }
}


