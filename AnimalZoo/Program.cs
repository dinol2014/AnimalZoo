using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;
            allAnimals = new Animal[4];

            #region konstruktorn gör en ny instans av obejektet
            allAnimals[0] = new Cat("Kurre");
            allAnimals[1] = new Dog("Vilma");
            allAnimals[2] = new Cat("Bamse");
            allAnimals[3] = new Bird("Birb");
            #endregion

            foreach (Animal a in allAnimals) // för varje instans a av klassen Animal så loopar den
            {
                Console.WriteLine("Nu kommer " + a.name);
                a.IntroduceYourself(); // kallar på en function i ett obejekt
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}