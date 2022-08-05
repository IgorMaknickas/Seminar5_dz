// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
    return result;
}

int[] array = GetArray(6, 1, 30);

int min = 30;
int max = 0;

foreach (int i in array)
{
    if (max < i) max = i;
    if (min > i) min = i;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");