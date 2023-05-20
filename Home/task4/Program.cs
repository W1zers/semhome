// Y2.1. Известна зарплата каждого из 12 работников фирмы за каждый месяц первого квартала:
class Program
    {
        static void Main()
        {
            //Объявление и заполнение массива целыми числами в диапазоне от 0 до 1000
            int worker = 1;
            int[,] salary = new int[12, 4];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        salary[i, j] = worker;
                        worker++;
                    }
                    else
                    {
                        salary[i, j] = rnd.Next(0, 1000);
                    }
                }
            }
            //Подсчет всех зарплат за квартал
            int allSumOfQuarter = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j != 0)
                    {
                        allSumOfQuarter += salary[i,j];
                    }
                }
            }
            Console.WriteLine("Сумма всех зарплат за квартал равна: " + allSumOfQuarter + " руб.");
            //Подсчет зарплат каждого работника за квартал
            int individualSumOfQuarter = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j != 0)
                    {
                        individualSumOfQuarter += salary[i, j];
                    }
                }
                Console.WriteLine($"Зарплата работника {salary[i,0]} за квартал составила {individualSumOfQuarter} руб.");
                individualSumOfQuarter = 0;
            }
            //Подсчет зарплат всех работников за каждый месяц
            int allSumPerMonth = 0;
            for (int j = 1; j < 4; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    allSumPerMonth += salary[i, j];
                }
                Console.WriteLine($"Зарплата всех работников за {j} месяц составила {allSumPerMonth} руб.");
                allSumPerMonth = 0;
            }
        }
    }