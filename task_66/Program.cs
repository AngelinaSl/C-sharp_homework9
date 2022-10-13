/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumberMaxN(int m, int n)
{
    if (m == n) return m;
    return m + SumNumberMaxN(m+1, n);
}

int SumNumberMaxM(int n, int m)
{
    if (n == m) return n;
    return n + SumNumberMaxM(n+1, m);
}

Console.Write("Введите первое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение: ");
int n = Convert.ToInt32(Console.ReadLine());
if ( m < n)
{
 int x = SumNumberMaxN(m,n);
Console.WriteLine($"Сумма чисел от {m} до {n} = {x}");
}
else if(n < m)
{
    int y = SumNumberMaxM(n,m);
    Console.WriteLine($"Сумма чисел от {n} до {m} = {y}");
}
else 
{
    Console.WriteLine("Эти числа равны. Попробуйте ввести другие числа");
}