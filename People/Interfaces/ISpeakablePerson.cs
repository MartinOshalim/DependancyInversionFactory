﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependancyInversionFactory.People.Interfaces
{
    public interface ISpeakablePerson : IPerson, ISayHello
    {
    }
}
