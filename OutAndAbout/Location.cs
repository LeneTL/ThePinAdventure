using System;
using System.Collections.Generic;
using System.Text;

namespace OutAndAbout
{
    internal class Location
    {
        private string Name;
        private string Country;
        private Pin Pin;

        public Location(string name, string country, Pin pin)
        {
            Name = name;
            Country = country;
            Pin = pin;
        }
    }
}
