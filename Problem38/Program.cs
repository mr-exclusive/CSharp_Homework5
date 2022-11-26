// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateIntArray(int arraySize, int minVal, int maxVal)
{
    int[] arr = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }

    return arr;
}

int FindDifferenceBetweenMinAndMaxInArray(int[] arr)
{
    int minVal = arr[0];
    int maxVal = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minVal)
        {
            minVal = arr[i];
        }
        else if (arr[i] > maxVal)
        {
            maxVal = arr[i];
        }
    }

    return maxVal - minVal;
}

Console.Clear();

int[] arr = CreateIntArray(5, 1, 99);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Difference between max and min is " + FindDifferenceBetweenMinAndMaxInArray(arr));