using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;

namespace OutAndAbout
{
    internal class Character
    {
        private int Money =300;
        private int Fuel =50;
        private int MaxFuel;
        private string CurrentCountry = "Norway";
        private string CurrentLocation = "Home";
        private List<Pin> OwnedPins;
        private string CurrentEffect;

        public Character(string currentEffect)
        {
            CurrentEffect = currentEffect;
        }

        public string PrintEffect()
        {
            return CurrentEffect;
        }
        public int PrintMoney()
        {
            return Money;
        }
        public int PrintFuel()
        {
            return Fuel;
        }
        public string PrintLocation()
        {
            return CurrentLocation;
        }

        public void PrintAllPins()
        {
            //foreach (Pin pin in OwnedPins)
            {
                Console.Write($"{OwnedPins}");
            }
        }
    }
}
