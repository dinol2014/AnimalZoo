using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name) // bygger ut konstruktor
        {
            /*inistiera attribut i obejektet*/
            species = SPECIES.DOG; 
            canFly = false;
            base.name = name;
        }

        public override void IntroduceYourself() // överskriver functionen från Animal
        {
            Console.WriteLine("Voff. Jag är en hund som heter " + name);
            Console.WriteLine("Jag är " + age + " år gammal.");
            base.IntroduceYourself();
        }
    }
}