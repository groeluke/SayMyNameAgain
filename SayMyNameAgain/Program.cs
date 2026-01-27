namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // say my name again

            string userInput = "";
            int result = 0;
            bool isValid = false;
            string message = "";

            do
            {
                Console.WriteLine("Please enter your name:");
                userInput = Console.ReadLine();
                Console.WriteLine($"{userInput}, have an amazing day!");

                if (userInput == "Luke" || userInput == "luke")
                { }



            } while (!isValid);
        }
    }
}
