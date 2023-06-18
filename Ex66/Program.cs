// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {SumNumbersMAndN(m - 1, n)}");

// функция суммы чисел от M до N
int SumNumbersMAndN(int m, int n)
{
    int start = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        start = m + SumNumbersMAndN(m, n);
        return start;
    }
}