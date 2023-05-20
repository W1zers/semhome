Последнее задание еще не доделал

using System;
//Y3. Вложенные циклы и целые числа
namespace Y3
{
    class Program
    {
        static int Input(string Name, int Min = int.MinValue, int Max = int.MaxValue)
        {
            int Num;
            Console.WriteLine($"Введите {Name}: ");
            while (!(int.TryParse(Console.ReadLine(), out Num) && Num >= Min && Num <= Max))
                Console.WriteLine($"Введено неверное значение, введите {Name}: ") ;
            return Num;
        }
        static bool TrySimple (int Num)
        {
            bool BSilmpe = true;
            for (int a = 2; a <= Math.Sqrt(Num); a++)
            {
                if (Num % a == 0) BSilmpe = false;
            }
            return BSilmpe;
        }
        static void Main()
        {
            Random Rand = new Random();
            //Y3.1
            Console.WriteLine("Y3.1. Найти количество делителей каждого из целых чисел от 120 до 140.");
            for (int a = 120; a <= 140; a++)
            {
                Console.Write($"Число {a}, делители: ");
                int N1denomCount = 0;
                for (int b = 2; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        bool B1simpleNum = true;
                        for (int c=2;c <= Math.Sqrt(b); c++)
                        {
                            if (b % c == 0) B1simpleNum = false;
                        }
                        if (B1simpleNum)
                        {
                            N1denomCount++;
                            Console.Write(b + " ");
                        }
                    }
                }
                Console.WriteLine(N1denomCount > 0 ? $"\tвсего делителей - {N1denomCount}" : $"нет, это простое число") ;
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.2
            Console.WriteLine("Y3.2. Составить программу для графического изображения делимости чисел от 1 до n (значение n вводится с клавиатуры). В каждой строке надо напечатать очередное число и столько символов «+», сколько делителей у этого числа.");
            int N2n = Input("число n");
            for (int a = 1; a <= N2n; a++)
            {
                Console.Write("\n"+a);
                for (int b = 1; b <= a; b++)
                {
                    if (a % b == 0)
                    {
                        bool B2simple = true;
                        for (int c = 2; c < Math.Sqrt(b); c++)
                        {
                            if (b % c == 0) B2simple = false;
                        }
                        if (B2simple) Console.Write("+");
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.3
            Console.WriteLine("Y3.3. Найти все целые числа из промежутка от 1 до 300, у которых ровно пять делителей.");
            for (int a = 1; a <= 300; a++)
            {
                int N3denomCount = 0;
                for (int b = 2; b <= a/2; b++)
                {
                    if (a % b == 0)
                    {
                        bool B3simple = true;
                        for (int c = 2; c <= Math.Sqrt(b); c++)
                        {
                            if (b % c == 0) B3simple = false;
                        }
                        if (B3simple) N3denomCount++;
                    }
                }
                if (N3denomCount == 4) Console.Write(a + " ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.4
            Console.WriteLine("Y3.4. Найти все целые числа из промежутка от 200 до 500, у которых ровно шесть делителей.");
            for (int a = 200; a <= 500; a++)
            {
                int DenominatorCount = 0;
                for (int b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        if (TrySimple(b))
                            DenominatorCount++;
                }
                if (DenominatorCount == 4 ) Console.Write(a + " ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.5
            Console.WriteLine("Y3.5. Найти все целые числа из промежутка от a до b, у которых количество делителей равно k.");
            int N5A = Input("число A");
            int N5B = Input("число B");
            int N5K = Input("число K");
            for (int a = N5A; a <= N5B; a++)
            {
                int DenominatorCount = 0;
                for (int b = 2; b <= a / 2; b++)
                {
                    if (a % b == 0)
                        if (TrySimple(b))
                            DenominatorCount++;
                }
                if (DenominatorCount == N5K)
                    Console.Write(a + " ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.6
            Console.WriteLine("Y3.6. Найти натуральное число из интервала от a до b, у которого количество делителей максимально. Если таких чисел несколько, то должно быть найдено:\nа) максимальное из них;\nб) минимальное из них.");
            int N6A = Input("число А");
            int N6B = Input("число B");
            int N6MaxDenomCount = 0;
            int N6Max = 0;
            int N6Min = 0;
            for (int a = N6A; a <= N6B; a++)
            {
                int N6MaxDenomCurrent = 0;
                for (int b = 2; b <= a; b++)
                {
                    if (a % b == 0)
                        if (TrySimple(b))
                            N6MaxDenomCurrent++;
                }
                if (N6MaxDenomCount < N6MaxDenomCurrent)
                {
                    N6Min = a;
                    N6MaxDenomCount = N6MaxDenomCurrent;
                }
                if (N6MaxDenomCount <= N6MaxDenomCurrent)
                {
                    N6Max = a;
                    N6MaxDenomCount = N6MaxDenomCurrent;
                }
            }
            Console.WriteLine($"{N6MaxDenomCount}: {N6Min} {N6Max}") ;
            Console.ReadKey();
            Console.Clear();
            //Y3.7
            Console.WriteLine("Y3.7. Найти все трехзначные простые числа (простым называется натуральное число, большее 1, не имеющее других делителей, кроме единицы и самого себя).");
            for (int a = 100; a <= 999; a++)
                if (TrySimple(a))
                    Console.Write(a + " ");
            Console.ReadKey();
            Console.Clear();
            //Y3.8
            Console.WriteLine("Y3.8. Найти 100 первых простых чисел.");
            int N8countSimple = 0;
            for (int a = 2; N8countSimple <= 100; a++)
            {
                bool simple = true;
                for (int b = 2; b <= Math.Sqrt(a); b++)
                {
                    if (a % b == 0)
                        simple = false;
                }
                if (simple)
                {
                    Console.Write(a + " ");
                    N8countSimple++;
                }
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.9
            Console.WriteLine("Y3.9. Найти сумму делителей каждого из целых чисел от 50 до 70.");
            for (int a = 50; a <= 70; a++)
            {
                int N9sum = 0;
                for (int b = 2; b < a ; b++)
                {
                    if (a % b == 0)
                    {
                        if (TrySimple(b))
                            N9sum += b;
                    }
                }
                Console.WriteLine(N9sum);
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.10
            Console.WriteLine("Y3.10. Найти все целые числа из промежутка от 100 до 300, у которых сумма делителей равна 50.");
            for (int a = 100; a <= 300; a++)
            {
                int sumDenominator = 0;
                for (int b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        if (TrySimple(b))
                            sumDenominator += b;
                }
                if (sumDenominator == 50)
                    Console.Write(a + " ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.11
            Console.WriteLine("Y3.11. Найти все целые числа из промежутка от 300 до 600, у которых сумма делителей кратна 10.");
            for (int a = 300; a <= 600; a++)
            {
                int sumDenominator = 0;
                for (int b = 2; b < a; b++)
                    if (a % b == 0)
                        if (TrySimple(b))
                            sumDenominator += b;
                if (sumDenominator > 0 && sumDenominator % 10 == 0) Console.Write(a+" ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.12
            Console.WriteLine("Y3.12. Натуральное число называется совершенным, если оно равно сумме своих делителей, включая 1 и, естественно, исключая это самое число. Например, совершенным является число 6 ( 6 1 2 3 ). Найти все совершенные числа, меньшие 100 000.");
            for (int a = 1; a <= 100000; a++)
            {
                int sumDenom = 0;
                for (int b = 1; b < a ; b++)
                    if (a % b == 0)
                        sumDenom += b;
                if (a == sumDenom) Console.Write(a+" ");
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.13
            Console.WriteLine("Y3.13. Найти натуральное число из интервала от a до b с максимальной суммой делителей.");
            int N13A = Input("число A");
            int N13B = Input("число B");
            int N13sumMax=0;
            int N13max = 0;
            for (int a = N13A; a <= N13B; a++)
            {
                int sumDenom = 0;
                for (int b = 2; b < a; b++)
                    if (a % b == 0)
                        if (TrySimple(b))
                            sumDenom += b;
                if (N13sumMax < sumDenom)
                {
                    N13sumMax = sumDenom;
                    N13max = a;
                }
            }
            Console.WriteLine($"{N13max}:{N13sumMax}");
            Console.ReadKey();
            Console.Clear();
            //Y3.14
            Console.WriteLine("Y3.14. Два натуральных числа называются дружественными, если каждое из них равно сумме всех делителей другого (само другое число в качестве делителя не рассматривается). Найти все пары натуральных дружественных чисел, меньших 50 000.");
            for (int a = 1; a<=5000; a++)
            {
                int sumDenomA = 0;
                for (int aDenom = 1; aDenom < a; aDenom++)
                    if (a % aDenom == 0)
                        sumDenomA += aDenom;
                for (int b = 1; b <= a; b++)
                {
                    int sumDenomB = 0;
                    for (int bDenom = 1; bDenom < b; bDenom++)
                        if (b % bDenom == 0)
                            sumDenomB += bDenom;
                    if (a != b && a == sumDenomB && b == sumDenomA)
                        Console.WriteLine($"{a}:{b}");
                }
            }
            Console.ReadKey();
            Console.Clear();
            //Y3.15
            Console.WriteLine("Y3.15. Найти размеры всех прямоугольников, площадь которых равна заданному натуральному числу s и стороны которых выражены натуральными числами. При этом решения, которые получаются перестановкой размеров сторон:\nа) считать разными;\nб) считать совпадающими.");
            int N15area = Input("Площадь прямоугольника");
            for (int a = 1; a <= N15area; a++)
                for (int b = 1; b <= N15area; b++)
                    if (a * b == N15area)
                        Console.WriteLine($"{a}:{b}");
            Console.ReadKey();
            Console.Clear();
            for (int a = 1; a <= Math.Sqrt(N15area); a++)
                for (int b = 1; b <= N15area; b++)
                    if (a * b == N15area)
                        Console.WriteLine($"{a}:{b}");
            Console.ReadKey();
            Console.Clear();
            //Y3.16
            Console.WriteLine("Y3.16. Найти размеры всех прямоугольных параллелепипедов, объем которых равен заданному натуральному числу v и стороны которых выражены натуральными числами. При этом решения, которые получаются перестановкой размеров ребер параллелепипеда:\nа) считать разными;\nб) считать совпадающими.");
            int N16volume = Input("объем паралеллепипеда");
            for (int a = 1; a < N16volume; a++)
                for (int b = 1; b < N16volume; b++)
                    for (int c = 1; c < N16volume; c++)
                        if (a * b * c == N16volume)
                            Console.WriteLine($"{a}:{b}:{c}");
            Console.ReadKey();
            Console.Clear();
            for (int a = 1; a <= N16volume; a++)
                for (int b = a; b <= N16volume; b++)
                    for (int c = b; c < N16volume; c++)
                        if (a * b * c == N16volume)
                            Console.WriteLine($"{a}:{b}:{c}");
            Console.ReadKey();
            Console.Clear();
            //Y3.17
            Console.WriteLine("Y3.17. Составить программу для нахождения всех натуральных решений (x и y) уравнения x2 + y2 = k2, где x, y и k лежат в интервале от 1 до 30. Решения, которые получаются перестановкой x и y, считать совпадающими.");
            for (int x = 1; x <= 30; x++)
                for (int y = x; y <= 30; y++)
                {
                    double k = (x * x) + (y * y);
                    if ((Math.Sqrt(k) * 10) % 10 == 0)
                        Console.WriteLine($"{x}^2+{y}^2={Math.Sqrt(k)}^2");
                }
            Console.ReadKey();
            Console.Clear();
            // Y3.18
            Console.WriteLine("Y3.18. Даны натуральные числа m и n. Вычислить 1n + 2n + … + mn.");
            int N18m = Input("число m");
            int N18n = Input("число n");
            int N18sum=0;
            for (int a = 1; a <= N18m; a++)
                N18sum += (int)Math.Pow(a,N18n);
            Console.WriteLine(N18sum);
            Console.ReadKey();
            Console.Clear();
            // //Y3.19
            // Console.WriteLine("Y3.19. Дано натуральное число n. Вычислить 11 + 22 + … + nn.");
            // int N19n = Input("число n");
            // long N19sum = 0;
            // for (int a = 1; a <= N19n; a++)
            //     N19sum += (long)Math.Pow(a,a);
