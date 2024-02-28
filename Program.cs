/*
Author: Sravanth Reddipogu
Date: 2/28/2024
Comments: This C# Console Application code demonstrates the
    Selection Sort Algorithm. No input
    is required for the script. It will execute without 
    input against array. 
*/


using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int[] array = { 5, 72, 3, 14, 7, 1 };
        Console.WriteLine("Original Array:");
        PrintArray(array);

        SelectionSortAlgorithm(array);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                // Swap arr[i] and arr[minIndex]
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
