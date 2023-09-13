namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 50);
            int userInput; // will have to initialize userInput outside of the loop in order for it to execute at the end
            
            do //do executes the code below // you do not have to add a do while, however, the code will only run once without it
            {
                Console.WriteLine("Pick a number from 1 to 50.");
                userInput = int.Parse(Console.ReadLine()); //.Parse converts the int to text like Convert.ToInt32(Console.ReadLine());

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


            } while (userInput != favNumber); //userInput does not equal favNumber //cannot declare something inside the do while and call it outside of the loop
        }
    }
}
