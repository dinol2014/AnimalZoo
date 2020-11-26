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

        public void SetAge(int age)
        {
            birthYear = currentYear - age;
        }

        public int GetAge()
        {
            int age = currentYear - birthYear;
            return age;
        }

        public static void SetYear(int year)
        {
            currentYear = year;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public SPECIES GetSpecies()
        {
            return species;
        }

        public void SetSpecies(SPECIES species)
        {
            this.species = species;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public void SetCanFly(bool canFly)
        {
            this.canFly = canFly;
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