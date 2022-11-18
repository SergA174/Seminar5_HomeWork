// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// void FillArray(int[] collection)
// {
//     int Length = 4;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(0, 100);
//         index++;
//     }
// }
// void PrintArray(int[] array)
// {
//     int count = 4;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} "); 
//     }
// }
// FillArray(array);
// PrintArray(array);
// int p = 0;
// int z = 0;
// int count = 4;
// for (int i = 1; i < count; i=i+2)
// {
//     if (int [i] array == 0) p = p +1;
//     else if (array[i]%2 != 0) z = z +1;
// }
// Console.WriteLine();
// Console.Write($"Количество  чисел на нечетных позициях: {p}");
// Console.WriteLine();
// Console.Write($"Количество нечётных чисел в массиве: {z}");


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}