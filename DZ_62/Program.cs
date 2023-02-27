// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.Clear();
Console.Write("Введите размерность квадратного массива (одно число): ");
int m=int.Parse(Console.ReadLine());


int[,] arr=inputarray(m);
print(arr);


//  Функция заполнения массива по спирали начиная с 1
int[,] inputarray(int n)
{
    int[,] array= new int[n,n];
    int i = 0, j = 0;
    int s = 1;
    for (int e = 0; e < (n+1) * (n+1); e++)
    {
        
        int k = 0;
        do { array[i, j++] = s++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = s++;
        for (k = 0; k < n - 1; k++) array[i, j--] = s++;
        for (k = 0; k < n - 1; k++) array[i--, j] = s++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
        return array;
}

//  Функция вывода двумерного массива в терминал
void print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}