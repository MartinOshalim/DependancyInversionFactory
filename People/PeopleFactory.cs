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
        public static ISpeakableSportsPerson CreateBoy() => new Boy();
        public static ISpeakableSportsPerson CreateGirl() => new Girl();
        public static ISpeakablePerson CreateBabyBoy() => new BabyBoy();
    }
}
