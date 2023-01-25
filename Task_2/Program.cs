// Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от m до n.

Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
int m1 = m;
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
int sum = 0;

if (m == n)
{
    Console.WriteLine($"Вы ввели два одинаковых числа");
    return;
}

if (m > n)
{
    Console.WriteLine($"Первое число должно быть меньше чем второе");
    return;
}

if (m < 0)
    m = 0;
{
    void Sum2(int m, int n, int sum2)
    {
        if (m > n)
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {m1} до {n1} равно: {sum2}");
            return;
        }
        sum2 = sum2 + (m++);
        Sum2(m, n, sum2);
    }

}


void Sum(int m, int n, int sum)
{

    if (m > n)
    {

        Console.WriteLine($"Сумма натуральных элементов в промежутке от {m1} до {n1} равно: {sum}");
        return;
    }
    sum = sum + (m++);
    Sum(m, n, sum);


}

Sum(m, n, sum);
