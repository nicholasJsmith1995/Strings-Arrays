using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy1122018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite food? ");
            string favoriteFood = Console.ReadLine();

            Console.WriteLine("What is your favorite color? ");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("I'm glad you enjoy {0} and you like the color {1}. I love {0}", favoriteFood, favoriteColor);
            Console.ReadLine();
        }
    }
}