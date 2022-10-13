/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string OrderOfPositiveNumbers(int n)
{
    if (n > 0) return $"{n} " + OrderOfPositiveNumbers(n - 1);
    return String.Empty;
}

string OrderOfNegativeNumbers(int n)
{
    if (n < 1) return $"{n} " + OrderOfNegativeNumbers(n + 1);
    return String.Empty;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Console.WriteLine($"N = {n} - > {OrderOfPositiveNumbers(n)}");
}
else if (n < 0)
{
    Console.WriteLine($"N = {n} - > {OrderOfNegativeNumbers(n)}");
}
else
    Console.WriteLine($"N = {n} - > 0 1");

