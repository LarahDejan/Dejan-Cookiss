using System;
using System.ComponentModel.Design;

namespace Cookiss
{
    class Program
    {
        static void Mymethod()
        {
            Console.WriteLine("ENJOY YOUR COOKISS!");
        }
        static void Main()

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
                        { "What Cookies Do You Want?","Enter 1 for Choco Cookies","Enter 2 for Choco Oat Cookies",
                            "Enter 3 for Supreme Cookies","Enter 0 to exit"};

                        foreach (string i in menu)
                        {
                        Console.WriteLine(i);
                        }
               
                    enterChoice = Console.ReadLine();

                    switch (enterChoice)
                    {
                        case "1":
                            Console.WriteLine("Choco Cookies");
                            Console.WriteLine("  ");
                            Console.WriteLine("How many cookies you want to make?");
                            int numCookies = Convert.ToInt32(Console.ReadLine());
                            int butter = 10*numCookies;
                            int sugar = 14*numCookies;
                            int egg = 6*numCookies;
                            int vanilla = 1 * numCookies;
                            int flour = 14 * numCookies;
                            int oat = 10 * numCookies;
                            double salt = 0.25 * numCookies;
                            double powder = 0.12 * numCookies;
                            double soda = 0.12 * numCookies;
                            int chocolate = 15 * numCookies;
                            int nuts = 8 * numCookies;
                            int raisins = 8 * numCookies;

                            Console.WriteLine("Ingredients");
                            Console.WriteLine("Butter = " + butter + " grams");
                            Console.WriteLine("Dark or Light Brown Sugar = " + sugar + " grams");
                            Console.WriteLine("Large egg = " + egg + " grams");
                            Console.WriteLine("Vanilla Extract = " + vanilla + " grams");
                            Console.WriteLine("All-Purpose Flour = " + flour + " grams");
                            Console.WriteLine("Salt = " + salt + " grams");
                            Console.WriteLine("Baking Powder = " + powder + "grams");
                            Console.WriteLine("Baking Soda = " + soda + " grams");
                            Console.WriteLine("Chocolate Chip or Bar = " + chocolate + "grams");
                            Console.WriteLine("    ");
                            Mymethod();
                            Console.WriteLine("    ");

                            Console.WriteLine("Enter 1 to Return");
                            Console.WriteLine("Enter 0 to Exit");
                            
                            enterChoice = Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("Choco Oat Cookies");
                            Console.WriteLine("  ");
                            Console.WriteLine("How many cookies you want to make?");
                            numCookies = Convert.ToInt32(Console.ReadLine());
                            butter = 10*numCookies;
                            sugar = 14*numCookies;
                            egg = 6*numCookies;
                            vanilla = 1 * numCookies;
                            flour = 14 * numCookies;
                            oat = 10 * numCookies;
                            salt = 0.25 * numCookies;
                            powder = 0.12 * numCookies;
                            soda = 0.12 * numCookies;
                            chocolate = 15 * numCookies;
                            nuts = 8 * numCookies;
                            raisins = 8 * numCookies;
                            Console.WriteLine("Ingredients");
                            Console.WriteLine("Butter = " + butter + " grams");
                            Console.WriteLine("Dark or Light Brown Sugar = " + sugar + " grams");
                            Console.WriteLine("Large egg = " + egg + " grams");
                            Console.WriteLine("Vanilla Extract = " + vanilla + " grams");
                            Console.WriteLine("All-Purpose Flour = " + flour + " grams");
                            Console.WriteLine("Whole Grain Oats = " + oat + "grams");
                            Console.WriteLine("Salt = " + salt + " grams");
                            Console.WriteLine("Baking Powder = " + powder + "grams");
                            Console.WriteLine("Baking Soda = " + soda + " grams");
                            Console.WriteLine("Chocolate Chip or Bar = " + chocolate + "grams");
                            Console.WriteLine("    ");
                            Mymethod();
                            Console.WriteLine("    ");
                            Console.WriteLine("Enter 1 to return");
                            Console.WriteLine("Enter 0 to Exit");

                            enterChoice = Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("Supreme Cookies");
                            Console.WriteLine("  ");
                            Console.WriteLine("How many cookies you want to make?");
                            numCookies = Convert.ToInt32(Console.ReadLine());
                            butter = 10*numCookies;
                            sugar = 14*numCookies;
                            egg = 6*numCookies;
                            vanilla = 1 * numCookies;
                            flour = 14 * numCookies;
                            oat = 10 * numCookies;
                            salt = 0.25 * numCookies;
                            powder = 0.12 * numCookies;
                            soda = 0.12 * numCookies;
                            chocolate = 15 * numCookies;
                            nuts = 8 * numCookies;
                            raisins = 8 * numCookies;
                            Console.WriteLine("Ingredients");
                            Console.WriteLine("Butter = " + butter + " grams");
                            Console.WriteLine("Dark or Light Brown Sugar = " + sugar + " grams");
                            Console.WriteLine("Large egg = " + egg + " grams");
                            Console.WriteLine("Vanilla Extract = " + vanilla + " grams");
                            Console.WriteLine("All-Purpose Flour = " + flour + " grams");
                            Console.WriteLine("Whole Grain Oats = " + oat + "grams");
                            Console.WriteLine("Salt = " + salt + " grams");
                            Console.WriteLine("Baking Powder = " + powder + "grams");
                            Console.WriteLine("Baking Soda = " + soda + " grams");
                            Console.WriteLine("Chocolate Chip or Bar = " + chocolate + " grams");
                            Console.WriteLine("Nuts = " + nuts + " grams");
                            Console.WriteLine("Raisins = " + raisins + " grams");
                            Console.WriteLine("    ");
                            Mymethod();
                            Console.WriteLine("    ");
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

                    Console.Write("Enter 1 to continue");
                    enterChoice = Console.ReadLine();
                }

            }
        }
    }
}
    


