// Оценки каждого из 18 учеников по трем предметам представлены в виде таблицы.

int ocenka = 0;
int ocenka1 = 0;
int ocenka2 = 0;
int ocenka3 = 0;
Console.WriteLine("1) Вариант");


Console.WriteLine("Ученик   Предмет");
Console.WriteLine("         1   2   3\n");






for (int student = 1; student < 19; student++)
{
    Console.Write("Оценка ");
    ocenka = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{student}        ");
        


      


    for (int science = 1; science < 4; science++)
    {
           
            Console.Write($"{ocenka}   ");
    }
        
    {


    }


    Console.WriteLine();


}


Console.WriteLine("2) Вариант");




Console.Write("Оценка Предмет1 ");
ocenka1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка Предмет2 ");
ocenka2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Оценка Предмет3 ");
ocenka3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ученик   Предмет");
Console.WriteLine("         1   2   3\n");


for (int student = 1; student < 19; student++)
{
    //Пробел убрал чтобы ровнее было при двухзначных
    if (student >= 10)
    {
        Console.Write($"{student}       ");
        Console.Write($"{ocenka1}   {ocenka2}   {ocenka3}  ");
    }


    else
    {
        Console.Write($"{student}        ");
        Console.Write($"{ocenka1}   {ocenka2}   {ocenka3}  ");
    }
    Console.WriteLine();


}