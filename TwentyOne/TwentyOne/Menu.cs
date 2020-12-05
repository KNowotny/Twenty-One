using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome in Twenty-One simulator.");
            Console.WriteLine("This appliaction will allow you to calculate your chances of getting 21.");
            Console.WriteLine("Legend:");
            Console.WriteLine("For the card value type: Ace, 2, 3, ..., 10, Jack, Queen, King");
            Console.WriteLine("For Clubs type: C number");
            Console.WriteLine("For Diamonds type: D number");
            Console.WriteLine("For Hearts type: H number");
            Console.WriteLine("For Spades type: S number");
        }
    }
}
