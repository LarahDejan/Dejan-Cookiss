using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookiss
{
    internal class IngreDients
    {
        public int quantity { get;}
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

