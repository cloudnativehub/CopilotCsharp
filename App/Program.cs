using System;

namespace CopilotCsharp.App;

public class App
{
    public static void Main(string[] args)
    {        
        int[] bubble_values = { 5, 2, 8, 3, 1, 6 };

        // Print values in one lline
        Console.WriteLine("Before bubble sort: " + string.Join(" ", bubble_values));

        // Bubble sort values by using Algorithm.Sort.BubbleSort
        Algorithm.Sort.BubbleSort(bubble_values);

        // Print values in one line
        Console.WriteLine("After quick sort: " + string.Join(" ", bubble_values));

        int[] quick_values = { 5, 2, 8, 3, 1, 6, 9, 22 };
        // Print values in one lline
        Console.WriteLine("Before bubble sort: " + string.Join(" ", quick_values));

        // Bubble sort values by using Algorithm.Sort.BubbleSort
        Algorithm.Sort.QuickSort(quick_values);

        // Print values in one line
        Console.WriteLine("After quick sort: " + string.Join(" ", quick_values));

        // Merge sort values by using Algorithm.Sort.MergeSort
    }

    // Create an asp.net core web api server, expose all the sorting algorithms as api endpoints，let's think step by step
    

}
