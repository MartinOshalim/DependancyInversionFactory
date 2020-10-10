using DependancyInversionFactory.People.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People
{
    public class YoungChild : ISpeakableSportsPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string FavouriteSports { get; set; }

        public void SayFavouriteSports()
        {
            Console.WriteLine($"My Favourite Sport is {FavouriteSports}.");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello! my name is {Name} and I'm {Age} years old.");
        }
    }
}
