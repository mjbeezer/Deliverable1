using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Milennial Hipsters have gone too far! We must travel across space and time to undo all they have done...");

            //Declaring values from table in Deliverable 1 instructions
            double inch;
            int memes;
            double fidgetspinner;
            int foot;
            bool application = true;

            //Take user input for measurement type

            while (application) {

                Console.WriteLine("What measurement type are we converting?");
                string userInput = Console.ReadLine();
                Console.WriteLine("Measurement type is " + userInput);

                //Take user amount for measurement
                Console.WriteLine("How many total?");
                double userInput2 = double.Parse(Console.ReadLine());

                //Loop to take user input and determine what we are converting to
                if (userInput == "inch") {
                    Console.WriteLine(userInput2 * 3.5 + " fidgetspinners");
                } else if (userInput == "foot")
                {
                    Console.WriteLine(userInput2 * 5 + " Memes");
                } else if (userInput == "fidgetspinners")
                {
                    Console.WriteLine(userInput2 / 3.5 + " inches");
                } else
                {
                    Console.WriteLine(userInput2 / 5 + " feet");
                }
                //Ask user to give another measurement type
                Console.WriteLine("Would you like to convert a different measurement type? y/n");
                string keepgoing = Console.ReadLine();
                if (keepgoing == "y")
                {
                    application = true;
                } else
                {
                    application = false;
                }
            }
        }
    }
}
