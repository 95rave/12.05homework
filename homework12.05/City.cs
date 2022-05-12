using System;
using System.Collections.Generic;
using System.Text;

namespace homework12._05
{
    class City
    {
        public string Name;
        public int Population;

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }
        public override string ToString()
        {
            return $"Name:{Name} \n Population:{Population}";
        }

    }

}
