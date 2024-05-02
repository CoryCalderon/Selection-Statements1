namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 10);
            
            Console.WriteLine($"Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            
            if (userInput < favNumber)
            {
                Console.WriteLine($"Too low!");
            }
            
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Too high!");
            }

            else 
            {
            Console.WriteLine($"Wow, you guessed it!");
            }
            
        }
    }
}
