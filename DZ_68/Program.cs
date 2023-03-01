// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

//Akkmetod(m,n);

// метод вызова метода))
//void Akkmetod(int m, int n)
//{
    Console.Write(Akker(m, n)); 
//}

// метод Аккермана
int Akker(int m, int n)
{
    if (m == 0) {return n + 1;}
        else if (n == 0 && m > 0) {return Akker(m - 1, 1);}
            else {return (Akker(m - 1, Akker(m, n - 1))); }
}