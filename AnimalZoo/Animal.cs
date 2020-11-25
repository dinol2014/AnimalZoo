using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum SPECIES {CAT, DOG, BIRD};

        private string name;
        private SPECIES species;
        private bool canFly;

        private static int currentYear = 2020;
        private int birthYear;

        public string GetName()
        {
            return name;
        }

        public SPECIES GetSpecies()
        {
            return species;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public int GetAge(int birthYear)
        {
            int age = currentYear - birthYear;
            return age;
        }

        public virtual void IntroduceYourself() // tillåter sigskälv att bli överskriven
        {
            if(canFly  == true)
            {
                Console.WriteLine("Jag kan flyga.");
            }
            else
            {
                Console.WriteLine("Jag kan inte flyga");
            }
            Console.WriteLine("Jag är en " + species);
        }
    }
}