int[] array = {20,15,1,5, 10};

ShowArray();

// array의 길이 -1 만큼 반복
for (int i = 0; i < array.Length - 1; i++)
{
    // array길이-i-1 만큼 반복
    for (int j = 0; j < array.Length - i - 1; j++)
    {
        // j번째 값이 j+1번째 값보다 클 떄 서로 스왑 한다
        if (array[j] > array[j + 1])
        {
            (array[j], array[j + 1]) = (array[j + 1], array[j]);
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