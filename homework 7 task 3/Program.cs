// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Задайте количество строк массива [m, n]: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива [m, n]: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Двумерный массив: ");
double[,] array = new double[m, n];

RandomArray(array);
PrintArray(array);

void RandomArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(new Random().Next(1, 10));
    }
  }
}

Console.WriteLine($"Cреднее арифметическое каждого столбца:");
for (int j = 0; j < array.GetLength(1); j++)
{
  double avgElement = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    avgElement = (avgElement + array[i, j]);
  }
  avgElement = Math.Round((avgElement / array.GetLength(0)), 2);
   Console.Write(avgElement + "; " );
}

void PrintArray(double[,] array)
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
