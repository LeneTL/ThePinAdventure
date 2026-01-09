using System;
using System.Collections.Generic;
using System.Text;

namespace OutAndAbout
{
    public enum AllEffects
    {
        Bargening, //possibly cheaper pins
        MoreFuel, //More fuel on car
        Flightbuff, //Cheaper Flights
        Streambuff //Earn more money when streaming
    };
    internal class Effect
    {
        public AllEffects CurrentEffect;

        public Effect(string choice)
        {
            switch (choice)
            {
                case "1":
                    CurrentEffect = AllEffects.Bargening; break;
                case "2":
                    CurrentEffect = AllEffects.MoreFuel; break;
                case "3":
                    CurrentEffect = AllEffects.Flightbuff; break;
                case "4":
                    CurrentEffect = AllEffects.Streambuff; break;
                default:
                    Console.WriteLine("Please enter 1,2,3 or 4"); break;
            }
        }
    }
}
