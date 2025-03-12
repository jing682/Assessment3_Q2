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
                numTries--;
                Console.WriteLine("Number of tries left : " + numTries);
                
                if (number < randomNumber && numTries != 0)
                {
                    Console.Write("Too Low, Try Again : ");
                }
                else if (number > randomNumber && numTries != 0)
                {
                    Console.Write("Too High, Try Again : ");
                }
                else if (number == randomNumber)
                {
                    if (numTries > 0)
                    {
                        Console.WriteLine("Either you know the secret or you got lucky!");
                    }
                    else if (numTries == 0)
                    {
                        Console.WriteLine("You know the secret!");
                        break;
                    }
                }

                if (numTries == 0) 
                {
                    Console.WriteLine("You should be able to do better!");
                }
            }
        }
    }
}

