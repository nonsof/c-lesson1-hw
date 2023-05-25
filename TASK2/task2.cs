// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("write a number one");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("write a number two");
int number2 = Convert.ToInt32(Console.ReadLine());
int min = number;
int max = number2;
if (min<max)
{
    min = number;
    Console.WriteLine ($"min: {number} max: {number2}");
}
if (min>max)
{
    min = number2;
    Console.WriteLine ($"min: {number2} max: {number}");
}
