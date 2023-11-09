namespace CopilotCsharp.Algorithm;

public class Sort
{
    // Sorts an array of integers using quicksort algorithm
    // Let's think step by step
    public static void QuickSort(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }

    private static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(array, low, high);
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }

    // Sorts an array of integers using bubble sort algorithm
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // swap temp and array[i]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            // If no two elements were swapped by inner loop, then break
            if (!swapped)
            {
                break;
            }
        }
    }

    // Sorts an array of integers using merge sort algorithm
    public static void MergeSort(int[] array)
    {
        MergeSort(array, 0, array.Length - 1);
    }

    private static void MergeSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int mid = (low + high) / 2;
            MergeSort(array, low, mid);
            MergeSort(array, mid + 1, high);
            Merge(array, low, mid, high);
        }
    }

    private static void Merge(int[] array, int low, int mid, int high)
    {
        int[] left = new int[mid - low + 1];
        int[] right = new int[high - mid];

        Array.Copy(array, low, left, 0, mid - low + 1);
        Array.Copy(array, mid + 1, right, 0, high - mid);

        int i = 0;
        int j = 0;
        int k = low;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }

            k++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }
}
