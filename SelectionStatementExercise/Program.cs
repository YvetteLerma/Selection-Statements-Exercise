namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 50);

            Console.WriteLine("Pick a number from 1 to 50.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
            Console.WriteLine($"{userInput} IS TOO LOW!");

            }

            else if (userInput > favNumber)
            {
            Console.WriteLine($"{userInput} IS TOO HIGH!");

            }
            else
            {
                Console.WriteLine("You guessed my favorite number!");
            }

            
            }
        }
    }

