// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Не совсем поняла условие задания (противоречие в условие и выводимых данных: задается массив длиной 5 или 3 и  
// на выводе [1, 2, 5, 7, 19] и [6, 1, 33] соответственно) и в тоже время задать массив из 8 элементов.

//Поэтому сделала два варианта решения задачи:

//вариант 1
// int[] array = new int[8];
// Console.WriteLine($"Длина массива: {array.Length}");
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = new Random().Next(0, 50);
//   Console.Write($"{array[i]} ");
// }
// Console.Write("]");

//вариант 2
Console.Write("Введите длину массива: ");
int length_array = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length_array];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 50);
  Console.Write($"{array[i]} ");
}
Console.Write("]");