namespace SayMyNameAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // say my name again

            // Get the user's name
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // this is used to show what text to show in the greeting
            string displayname = name;

            // Use switch a selecting different greeting for different names
            switch (name)
            {
                case "luke":
                    Console.WriteLine("Howdy Luke, want to go fishing later.");
                    break;
                case "emily":
                    Console.WriteLine("Hello, Emily!");
                    break;
                case "joe":
                    Console.WriteLine("Hello, Joe!");
                    break;
                case "tim":
                    Console.WriteLine("Master Tim, how was your neck workout?");
                    break;
                default:
                    Console.WriteLine($"Hello {name}, talk about a legend! Make today great.");
            break;
            }
               //default is for everyother name used 

              //puase before ending the program
               Console.ReadLine();
        }
    }
}
