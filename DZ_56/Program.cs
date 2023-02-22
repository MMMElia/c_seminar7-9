// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// создание нового одномерного массива с суммой строк двумерного массива
int[] newarr=newarray(arr); 

int[] newarray(int[,] array)
{
    int[] array2 = new int[array.GetLength(0)];
    int k=0;
    for (int i=0; i<array.GetLength(0); i++)
        {
            for (int j=0; j<array.GetLength(1); j++)
            {
                k=k+array[i,j];
            }
        Console.Write($"Строка {i} сумма равна {k} ");
        Console.WriteLine();
        array2[i]=k;
        k=0;
        }
return array2;
}


// поиск макс и вывод
otvet(newarr);
void otvet (int[] array)
{
    int max=array[0];
    int k=0;
    for (int i=1; i<array.GetLength(0); i++)
        {
            if (max<array[i]) {max=array[i]; k=i;}
        }
    Console.WriteLine();
    Console.Write($"Сумма элементов строки {k} равна {max} и является максимальной");
}