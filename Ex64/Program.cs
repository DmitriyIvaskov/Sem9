// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalNumbers(N, count);

void NaturalNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}
