using System;
using System.Collections.Generic;

namespace Cookiss
{
    internal class Program
    {
        public static void Mymethod()
        {
            Console.WriteLine("ENJOY YOUR COOKISS!");
        }

        public static void Main()
        {
            Console.WriteLine("Welcome to Cookiss!");
            Console.WriteLine("Are you ready to make cookies?");
            Console.WriteLine("Enter 1 to continue");
            string cookies = "1";
            string enterChoice = Console.ReadLine();

            while (enterChoice != "0")
            {
                string result = enterChoice == cookies ? "correct" : "error";

                if (result == "correct")
                {
                    var menu = new List<string>()
                    {
                        "What Cookies Do You Want?",
                        "Enter 1 for Choco Cookies",
                        "Enter 2 for Choco Oat Cookies",
                        "Enter 3 for Supreme Cookies",
                        "Enter 0 to exit"
                    };

                    foreach (string i in menu)
                    {
                        Console.WriteLine(i);
                    }

                    enterChoice = Console.ReadLine();

                    switch (enterChoice)
                    {
                        case "1":
                            Console.WriteLine("Choco Cookies");
                            Console.WriteLine();

                            var choco = new List<string>()
                            {
                                "Ingredients:",
                                "Butter",
                                "Dark or Light Brown Sugar",
                                "Large egg",
                                "Vanilla Extract",
                                "All-Purpose Flour",
                                "Salt",
                                "Baking Powder",
                                "Baking Soda",
                                "Chocolate Chip or Bar"
                            };

                            foreach (string i in choco)
                            {
                                Console.WriteLine(i);
                            }

                            Console.WriteLine();
                            Mymethod();
                            Console.WriteLine();

                            Console.WriteLine("Enter 1 to Return");
                            Console.WriteLine("Enter 0 to Exit");

                            enterChoice = Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("Choco Oat Cookies");
                            Console.WriteLine();

                            var oat = new List<string>()
                            {
                                "Ingredients:",
                                "Butter",
                                "Dark or Light Brown Sugar",
                                "Large egg",
                                "Vanilla Extract",
                                "All-Purpose Flour",
                                "Salt",
                                "Baking Powder",
                                "Baking Soda",
                                "Chocolate Chip or Bar",
                                "Whole Grain Oats"
                            };

                            foreach (string i in oat)
                            {
                                Console.WriteLine(i);
                            }

                            Console.WriteLine();
                            Mymethod();
                            Console.WriteLine();
                            Console.WriteLine("Enter 1 to return");
                            Console.WriteLine("Enter 0 to Exit");

                            enterChoice = Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("Supreme Cookies");
                            Console.WriteLine();

                            var super = new List<string>()
                            {
                                "Ingredients:",
                                "Butter",
                                "Dark or Light Brown Sugar",
                                "Large egg",
                                "Vanilla Extract",
                                "All-Purpose Flour",
                                "Salt",
                                "Baking Powder",
                                "Baking Soda",
                                "Chocolate Chip or Bar",
                                "Whole Grain Oats",
                                "Nuts",
                                "Raisins"
                            };

                            foreach (string i in super)
                            {
                                Console.WriteLine(i);
                            }

                            Console.WriteLine();
                            Mymethod();
                            Console.WriteLine();
                            Console.WriteLine("Enter 1 to return");
                            Console.WriteLine("Enter 0 to Exit");

                            enterChoice = Console.ReadLine();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect choice");
                    Console.WriteLine("Please try again or press 0 to exit");

                    Console.Write("Enter 1 to continue: ");
                    enterChoice = Console.ReadLine();
                }
            }
        }
    }
}

