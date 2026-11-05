namespace HelloWorld_Allee_Derek
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Going to ask what their gamertag is, favorite system & thier favorite game. Then will output a message with their gamertag, favorite system & favorite game.

            //asks the player to enter their gamertage, dispays a welcome message with their gamertag.
            Console.Write("Enter your gamertag?:    ");
            string gamerTag = Console.ReadLine() ?? "";
            Console.WriteLine("Welcome, " + gamerTag + "!");
            Console.WriteLine();

            //asks the player to enter their favorite system, dispays a message with their favorite system.
            Console.Write("Whats your favorite system?:   ");
            string favoriteSystem = Console.ReadLine() ?? "";
            Console.WriteLine("The " + favoriteSystem + " is a great system!");
            Console.WriteLine();

            //asks the player to enter their favorite game, dispays a message with their favorite game.
            Console.Write("What is your favorite game?:   ");
            string favoriteGame = Console.ReadLine() ?? "";
            Console.WriteLine("Oh yeah " + favoriteGame + " is a fire game!");
            Console.WriteLine();

            






        }
    }
}
