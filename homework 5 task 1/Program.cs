// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте размер массива: ");
int length_array = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length_array];
int count = 0;
Console.Write("Массив: ");
Random_array(array);
PrintArray(array);

void Random_array(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}

string nums = "Чётных цифр в массиве НЕТ";

for (int j = 0; j < array.Length; j++)
{
  if (array[j] % 2 == 0)
    count++;
  {
    nums = "Количество чётных чисел в заданном массиве:";
  }
}
Console.Write($"{nums} {count}");

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}