using DependancyInversionFactory.People.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People
{
    class Baby : ISpeakablePerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Goo goo gaga!");
        }

        public void Drool()
        {
            Console.Write("Drool.....");
        }
    }
}
