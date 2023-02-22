// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n=int.Parse(Console.ReadLine());

Console.Write($"Введите {m*n} элемента массива через пробел: ");
string s=(Console.ReadLine());


int[,] arr=newarray(s,m,n);

int[,] newarray(string s1, int m1, int n1) // Метод перевода в массив введенной с клавиатуры
{
    string[] k = s1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[,] array = new int[m1,n1];
    int z=0;
    for (int i = 0; i < m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
        array[i,j] = int.Parse(k[z+j]); 
        }
        z=z+n1;
    }
return array;
}


print(arr,m,n);

void print(int[,] array, int m1, int n1) // печать массива для проверки
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

// поиск числа
Console.Write("Введите число для поиска в массиве: ");
int x=int.Parse(Console.ReadLine());

otvet (arr,m,n,x);
Console.WriteLine();

void otvet(int [,] array, int m1, int n1, int x1) // метод поиска числа в массиве
{
    
    int x=0;
    for (int i = 0; i < m1; i++)
    {
        for (int j=0; j<n1; j++)
        {
            if (array[i,j]==x1) {
                                Console.Write($"Число находится на пересечении {i+1} строки и {j+1} столбца");
                                x=array[i,j];
                                Console.WriteLine();
                                }

        }
    }
if (x==0) Console.Write($"В массиве нет числа {x1}");
}


// поиск по координатам
Console.Write($"Введите номер строки и номер столбца через пробел для поиска элемента в массиве: ");
string y=(Console.ReadLine());

otvet2 (arr,m,n,y);

void otvet2(int [,] array, int m1, int n1, string y1)  // поиск элемента по координатам
{
    string[] k = y1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int x=int.Parse(k[0]); 
    int y=int.Parse(k[1]);
    if (x>m1 || y>n1)
     {Console.Write("В массиве нет таких координат");
     }
    else {
        Console.Write($"Число с координатами {x},{y} : {array[x-1,y-1]} "); 
         }   

}     // номер строки и столбца считаю с 1 т к видит пользователь при вводе