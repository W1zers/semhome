// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// int Prompt (string message);
// {
//         System.Console.Write(message);
//         string value = Console.ReadLine() ;
//         int result = Convert.ToInt32;
//         return result; 
// }
// int number = Prompt ("Введите трехзначное число > ");
// if (number < 100 || number >= 1000 )
// {
//         Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");

//         return;
// }

// Console.WriteLine($"Введенное число `{number}`");
// int secondRank = number / 10 % 100;
// Console.WriteLine($"Вторая цифра `{secondRank}`");

int number = ReadInt("Введите трехзначное число: ");
int num = number.ToString().Length;

if (num < 3 || num > 3) 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}