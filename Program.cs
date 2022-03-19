using System;

namespace MethodExercise
{
    internal class Program
    {
        //---------------------------------------------------Methods for Exercise 1
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
            // ----------------------------------------------------------Exercise 1
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


            //----------------------------------------------------------Exercise 2

            var addition = Add(7, 8);
            Console.WriteLine(addition);

            var subtraction = Subrtract(100, 50);
            Console.WriteLine(subtraction);

            var multiplication = Multiply(9, 3);
            Console.WriteLine(multiplication);

            var division = Divide(25, 5);
            Console.WriteLine(division);

            var remainder = Modulus(33, 12);
            Console.WriteLine(remainder);

        }

        //------------------------------------------------Methods for Exercise 2
        public static int Add(int num1, int num2)
        {
            var add = num1 + num2;
            return add;
        }

        public static int Subrtract(int num1, int num2)
        {
            var subtract = num1 - num2;
            return subtract;
        }

        public static int Multiply(int num1, int num2)
        {
           var multiply = num1 * num2;
           return multiply;
        }

        public static int Divide(int num1, int num2)
        {
            var divide = num1 / num2;
            return divide;
        }

        public static int Modulus(int num1, int num2)
        {
            var modulus = num1 % num2;
            return modulus;
        }
    }
}