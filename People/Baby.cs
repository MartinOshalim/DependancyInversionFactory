using DependancyInversionFactory.People.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People
{
    class Baby : IPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
}
