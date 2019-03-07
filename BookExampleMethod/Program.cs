using System;

namespace BookExampleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let me count dude!");
            CountToTen();
            Count(3);
            DoSomething(2);
            Console.WriteLine("Here is the return from getRandomNumber()");
            Console.WriteLine(GetRandomNumber());
            Console.WriteLine(CalculatePlayerScore());
            
            Console.ReadLine();
        }

        static void CountToTen()
        {
            for (int index = 1; index <= 10; index++)
                Console.WriteLine(index);
        }

        static float GetRandomNumber()
        {
            int usersNumber = 0;
            while (usersNumber < 1 || usersNumber > 10)
            {
                Console.Write("Enter a number between 1 and 10:  ");
                string usersResponse = Console.ReadLine();
                usersNumber = Convert.ToInt32(usersResponse);
            }
            return usersNumber;
        }

        static void Count(int numberToCountTo)
        {
            for (int current = 1; current <= numberToCountTo; current++)
                Console.WriteLine(current);
        }

        static int CalculatePlayerScore()
        {
            int livesLeft = 3;
            int underlingsDestroyed = 17;
            int minionsDestroyed = 4;
            int bossesDestroyed = 1;

            if (livesLeft == 0)
                return 0;
            return underlingsDestroyed * 10 + minionsDestroyed * 100 + bossesDestroyed * 1000;
        }

        static void DoSomething(int newNum)
        {
            int aNumber = newNum;
            if (aNumber == 2)
                return;
            Console.WriteLine("This only gets printed if the 'return' statement wasn't" +
                " executed");
        }

    }
}
