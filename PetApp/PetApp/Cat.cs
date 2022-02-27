using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Cat : Pet, ICat
    {
        public Cat(string name, int age):base(name, age) { }

        public void Eat()
        {
            Console.WriteLine(this.Name + ": Mmmmeow, give me my favorite salmon!");
        }

        public void Play()
        {
            Console.WriteLine(this.Name + ": Where's my tiny little mouse...");
        }

        public void Purr()
        {
            Console.WriteLine(this.Name + ": Purrrr Purrrr Purrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine(this.Name + ": Mmmmeow, I need to get my nails done!");
        }


        public void GotoVet()
        {
            Console.WriteLine(this.Name + ": I will scratch you and your friend vet!");
        }

    }
}
