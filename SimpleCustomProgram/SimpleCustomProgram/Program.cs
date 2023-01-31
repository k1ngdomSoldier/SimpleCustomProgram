using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance

            Console.Title = "SimpleCustomProgram";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowWidth = 100;
            Console.WindowHeight = 40;
            Console.BufferWidth = 100;
            Console.BufferHeight = 40;

            Console.Clear();


            // Play around with the conversation - add more questions and answers to the conversation. Beep option does not work.
            {
                Console.WriteLine("Hello there, what is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Hi " + userName + ", Nice to meet you. My name is AI BOT.");
                Console.Beep();
                Console.ReadLine();

                Console.WriteLine("I'm an AI BOT, I don't know my name yet but my actions are very limited at the moment. Hopefully we can get more advanced in the future.");
                Console.Beep();
                Console.ReadLine();
                Console.WriteLine("I'm going to ask you a few questions, and you can answer them with a simple yes or no.");
                Console.Beep();
                Console.WriteLine("Are you ready?");
                Console.Beep();
                Console.ReadLine();

                Console.WriteLine("What is your favorite color?");
                Console.Beep(); 
                Console.ReadLine();

                Console.WriteLine("That's awesome, myne is Green. Kind off a giveaway isn't it? Haha.");
                Console.Beep();
                Console.ReadLine();

                Console.WriteLine("I can also do basic maths, I can multiply two numbers together.");
                Console.ReadLine();

                // either float for decimal or double for both int and float
                double num01;
                double num02;
                Console.Write("Input any number: ");

                
                num01 = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Input another number :");
                num02 = Convert.ToDouble(Console.ReadLine());

                // the int does not work, it says it is not a valid integer value. So, I tried to convert it to an integer value.
                double result = num01 * num02;
                Console.WriteLine("The product of the two numbers is: " + result);

                Console.ReadLine();
                
                

            }
        }
    }
}