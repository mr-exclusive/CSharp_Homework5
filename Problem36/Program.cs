// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateIntArray(int arraySize, int minVal, int maxVal)
{
    int[] arr = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }

    return arr;
}

int SumOddElementsInArray(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }

    return sum;
}

Console.Clear();

int[] arr = CreateIntArray(4, 1, 99);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Summa of elements at odd positions is " + SumOddElementsInArray(arr));