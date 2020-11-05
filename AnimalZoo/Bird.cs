using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            /*inistiera attribut i obejektet*/
            species = SPECIES.BIRD; 
            canFly = true;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Pip. Jag är en fågel som heter " + name);
            base.IntroduceYourself();
        }
    }
}
