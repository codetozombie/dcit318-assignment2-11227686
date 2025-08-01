using System;

namespace OOPDemo
{
    // Part 1: Inheritance and Method Overriding
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    // Part 2: Abstract Classes and Methods
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }// Part 3: Interfaces
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

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


