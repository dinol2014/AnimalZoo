using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            /*inistiera attribut i obejektet*/
            species = SPECIES.DOG; 
            canFly = false;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Voff. Jag är en hund som heter " + name);
            base.IntroduceYourself();
        }
    }
}
