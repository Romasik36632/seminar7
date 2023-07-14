/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
Console.Clear();
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
void mas(int m , int n)
{
int i,x;
Random rand = new Random();
for (i = 0; i < m; i++)
{
    Console.WriteLine();
for (x = 0; x < n; x++)
{
    randomArray[i,x] = rand.Next(1,9);
Console.Write($"{randomArray[i,x]} ");
}
Console.WriteLine();
}
}
void stolbec(int m , int n)
{
Console.Write("Среднее арифметическое каждого столбца: ");
int i,x;
Random rand = new Random();
for (x = 0; x < n; x++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,x];
}
Console.Write($"{sum/(i):F1};");
}
}
mas(m,n);
stolbec(m,n);