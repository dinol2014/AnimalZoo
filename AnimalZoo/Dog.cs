using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name, int age) // bygger ut konstruktor
        {
            /*inistiera attribut i obejektet*/
            SetSpecies(SPECIES.DOG); 
            SetCanFly(false);
            SetName(name);
            SetAge(age);
        }

        public override void IntroduceYourself() // överskriver functionen från Animal
        {
            Console.WriteLine("Voff. Jag är en hund som heter " + GetName());
            Console.WriteLine("Jag är " + GetAge() + " år gammal.");
            base.IntroduceYourself();
        }
    }
}