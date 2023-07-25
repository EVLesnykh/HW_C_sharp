// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Задайте количество строк матрицы [m, n]: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов матрицы [m, n]: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Матрица 1: ");
int[,] array = new int[m, n];
RandomArray(array);
PrintArray(array);

Console.WriteLine("Матрица 2: ");
int[,] array2 = new int[m, n];
RandomArray(array2);
PrintArray(array2);

Console.WriteLine("Произведение матриц 1 и 2: ");
int[,] productArrays = new int[m, n];
FindProductArrays(array, array2);
PrintArray(productArrays);

void RandomArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

void FindProductArrays(int[,] array, int[,] array2)
{
  if (array.GetLength(1) == array2.GetLength(0))
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array2.GetLength(1); j++)
      {
        productArrays[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
          productArrays[i, j] += array[i, k] * array2[k, j];
        }
      }
    }
  }
  else
  {
    Console.WriteLine($"Операция умножения двух матриц не выполнима. Проверьте исходные данные.");
  }
}