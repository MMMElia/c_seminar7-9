// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n=int.Parse(Console.ReadLine());


// рандомное заполнение массива
int[,] arr=inputarray(m,n);
int[,] inputarray(int m1, int n1)
{
    int[,] array=new int[m1,n1];
    for (int i=0; i<m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            array[i,j]=new Random().Next(0,10);
        }
    }
return array;
}

// вывод массива для наглядности
print(arr); 
void print(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write ($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// сортировка массива
int[,] arr2=sort(arr);
int[,] sort (int[,] array)
{
    int k=0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        
        for (int q=0; q<array.GetLength(1); q++)
        {
            for (int j=0; j<array.GetLength(1)-q-1; j++)
            {
            if (array[i,j]<array[i,j+1]) {k=array[i,j]; array[i,j]=array[i,j+1];array[i,j+1]=k;}
            }
        }
        
    }
Console.WriteLine();
return array;
}

// отправка массива в метод для печати
Console.WriteLine();
print(arr2); 
