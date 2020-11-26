using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name, int age) // bygger ut konstruktor
        {
            /*inistiera attribut i obejektet*/
            SetSpecies(SPECIES.CAT); 
            SetCanFly(false);
            SetName(name);
            SetAge(age);
        }

        public override void IntroduceYourself() // överskriver functionen från Animal
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + GetName());
            Console.WriteLine("Jag är " + GetAge() + " år gammal.");
            base.IntroduceYourself();
        }
    }
}