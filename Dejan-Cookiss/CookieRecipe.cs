using System;
using System.Collections.Generic;

namespace Cookiss
{
    public class CookieRecipe
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public void DisplayIngredients()
        {
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine();
        }
    }
}
