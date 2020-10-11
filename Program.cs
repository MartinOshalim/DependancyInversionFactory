using DependancyInversionFactory.People;
using DependancyInversionFactory.People.Male;
using DependancyInversionFactory.People.Female;
using System;
using DependancyInversionFactory.People.Interfaces;
using System.Collections.Generic;

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

            var boy = PeopleFactory.CreateBoy();
            boy.Name = "John";
            boy.Age = 6;

            var girl = PeopleFactory.CreateGirl();
            girl.Name = "Nina";
            girl.Age = 5;

            var sportsBoy = PeopleFactory.CreateSportsBoy();
            sportsBoy.Name = "Ben";
            sportsBoy.Age = 9;
            sportsBoy.FavouriteSports = "Soccer";

            var sportsGirl = PeopleFactory.CreateSportGirl();
            sportsGirl.Name = "Jill";
            sportsGirl.Age = 7;
            sportsGirl.FavouriteSports = "Netball";


            var personList = new List<IPerson>
            {
                babyBoy,
                boy,
                girl,
                sportsBoy,
                sportsGirl
            };

            foreach(var person in personList)
            {
                if(!(person is IGreetablePerson) && person is IPerson ungreatablePerson)
                {
                    Console.WriteLine($"{ungreatablePerson.Name} at age {ungreatablePerson.Age} cannot greet.");
                }

                if(person is IGreetablePerson greetablePerson)
                {
                    greetablePerson.Greet();
                }
                
                if (person is IGreetableSportsPerson sportsPerson)
                {
                    sportsPerson.SayFavouriteSports();
                }
            }


        }
    }
}
