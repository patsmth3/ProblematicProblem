
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        Random rng;        
        static bool cont = true;

    public static List<string> activities = new List<string>()
        {"Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"};

        static void Main(string[] args)
        {
            Console.Write(
                "Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
             bool cont = bool.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            var userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList = bool.Parse(Console.ReadLine());

            string activities = null;
            string[] enumerable = activities as string[] ?? activities.ToArray();
            if (seeList)
            {
                foreach (string activity in enumerable)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList = bool.Parse(Console.ReadLine());
                Console.WriteLine();

                while (addToList)
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    enumerable.Add(userAddition);

                    foreach (string activity)
                    {
                        object activity;
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = bool.Parse(Console.ReadLine());
                }
            }
            
            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                object rng = null;
                int randomNumber = rng.Next(enumerable.Count);

                string randomActivity = enumerable[randomNumber];

                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    ((IList) enumerable).Remove(randomActivity);

                    randomNumber = rng.Next(enumerable.Count);

                    if (activities != null) randomActivity = activities(randomNumber);
                }

                Console.Write(
                    $"Ah got it! {randomActivity}, your random activity is: {userName}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                bool cont = bool.Parse(Console.ReadLine());
            }
        }
    }
}
