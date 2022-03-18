using System;

namespace MethodExercise
{
    internal class Program
    {
        static string GetName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }
        static string GetColor()
        {
            Console.WriteLine("What is your favorite color?");
            return Console.ReadLine();
        }
        static string GetAnimal()
        {
            Console.WriteLine("What is your favorite animal?");
            return Console.ReadLine();
        }
        static string GetBand()
        {
            Console.WriteLine("What is your favorite band?");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //Console.WriteLine("What is your favorite color?");
            //var color = Console.ReadLine();
            //Console.WriteLine("What is your favorite animal?");
            //var animal = Console.ReadLine();
            //Console.WriteLine("What is your favorite band?");
            //var band = Console.ReadLine();
            //Console.WriteLine($"Wouldn't it be cool, {name}, if you and your pet {animal} could rock out to {band} under a {color} sky?!");


            string question = $"Wouldn't it be cool, {GetName()}, if you and your pet {GetAnimal()} could rock out to {GetBand()} under an intense {GetColor()} sky?!";
            Console.WriteLine(question);
        }
    }
}