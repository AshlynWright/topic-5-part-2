namespace topic_5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ashlyn wright
            //part 2 topic 5
            //part 2 


            int secretNumber = 2;
            int guess;
            do
            {
                Console.WriteLine("Guess the secret number");
                guess = Convert.ToInt32(Console.ReadLine());
            } while (guess != secretNumber);

            Console.WriteLine("You guessed the secret number!");




        }
    }
}
