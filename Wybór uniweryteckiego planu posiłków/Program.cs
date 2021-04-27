using System;

namespace Wybór_uniweryteckiego_planu_posiłków
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int semestr;
            do
            {
                userInput = Menu();

                switch (userInput)
                {
                    case 1:
                        Plan1();
                        break;
                    case 2:
                        Plan2();
                        break;
                    case 3:
                        Plan3();
                        break;
                }

            } while (userInput != 4);

        }
        public static int Menu()
        {
            int selection;
            Console.WriteLine("Wybierz plan posiłków");
            Console.WriteLine("Plan 1: 7 posiłków w tygodniu za 560 zł na semestr.");
            Console.WriteLine("Plan 2: 14 posiłków w tyogdniu za 1095 zł na semestr.");
            Console.WriteLine("Plan 3. Nieograniczona liczba posiłków za 1500 zł za semestr.");
            Console.WriteLine("Wpisz 4 by zakończyć program");
            Console.WriteLine();         
            selection = int.Parse(Console.ReadLine());        
            return selection;


        }
        public static int Plan1()
        {
            int semestr;
            Console.WriteLine("Wprowadz liczbę semestrów:");
            semestr = int.Parse(Console.ReadLine());
            int sum = semestr * 560;
            Console.WriteLine($"Koszt posiłków za {semestr} semestry będzie wynosił {sum.ToString("c")}");
            Console.WriteLine();
            return semestr;
        }
        public static int Plan2()
        {
            int semestr;
            Console.WriteLine("Wprowadz liczbę semestrów:");
            semestr = int.Parse(Console.ReadLine());
            int sum = semestr * 560;
            Console.WriteLine($"Koszt posiłków za {semestr} semestry będzie wynosił {sum.ToString("c")}");
            Console.WriteLine();
            return semestr;
        }
        public static int Plan3()
        {

            int semestr;
            Console.WriteLine("Wprowadz liczbę semestrów:");
            semestr = int.Parse(Console.ReadLine());
            int sum = semestr * 1560;
            Console.WriteLine($"Koszt posiłków za {semestr} semestry będzie wynosił {sum.ToString("c")}");
            Console.WriteLine();
            return semestr;
        }
    }
}
