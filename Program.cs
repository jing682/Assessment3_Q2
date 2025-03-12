namespace Assessment3_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTries = 10;

            Random random = new Random();
            int randomNumber = random.Next(1, 1001);

            Console.WriteLine("======== Guess The Number ========");
            Console.Write("Guess a number between 1 and 1000 : ");

            while (numTries > 0) {
                int number = int.Parse(Console.ReadLine());

                if (number < randomNumber)
                {
                    Console.WriteLine("Too Low, Try Again");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Too High, Try Again");
                }
                else 
                {
                    Console.WriteLine("You guessed corretly!");
                }
                
                

            }
        }
    }
}
