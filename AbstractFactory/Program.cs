using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type: " + animalFactory.GetType().Name);
            Console.WriteLine();

            Console.WriteLine("-------------------------");
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            Console.Read();
        }
    }
}
