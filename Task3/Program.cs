//сортировка массива


int[] arr = { 1, 4, 6, 4, 7, 8, 3, 2, 9, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinPos])
            {
                MinPos = j;
            }
        }
        int temparray = array[i];
        array[i] = array[MinPos];
        array[MinPos] = temparray;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);