using System;
using System.ComponentModel.Design;

namespace Cookiss
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to Cookiss!");
            Console.WriteLine("What cookies you want to cook?");
            Console.WriteLine("Enter 1 for Choco Cookies");
            Console.WriteLine("Enter 2 for Choco Oat Cookies");
            Console.WriteLine("Enter 3 for Supreme Cookies");
            Console.WriteLine("Enter here:");
            int enterChoice = Convert.ToInt32(Console.ReadLine());

            if (enterChoice > 4)
            {
                Console.WriteLine("Your choice is incorrect");
                Console.WriteLine("Enter 1 for Choco Cookies");
                Console.WriteLine("Enter 2 for Choco Oat Cookies");
                Console.WriteLine("Enter 3 for Supreme Cookies");
                Console.WriteLine("Please enter again");
                enterChoice = Convert.ToInt32(Console.ReadLine());
            }
            else if (enterChoice == 1)
            {

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
                Console.WriteLine("    ");
                Console.WriteLine("Enter 4 to change the number of cookies");
                Console.WriteLine("Enter 2 to Choco Oat Cookies");
                Console.WriteLine("Enter 3 for Supreme Cookies");
                enterChoice =  Convert.ToInt32(Console.ReadLine());
            }

            else if (enterChoice == 2)
            {
                Console.WriteLine("Choco Oat Cookies");
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
                Console.WriteLine("Whole Grain Oats = " + oat + "grams");
                Console.WriteLine("Salt = " + salt + " grams");
                Console.WriteLine("Baking Powder = " + powder + "grams");
                Console.WriteLine("Baking Soda = " + soda + " grams");
                Console.WriteLine("Chocolate Chip or Bar = " + chocolate + "grams");
                Console.WriteLine("    ");
                Console.WriteLine("    ");
                Console.WriteLine("Enter 4 to change the number of cookies");
                Console.WriteLine("Enter 2 to Choco Oat Cookies");
                Console.WriteLine("Enter 3 for Supreme Cookies");
                enterChoice =  Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Supreme Cookies");
            }


        }
    }
}

