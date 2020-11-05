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

        public string name;
        public SPECIES species;
        public bool canFly;

        public virtual void IntroduceYourself()
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
