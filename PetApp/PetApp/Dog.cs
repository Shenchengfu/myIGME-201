using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Dog : Pet, IDog
    {
        public string license;

        public Dog(string szLicense, string szName, int nAge):base(szName, nAge)
        {
            license = szLicense;
        }

        public void Eat()
        {
            Console.WriteLine(this.Name + ": Awwwww, I will eat everything!");
        }

        public void Play()
        {
            Console.WriteLine(this.Name + ": Woof Woof, throw me a ball!");
        }


        public void Bark()
        {
            Console.WriteLine(this.Name + ": Wooooofffff Woooooooffff !!!");
        }

        public void NeedWalk()
        {
            Console.WriteLine(this.Name + ": Woof, Woof, take me for a walk!");
        }

        public void GotoVet()
        {
            Console.WriteLine(this.Name + ": Arrrrgh, no vet please!");
        }
    }
}
