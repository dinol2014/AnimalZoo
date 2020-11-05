using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            /*inistiera attribut i obejektet*/
            species = SPECIES.CAT; 
            canFly = false;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + name);
            base.IntroduceYourself();
        }
    }
}
