// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Задайте количество строк массива [m, n]: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива [m, n]: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Двумерный массив: ");
int[,] array = new int[m, n];
int sumRow = 0;
int minSumRow = 0;
int minNumSumRow = 0;

RandomArray(array);
PrintArray(array);
Console.Write($"Сумма строк:");
NumRowMinSum(array);

void RandomArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}

void NumRowMinSum(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumRow += array[i, j];
    }
    Console.Write($"{sumRow} ");
    if (i == 0)
    {
      minNumSumRow = sumRow;
    }
    else if (sumRow < minNumSumRow)
    {
      minNumSumRow = sumRow;
      minSumRow = i;
    }
    sumRow = 0;
  }
  Console.WriteLine();
  Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow + 1} строка");
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