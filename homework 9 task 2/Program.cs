// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N  = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write("Сумма натуральных элементов от M до N: ");
int SumNumsInLimit(int M, int N)
{
  if (M == 0)
  {
    return sum = (N * (N + 1)) / 2;
  }
  else if (N == 0)
  {
    return sum = (M * (M + 1)) / 2;
  }
  else if (M == N)
  {
    return sum = M;
  }
  else if (M < N)
  {
    return sum = N + SumNumsInLimit(M, N - 1);
  }
  else
  {
    return sum = N + SumNumsInLimit(M, N + 1);
  }
}
Console.WriteLine(SumNumsInLimit(M, N));