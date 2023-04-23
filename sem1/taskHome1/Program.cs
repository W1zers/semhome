// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a , b;

Console.WriteLine("Введите число A: ");

    a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");

    b = int.Parse(Console.ReadLine());

if (a > b) 
{
     Console.WriteLine($"max = {a}");
}
if (a < b)
{
    Console.WriteLine($"max = {b}");
}
else Console.WriteLine("Оба числа равны");