// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[5];
void FillArray(int[] collection)
{
    int Length = 5;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = 5;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
}
FillArray(array);
PrintArray(array);
int p = 0;
int z = 0;
int count = 5;
for (int i = 0; i < count; i++)
{
    if (array[i]%2 == 0) p = p +1;
    else if (array[i]%2 != 0) z = z +1;
}
Console.WriteLine();
Console.Write($"Количество чётных чисел в массиве: {p}");
Console.WriteLine();
Console.Write($"Количество нечётных чисел в массиве: {z}");