// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1)
{
    
    Console.WriteLine("Ввели не натуральное число");
   return;
}
int Nat(int num)
{
    if(num == 1)
    {
        return 1;
    }
    Console.Write($"{num} ");
    return Nat(num - 1);
}
int x = Nat(num);
Console.WriteLine(x);

