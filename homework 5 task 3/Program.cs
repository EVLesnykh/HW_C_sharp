// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Задайте размер массива: ");
int length_array = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length_array];
Console.WriteLine("Массив: ");
double min = double.MaxValue;
double max = double.MinValue;
Random_array(array);
PrintArray(array);

void Random_array(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
  }
}

string nums = "Максимальное и минимальное значение массива определены неверно";

for (int j = 0; j < array.Length; j++)
{
  if (array[j] > max)
  {
    max = array[j];
  }
  if (array[j] < min)
  {
    min = array[j];
  }
  {
    nums = "Максимальное и минимальное значение массива:";
  }
}
Console.WriteLine($"{nums} {max} и {min}");
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элеменентом массива: {max - min}");

void PrintArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}