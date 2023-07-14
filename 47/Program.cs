/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();
Console.Write("Введите размерность m  массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n  массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
void mas(int m , int n)
{
    int i,x;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for(x = 0;x < n;x++)
        {
            randomArray[i,x] = rand.NextDouble();
            Console.Write($"{randomArray[i,x]:F2}");
        }
    }
}
mas(m,n);


