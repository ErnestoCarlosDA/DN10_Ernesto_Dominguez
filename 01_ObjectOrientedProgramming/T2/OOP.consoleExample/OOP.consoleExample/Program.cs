using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
namespace OOP.consoleExample
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("type the animal");


                String animaType = Console.ReadLine().ToLower();
                Animal animal = null;
                switch (animaType)
                {
                    case "cat":
                        animal = new Cat();
                        break;
                    case "cow":
                        animal = new Cow();
                        break;
                    case "dog":
                        animal = new Dog();
                        break;
                    case "elephant":
                        animal = new Elephant();
                        break;
                    case "lion":
                        animal = new Lion();
                        break;
                    case "pig":
                        animal = new Pig();
                        break;

                    default:
                        Console.WriteLine("Animal no faund");
                        break;
                }

                if(animal != null)
                {
                    animal.AnimalSoud();
                }

            }
            
    }
}
}
