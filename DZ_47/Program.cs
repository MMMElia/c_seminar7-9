// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n=int.Parse(Console.ReadLine());

double[,] arr=inputarray(m,n);

print(arr,m,n);

double[,] inputarray(int m1, int n1)
{
    double[,] array=new double[m1,n1];
    for (int i=0; i<m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            array[i,j]=new Random().NextDouble();
        }
    }
return array;
}

void print(double[,] array, int m1, int n1)
{
    for (int i=0; i<m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            Console.Write ($"{array[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}

