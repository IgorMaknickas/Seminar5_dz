//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);

    }
    return result;
}

int[] array = GetArray(4, -5, 10);
Console.Write("[");
foreach (int i in array)
{
    Console.Write($" {i}, ");
}
Console.Write("]");

Console.WriteLine();

int Count(int[] new_arr)
{
    int sum = 0;
    for (int i = 0; i < new_arr.Length; i++)
    {
        if (i % 2 == 0);
        else
        {
            sum = sum + new_arr[i];
        }
    }

    return sum;
}

Console.WriteLine($"Сумма элементов на нечестных позициях {Count(array)}");