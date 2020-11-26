using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name, int age) // bygger ut konstruktor
        {
            /*inistiera attribut i obejektet*/
            SetSpecies(SPECIES.BIRD); 
            SetCanFly(true);
            SetName(name);
            SetAge(age);
        }

        public override void IntroduceYourself() // överskriver functionen från Animal
        {
            Console.WriteLine("Pip. Jag är en fågel som heter " + GetName());
            Console.WriteLine("Jag är " + GetAge() + " år gammal.");
            base.IntroduceYourself();
        }
    }
}