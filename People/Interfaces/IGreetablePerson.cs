using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People.Interfaces
{
    public interface IGreetablePerson : IPerson, IGreet
    {
    }
}
