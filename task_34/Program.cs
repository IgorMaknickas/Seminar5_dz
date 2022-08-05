// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] array = GetArray(10, 100, 999);

foreach (int i in array)
{
    Console.Write($" {i} ");
}

Console.WriteLine();

int Count(int[] new_arr)
{
    int a = 0;

    for (int i = 0; i < new_arr.Length; i++)
    {
        if (new_arr[i] % 2 == 0) a = a + 1;
    }
    
    return a;
}

Console.WriteLine($"количество чётных чисел в массиве {Count(array)}");