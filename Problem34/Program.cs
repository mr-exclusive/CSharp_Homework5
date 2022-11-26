// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateIntArray(int arraySize, int minVal, int maxVal)
{
    int[] arr = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal);
    }

    return arr;
}

int CountEvenNumbersInArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

Console.Clear();

int[] arr = CreateIntArray(8, 100, 999);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Number of even numbers in the array is " + CountEvenNumbersInArray(arr));