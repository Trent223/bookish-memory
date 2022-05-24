
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your band?");
        string bandName = Console.ReadLine();
        Console.WriteLine("How many people are in your band?");

        if (!int.TryParse(Console.ReadLine(), out int bandMembers))
        {
            Console.WriteLine("Input was not valid");
            Environment.Exit(0);
        }

        Console.WriteLine($"{bandName} has {bandMembers} members.");


        string venue = "someVenue";
        string bandArgument = "0";
        int bands = 0;
        int.TryParse(bandArgument, out bands);

        if (int.TryParse(bandArgument, out bands))
        {
            Console.WriteLine(venue + " will have " + bands + " bands performing tonight!");

            if (bands == 0)
            {
                Console.WriteLine("There will be no performances tonight.");
            }
            else if (bands == 1)
            {
                Console.WriteLine("It's going to be a fantastic show tonight!");
            }
            else
            {
                Console.WriteLine("There will be plenty of thrilling performances to see tonight!");
            }
        }
        else
        {
            Console.WriteLine("We were unable to determine the number of bands performing tonight, try again.");
        }

    }
}