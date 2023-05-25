// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine ("write a number one");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("write a number two");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("write a number three");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number>max) max = number;
if (number1>max) max = number1;
if (number2>max) max = number2;

Console.Write("max = ");
Console.WriteLine(max);
