using System;
using System.Collections.Generic;
using System.Text;

namespace OutAndAbout
{
    internal class Run
    {
        public void Main()
        {
            Intro();
            ChooseAbility();
        Travel:
            TravelChoice();
            Travel();


        }

      

        private void Intro()
        {
            Console.WriteLine("Hi Lars.");
        }
        private void ChooseAbility()
        {
            Console.WriteLine("Which trinket would you like to bring");
        }


    }
}
