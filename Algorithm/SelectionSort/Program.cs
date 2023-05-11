internal class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 20, 15, 1, 5, 10 };

        ShowArray(arr);

        // 선택 정렬
        // 좌측 값 부터 기준으로 잡고 나머지 요소들을 비교한 후 제일 작은 값과 교체

        // arr길이 만큼 반복
        for (int i = 0; i < arr.Length; i++)
        {
            // i번째 인덱스를 가장 작은 값의 인덱스로 설정
            int minIdx = i;

            // i+1 번째 부터 가장 작은 값 서칭
            for (int j = i + 1; j < arr.Length; j++)
            {
                // j번째 값이 minIdx값 보다 작을 경우
                if (arr[j] < arr[minIdx])
                {
                    // minIdx의 값을 j로 변경
                    minIdx = j;
                }
            }

            // i번째 요소와 minIdx요소의 위치를 스왑
            int tmp = arr[minIdx];
            arr[minIdx] = arr[i];
            arr[i] = tmp;
        }

        ShowArray(arr);
    }

    static void ShowArray(int[] array)
    {
        Console.Write($"Array : ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        Console.WriteLine();
    }
}