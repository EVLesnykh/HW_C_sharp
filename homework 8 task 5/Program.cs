// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Задайте размер массива [n, n]: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив заполненный спирально: ");
int[,] array = new int[n, n];
int i = 0;
int j = 0;
int num = 1;
FillArraySpiral(array, n);
PrintArraySpiral(array);

void FillArraySpiral(int[,] array, int n)
{
  while (num <= n * n)
  {
    array[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)
      j = j + 1;
    else if (i < j && i + j >= n - 1)
      i = i + 1;
    else if (i >= j && i + j > n - 1)
      j = j - 1;
    else
      i = i - 1;
    num = num + 1;
  }
}

void PrintArraySpiral(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
      {
        Console.Write("0" + array[i, j]);
        Console.Write(" ");
      }
      else Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}