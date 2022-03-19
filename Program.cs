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

            var userName = GetName();
            string question = $"Wouldn't it be cool, {userName}, if you and your pet {GetAnimal()} could rock out to {GetBand()} under an intense {GetColor()} sky?!";
            Console.WriteLine(question);


            //----------------------------------------------------------Exercise 2

            //var addition = Add(7, 8);
            //Console.WriteLine(addition);

            //var subtraction = Subrtract(100, 50);
            //Console.WriteLine(subtraction);

            //var multiplication = Multiply(9, 3);
            //Console.WriteLine(multiplication);

            //var division = Divide(25, 5);
            //Console.WriteLine(division);

            //var remainder = Modulus(33, 12);
            //Console.WriteLine(remainder);

            Console.WriteLine("That's trippy.  Now, pick a number: ");
            int add1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ok. Pick another number to add to the first one: ");
            int add2 = int.Parse(Console.ReadLine());

            int addition = Add(add1, add2);
            Console.WriteLine($"The sum is {addition}.");



            Console.WriteLine("OK, pick another number: ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now pick another number to subtract from that one: ");
            int sub2 = int.Parse(Console.ReadLine());

            int subtraction = Subtract(sub1, sub2);
            Console.WriteLine($"The subtracted total is {subtraction}.");



            Console.WriteLine($"Great job, {userName}. We're gonna multiply now.  Pick a number: ");
            int mul1 = int.Parse(Console.ReadLine());

            Console.WriteLine("And another number to multiply it by: ");
            int mul2 = int.Parse(Console.ReadLine());

            int multiplication = Multiply(mul1, mul2);
            Console.WriteLine($"The mutiplicated total is {multiplication}.");



            Console.WriteLine("Time for division.  Pick a number: ");
            int div1 = int.Parse(Console.ReadLine());

            Console.WriteLine("And we'll divide it by this number: ");
            int div2 = int.Parse(Console.ReadLine());

            int division = Divide(div1, div2);
            Console.WriteLine($"The result is {division}.");



            Console.WriteLine("Last one.  Pick a number: ");
            int mod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pick another number to divide it by and I'll tell you how much is left over: ");
            int mod2 = int.Parse(Console.ReadLine());

            int remainder = Modulus(mod1, mod2);
            Console.WriteLine($"When you divide {mod1} by {mod2}, the remainder left over is {remainder}.  Ta da!");

        }

        //------------------------------------------------Methods for Exercise 2
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}