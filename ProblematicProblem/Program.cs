
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        Random rng = new Random();       
        static bool cont = true;
        static List<string> activities = new List<string>()
        {"Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"};

        static void Main(string[] args)
        {
            Console.Write(
                "Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
             bool cont;

             if (Console.ReadLine().ToLower() == "yes")
             {
                 cont = true;
             }
             else
             {
                 cont = false;
             }

            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            var userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList;
            
            if (Console.ReadLine().ToLower() == "sure")
            {
                seeList = true;
            }
            else
            {
                seeList = false;
            }  

            string activities = null;
            string[] enumerable = activities as string[] ?? activities.ToArray();
            
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;
                
                if (Console.ReadLine().ToLower() == "true")
                {
                    addToList = true;
                }
                else
                {
                    addToList = false;
                }
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
                
                var rng = new Random();
                
                int randomNumber = rng.Next(activities.Count);

                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];

                        if (activities != null) randomActivity = activities(randomNumber);
                }

                Console.Write(
                    $"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                Console.WriteLine();
                
                if (Console.ReadLine().ToLower() == "keep")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }
            }
        }
    }
}
