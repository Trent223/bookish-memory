
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the name of your band?");
        string bandName = Console.ReadLine();
        Console.WriteLine("How many people are in your band?");
        int bandMembers = int.Parse(Console.ReadLine());
        Console.WriteLine($"{bandName} has {bandMembers} members.");
    }
}

