/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9

*/
int m = GetDemension("Введите неотрицательное число m:");
int n = GetDemension("Введите неотрицательное число n:");


int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}
int Recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Recursion(m - 1, 1);
    }
    else
    {
        return Recursion(m - 1, Recursion(m, n - 1));
    }
}
int result = Recursion(m, n);
Console.Write($"Функция Аккермана = {result}");