using DependancyInversionFactory.People.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People.Female
{
    public class SportsGirl : YoungChild, IGreetableSportsPerson
    {
        public string FavouriteSports { get; set; }

        public void SayFavouriteSports()
        {
            Console.WriteLine($"My Favourite Sport is {FavouriteSports}.");
        }
    }
}
