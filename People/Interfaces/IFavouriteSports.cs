using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People.Interfaces
{
    public interface IFavouriteSports
    {
        public string FavouriteSports { get; set; }
        public void SayFavouriteSports();
    }
}
