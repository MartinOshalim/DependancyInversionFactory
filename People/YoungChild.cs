using DependancyInversionFactory.People.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People
{
    public class YoungChild : IGreetablePerson
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hello! my name is {Name} and I'm {Age} years old.");
        }
    }
}
