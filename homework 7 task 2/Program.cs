// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Задайте количество строк массива [m, n]: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива [m, n]: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Двумерный массив: ");
int[,] array = new int[m, n];

RandomArray(array);
PrintArray(array);
FindElement(array, rowIndex, columnIndex);


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

void FindElement(int[,] array, int rowIndex, int columnIndex)
{
  if (rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1))
    Console.WriteLine($"Искомый элемент массива: {array[rowIndex, columnIndex]}");
  else
    Console.WriteLine($"Элемента с индексами ({rowIndex}, {columnIndex}) в массиве нет");
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
