// Напечатать полную таблицу сложения в виде:

for(int i=1;i<10;i++)
{
    
    for(int j=1;j<10;j++)
        if ((j+i)<10)
        Console.Write($"{j}+{i}={j + i}  ");
        else Console.Write($"{j}+{i}={j + i} ");




    Console.WriteLine();
}
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++) Console.Write($"\t{a} * {b} = {a * b}");
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();