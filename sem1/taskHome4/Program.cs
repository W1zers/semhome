// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


    int i = 1;
    int number;
            bool not = true; // bool Тип bool представляет два логических значения: "истина" и "ложь". Эти логические значения обозначаются в C# зарезервированными словами true и false соответственно.

            Console.WriteLine("Введите число:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + number);
            while (i <= number)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++; //i++ постфиксная операция
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }