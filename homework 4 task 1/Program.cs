// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Degree(int numA, int numB)
{
    int deg = 1;
    for (int i = 1; i <= numB; i = i + 1)
    {
        deg = deg * numA;
    }
    Console.WriteLine($"Число A ({numA}) в натуральной степени числа B ({numB}) равно: {deg}");
}
Console.Write("Введите число A: ");
int numA= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Degree(numA, numB);