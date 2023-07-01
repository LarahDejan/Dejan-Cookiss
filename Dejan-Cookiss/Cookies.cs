using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookiss
{
    internal class Cookies

    {
        public string flavor;

        public void ChocoCookies()
        {
            Console.WriteLine("Choco Cookies");
        }

        public void ChocoOatCookies()
        {
            Console.WriteLine("Choco Oat Cookies");
        }

        public void SupremeCookies()
        {
            Console.WriteLine("Supreme Cookies");

        }
    }

    internal class Ingredients
    {
        public int quantity;
        public string ingredients;
        public int measurement;

        public void HowMany()
        {
            Console.WriteLine("How many cookie you want to make");
            int quantity = Convert.ToInt32(Console.ReadLine());

        }

        public void ListIngre()
        {
            Console.WriteLine("Ingredients");

        }
    }
}
