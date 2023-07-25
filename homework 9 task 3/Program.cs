// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Функция Аккермана для введенных чисел: ");
int FunctionAckermana(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if ((n == 0) && (m != 0))
  {
    return FunctionAckermana(m - 1, 1);
  }
  else
  {
    return (FunctionAckermana(m - 1, FunctionAckermana(m, n - 1)));
  }
}
Console.WriteLine(FunctionAckermana(m, n));