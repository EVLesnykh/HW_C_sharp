// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте размер массива: ");
int length_array = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length_array];
int sum = 0;
Console.Write("Массив: ");
Random_array(array);
PrintArray(array);

void Random_array(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 100);
  }
}

string nums = "Проверьте правильность ввода условия, согласно условию задачи";

for (int j = 0; j < array.Length; j++)
{
  if (j % 2 != 0)
  {
    sum = sum + array[j];
    nums = "Сумма элементов в массиве, стоящих на нечетных позициях:";
  }
}
Console.Write($"{nums} {sum}");

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}