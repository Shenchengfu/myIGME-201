using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;
            Pets pets = new Pets();
            Random rand = new Random();

            string name = "";
            int age;

            for(int i = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("License => ");
                        string id = Console.ReadLine();
                        Dog d = new Dog(id, name, age);
                        pets.Add(d);
                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Cat c = new Cat(name, age);
                        pets.Add(c);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];
                    if (thisPet == null)
                        i = 0;
                    else if (thisPet is Dog)
                    {
                        iDog = (IDog)thisPet;
                        int operation = rand.Next(0, 5);
                        switch (operation)
                        {
                            case 0:
                                iDog.Eat();
                                break;
                            case 1:
                                iDog.Play();
                                break;
                            case 2:
                                iDog.Bark();
                                break;
                            case 3:
                                iDog.NeedWalk();
                                break;
                            case 4:
                                iDog.GotoVet();
                                break;
                        }
                    }
                    else
                    {
                        iCat = (ICat)thisPet;
                        int operation = rand.Next(0, 5);
                        switch (operation)
                        {
                            case 0:
                                iCat.Eat();
                                break;
                            case 1:
                                iCat.Play();
                                break;
                            case 2:
                                iCat.Purr();
                                break;
                            case 3:
                                iCat.Scratch();
                                break;
                            case 4:
                                iCat.GotoVet();
                                break;
                        }
                    }


                }

            }

        }
    }
}
