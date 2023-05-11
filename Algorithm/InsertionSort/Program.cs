int[] array = { 20, 15, 1, 5, 10 };

ShowArray();

// array의 길이 만큼 반복
for (int i = 1; i < array.Length; i++)
{
    // j가 0이 될때까지 반복
    for (int j = i; j > 0 ; j--)
    {
        // j번째 값이 j-1번쨰 값보다 작으면 스왑
        if (array[j] < array[j - 1])
        {
            (array[j], array[j - 1]) = (array[j - 1], array[j]);
        }
    }
}

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