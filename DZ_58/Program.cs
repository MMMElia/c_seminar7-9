// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n=int.Parse(Console.ReadLine());


// задавала массивы как в примере для проверки правильности расчетов
//int[,] arr1=new int[,] {{2,4},{3,2}};
//int[,] arr2=new int[,] {{3,4},{3,3}};



// рандомное заполнение массива
int[,] arr1=inputarray(m,n);
int[,] arr2=inputarray(m,n);

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
print(arr1); 
Console.WriteLine();
print(arr2); 

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


// метод для умножения матриц
int[,] arr3=sumarray(arr1,arr2);

 int[,] sumarray(int[,] arrayA, int[,] arrayB)
    {       
        int[,] arrayC = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
        for (var i = 0; i < arrayA.GetLength(0); i++)
        {
            for (var j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayC[i, j] = 0;
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                }
            }
        }
        return arrayC;
    }


// вызов метода печати для результата
Console.WriteLine();
Console.WriteLine("Результат");
print(arr3); 