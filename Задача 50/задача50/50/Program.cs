/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.Clear();
Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[6 , 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (m < numbers.GetLength(0) && n < numbers.GetLength(1)) Console.WriteLine(numbers[m, n]);
else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            array[i, x] = new Random().Next(1, 10);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int x = 0; x < array.GetLength(1); x++)
        {
            Console.Write(array[i, x] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
} 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}