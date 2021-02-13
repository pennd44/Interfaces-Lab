using System;

namespace Lesson8
{
    class Program
    {
        public interface Animal
        {
            void eat();
        }
        public interface Mammal: Animal
        {
            void speak();
            void run();
            
        }
        public class Dog
        {
            public void speak()
            {
                Console.WriteLine("Bark");
            }
            public void run()
            {
                Console.WriteLine("Dogs can run at a top speed of 45 mph!");
            }
            public void eat()
            {
                Console.WriteLine("Dogs eat bones.");
            }
        }
        public class Cat
        {
            public void speak()
            {
                Console.WriteLine("Meow");
            }
            public void run()
            {
                Console.WriteLine("Cats can run at a top speed of 30 mph!");
            }
            public void eat()
            {
                Console.WriteLine("Cats eat mice.");
            }

        }
        public class Cow
        {
            public void speak()
            {
                Console.WriteLine("Moo");
            }
            public void run()
            {
                Console.WriteLine("Cows can run at a top speed of 25 mph!");
            }
            public void eat()
            {
                Console.WriteLine("Cows eat grass.");
            }

        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Cow cow = new Cow();
            dog.speak();
            dog.run();
            dog.eat();
            cat.speak();
            cat.run();
            cat.eat();
            cow.speak();
            cow.run();
            cow.eat();


        }
    }
}
