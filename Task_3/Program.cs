// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.WriteLine("Введите неотрицательное число в промежутке от 0 до 4");
Console.WriteLine("");
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0 || m > 3) return;
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0 || n > 3) return;
int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

