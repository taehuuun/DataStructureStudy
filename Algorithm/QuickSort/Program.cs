int[] array = { 20, 15, 60, 45, 10, 20, 5, 30 };

ShowArray();

QuickSort(0, array.Length-1);

ShowArray();

void ShowArray()
{
    Console.Write("Array : ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
    Console.WriteLine();
}

void QuickSort(int start, int end)
{
    if (start < end)
    {
        int pivotIdx = ArrayPartition(start, end);

        QuickSort(start, pivotIdx - 1);
        QuickSort(pivotIdx + 1, end);
        ShowArray();
    }
}

int ArrayPartition(int start, int end)
{
    int low, high, pivot;

    pivot = array[end];

    low = start;
    high = end - 1;

    while (low <= high)
    {
        while (array[low] < pivot)
        {
            low++;
        }

        while (array[high] > pivot)
        {
            high--;
        }

        if (low <= high)
        {
            (array[low], array[high]) = (array[high], array[low]);
        }
    }
    
    (array[low], array[end]) = (array[end], array[low]);

    return low;
}