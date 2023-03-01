// Задача 64: Задайте значения N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());
int c = 1;
otvet(n,c);


void otvet(int n, int c)
{
    if (c > n)
    {
        return;
    }
    else
    {
        otvet(n, c + 1);
        Console.Write(c + " ");
    }
}