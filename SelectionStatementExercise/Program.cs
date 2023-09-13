namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my favorite number?");

            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Pick a number from 1 to 50.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
            Console.WriteLine($"TOO LOW!");

            }

            else if (userInput > favNumber)
            {
            Console.WriteLine($"Too high");

            }
            else
            {
                Console.WriteLine("You guessed my favorite number!");
            }

            
            }
        }
    }

