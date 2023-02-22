// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n=int.Parse(Console.ReadLine());

// Рандомный ввод массива[,] arr=inputarray(m,n);
int[,] arr=inputarray(m,n);
int[,] inputarray(int m1, int n1)  
{
    int[,] array=new int[m1,n1];
    for (int i=0; i<m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
return array;
}

// Вывод массива для наглядности
print(arr,m,n);

void print(int[,] array, int m1, int n1)   
{
    for (int i=0; i<m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            Console.Write ($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
// вывод ответа
otvet (arr,m,n);
void otvet  (int[,] array, int m1, int n1)
{
 double s=0;
 double k=0;
 
    for (int i=0; i<n1; i++)
    {
        s=0; k=0;
        for (int j=0; j<m1; j++)
        {
            s=s+array[j,i];
        }
        Console.Write($"Среднее арифметическое столбца {i} = {(double)s/m1:f2}");
        Console.WriteLine();
    }
}