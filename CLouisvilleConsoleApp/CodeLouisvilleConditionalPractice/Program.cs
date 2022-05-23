
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
    }
}