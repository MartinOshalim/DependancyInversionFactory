using DependancyInversionFactory.People;
using DependancyInversionFactory.People.Male;
using DependancyInversionFactory.People.Female;
using System;
using DependancyInversionFactory.People.Interfaces;

namespace DependancyInversionFactory
{
    /*
     *  Small demo to outline a couple of SOLID principles, Open Closed principle, Interface Segregation, Dependency Inversion.
     *  Shows the use of a factory design pattern too.
     */

    class Program
    {
        static void Main(string[] args)
        {

            /* 
                If we wanted to create a BabyGirl we can easly interchange the below code without worrying
               that it would break things since they both implement the same interface.
            */
            var babyBoy = PeopleFactory.CreateBabyBoy();
            babyBoy.Name = "Michael";
            babyBoy.Age = 1;
            babyBoy.SayHello();


            var boy = PeopleFactory.CreateBoy();
            boy.Name = "John";
            boy.Age = 9;
            boy.FavouriteSports = "Soccer";
            boy.SayHello();
            boy.SayFavouriteSports();

            var girl = PeopleFactory.CreateGirl();
            girl.Name = "Nina";
            girl.Age = 7;
            girl.FavouriteSports = "Netball";
            girl.SayHello();
            girl.SayFavouriteSports();

        }
    }
}
