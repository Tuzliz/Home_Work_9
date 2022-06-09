/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


// a
int start = GetDemension("Введите число от которого считать:");
int end = GetDemension("Введите число до которого считать:");

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Recursion(int start, int end)
{
    if (end == start)
        return start;

    Console.WriteLine($"start {start} ------ end {end}");
    return start + Recursion(start + 1, end);// 4+5(recurcion(4+1'8))+ 6(recurcion(5+1,8))+7(recurcion(6+1,8))

}
var result = Recursion(start, end);
Console.WriteLine(result);
