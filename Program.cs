using System;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OOP Concepts Demonstration ===\n");

            // Part 1: Inheritance and Method Overriding
            Console.WriteLine("Part 1: Inheritance and Method Overriding");
            DemonstrateInheritance();

            Console.WriteLine("\nPart 2: Abstract Classes and Methods");
            DemonstrateAbstractClasses();

            Console.WriteLine("\nPart 3: Interfaces");
            DemonstrateInterfaces();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void DemonstrateInheritance()
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Calling MakeSound() on different animals:");
            Console.Write("Generic Animal: ");
            genericAnimal.MakeSound();

            Console.Write("Dog: ");
            dog.MakeSound();

            Console.Write("Cat: ");
            cat.MakeSound();
        }

        static void DemonstrateAbstractClasses()
        {
            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine("Calculating areas of different shapes:");
            Console.WriteLine($"Circle (radius 5): {circle.GetArea():F2} square units");
            Console.WriteLine($"Rectangle (4x6): {rectangle.GetArea():F2} square units");
        }

        static void DemonstrateInterfaces()
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            Console.WriteLine("Demonstrating movement of different objects:");
            car.Move();
            bicycle.Move();
        }
    }
}