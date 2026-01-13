using System;
using System.Collections.Generic;
using System.Text;

namespace OutAndAbout
{
    internal class Run
    {
        public static Character person;
        public void Main()
        {
            Intro();
            Effect pickedEffect = ChooseAbility();
            Character Lars = new Character($"{pickedEffect}");
            Console.WriteLine($"your effect is {Lars.PrintEffect()}");
            Lars.PrintEffect();
            //Travel:
            //TravelChoice();
            //Travel();


        }



        private void Intro()
        {
            Console.WriteLine("Hi Lars.");
        }
        private Effect ChooseAbility()
        {
            Console.WriteLine("Which trinket would you like to bring");
            Console.WriteLine("1. Bargening");
            Console.WriteLine("2. MoreFuel");
            Console.WriteLine("3. FlightBuff");
            Console.WriteLine("4. StreamBuff");
            string answer = Console.ReadLine();
            Effect pickedEffect = new Effect(answer);
            Console.Clear();
            Console.WriteLine($"You've chosen {pickedEffect}");
            return pickedEffect;
        }


    }
}
