using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Pet
    {
        private string name;
        public int age;

        public Pet() { }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Eat()
        {
            Console.WriteLine("The pet is eating");
        }

        public void Play()
        {
            Console.WriteLine("The pet is playing");
        }

        public void GotoVet()
        {
            Console.WriteLine("We are taking out pet to the vet...");
        }
    }
}
