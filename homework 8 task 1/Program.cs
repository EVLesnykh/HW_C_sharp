// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Задайте количество строк массива [m, n]: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива [m, n]: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Двумерный массив: ");
int[,] array = new int[m, n];
RandomArray(array);
PrintArray(array);

Console.WriteLine("Отсортированный двумерный массив: ");
RowSortToLower(array);
PrintSortArray(array);

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

void RowSortToLower(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int x = 0; x < array.GetLength(1) - 1; x++)   //цикл для сравнения и обмена
    {
      if (array[i, x] < array[i, x + 1])
      {
        int temp = array[i, x + 1];     //обмен элементов
        array[i, x + 1] = array[i, x];
        array[i, x] = temp;
      }
    }
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

void PrintSortArray(int[,] array)
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