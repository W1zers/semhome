// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
// из этих чисел:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1-ое число: ");

int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-ое число: ");

int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 3-е число: ");

int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
    Console.WriteLine($"max = {n1}");
}
else if (n2 > n1 & n2 > n3)
{
    Console.WriteLine($"max = {n2}");
}

else if (n3 > n1 & n3 > n2)
{
    Console.WriteLine($"max = {n3}");
}
else
{
Console.WriteLine("Числа равны");
}