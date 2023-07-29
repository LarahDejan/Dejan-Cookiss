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
                            Console.WriteLine("Procedure:");
                            Console.WriteLine("1. In a large bowl, whisk together the sugars, ");
                            Console.WriteLine("salt, and butter until a paste forms with no lumps.");
                            Console.WriteLine("2. Whisk in the egg and vanilla, beating until light ribbons fall off the whisk ");
                            Console.WriteLine("and remain for a short while before falling back into the mixture.");
                            Console.WriteLine("3. Sift in the flour and baking soda, then fold the mixture with a spatula (Be careful not to overmix,");
                            Console.WriteLine("which would cause the gluten in the flour to toughen resulting in cakier cookies).");
                            Console.WriteLine("4. Fold in the chocolate chunks, then chill the dough for at least 30 minutes. For a more intense toffee-like flavor");
                            Console.WriteLine("and deeper color, chill the dough overnight. The longer the dough rests, the more complex its flavor will be.");
                            Console.WriteLine("5. Preheat oven to 350°F (180°C). Line a baking sheet with parchment paper.");
                            Console.WriteLine("6. Scoop the dough with an ice-cream scoop onto a parchment paper-lined baking sheet, leaving at least 4 inches (10 cm)");
                            Console.WriteLine("of space between cookies and 2 inches (5 cm) of space from the edges of the pan so that the cookies can spread evenly.");
                            Console.WriteLine("7. Bake for 12-15 minutes, or until the edges have started to barely brown.");
                            Console.WriteLine("Cool completely before serving. Enjoy!");
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
                            Console.WriteLine("Procedure:");
                            Console.WriteLine("1. In a large bowl, whisk together the sugars, ");
                            Console.WriteLine("salt, and butter until a paste forms with no lumps.");
                            Console.WriteLine("2. Whisk in the egg and vanilla, beating until light ribbons fall off the whisk ");
                            Console.WriteLine("and remain for a short while before falling back into the mixture.");
                            Console.WriteLine("3. Sift in the flour and baking soda, then fold the mixture with a spatula (Be careful not to overmix,");
                            Console.WriteLine("which would cause the gluten in the flour to toughen resulting in cakier cookies).");
                            Console.WriteLine("4. Mix the oats, fold in the chocolate chunks, then chill the dough for at least 30 minutes. For a more intense toffee-like flavor");
                            Console.WriteLine("and deeper color, chill the dough overnight. The longer the dough rests, the more complex its flavor will be.");
                            Console.WriteLine("5. Preheat oven to 350°F (180°C). Line a baking sheet with parchment paper.");
                            Console.WriteLine("6. Scoop the dough with an ice-cream scoop onto a parchment paper-lined baking sheet, leaving at least 4 inches (10 cm)");
                            Console.WriteLine("of space between cookies and 2 inches (5 cm) of space from the edges of the pan so that the cookies can spread evenly.");
                            Console.WriteLine("7. Bake for 12-15 minutes, or until the edges have started to barely brown.");
                            Console.WriteLine("Cool completely before serving. Enjoy!");
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
                            Console.WriteLine("Procedure:");
                            Console.WriteLine("1. In a large bowl, whisk together the sugars, ");
                            Console.WriteLine("salt, and butter until a paste forms with no lumps.");
                            Console.WriteLine("2. Whisk in the egg and vanilla, beating until light ribbons fall off the whisk ");
                            Console.WriteLine("and remain for a short while before falling back into the mixture.");
                            Console.WriteLine("3. Sift in the flour and baking soda, then fold the mixture with a spatula (Be careful not to overmix,");
                            Console.WriteLine("which would cause the gluten in the flour to toughen resulting in cakier cookies).");
                            Console.WriteLine("4. Mix the oats and raisins, fold in the chocolate chunks, then chill the dough for at least 30 minutes. For a more intense toffee-like flavor");
                            Console.WriteLine("and deeper color, chill the dough overnight. The longer the dough rests, the more complex its flavor will be.");
                            Console.WriteLine("5. Preheat oven to 350°F (180°C). Line a baking sheet with parchment paper.");
                            Console.WriteLine("6. Scoop the dough with an ice-cream scoop onto a parchment paper-lined baking sheet, leaving at least 4 inches (10 cm)");
                            Console.WriteLine("of space between cookies and 2 inches (5 cm) of space from the edges of the pan so that the cookies can spread evenly.");
                            Console.WriteLine("7. Bake for 12-15 minutes, or until the edges have started to barely brown.");
                            Console.WriteLine("Cool completely before serving. Enjoy!");
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

