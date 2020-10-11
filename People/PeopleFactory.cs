using DependancyInversionFactory.People.Female;
using DependancyInversionFactory.People.Interfaces;
using DependancyInversionFactory.People.Male;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People
{
    public static class PeopleFactory
    {
        public static IGreetableSportsPerson CreateSportsBoy() => new SportsBoy();
        public static IGreetableSportsPerson CreateSportGirl() => new SportsGirl();
        public static IGreetablePerson CreateBoy() => new Boy();
        public static IGreetablePerson CreateGirl() => new Girl();
        public static IPerson CreateBabyBoy() => new BabyBoy();
    }
}
