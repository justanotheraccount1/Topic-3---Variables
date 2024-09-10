using System.Diagnostics;

namespace Topic_3___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/10/24

            string name, eyes, teeth, hair;
            int age, weight;
            double height;

            name = "Sam Ahrens";
            age = (2024 - 2008);
            height = ((5 * 12) + 10.5); //Inches
            weight = 180; //lbs
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";
            int myNumber = 15;
            myNumber = 20;
            double tallness = 1.62;
            Console.WriteLine(tallness);
            Console.WriteLine(myNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + height + " inches or " + (height * 2.54) + "cm tall.");
            Console.WriteLine("He weighs " + weight + "lbs or " + (weight * 0.453592) + "kg.");
            Console.WriteLine("Actually that's not too heavy");
            Console.WriteLine("He's got " + eyes + " eyes, and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add his age, (" + age + ") to his height in inches, (" + height +
                ") and his weight in pounds, (" + weight + ") I get " + (age + height + weight) + ".");
            Console.ReadLine();
        }
    }
}
