

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type a message");
        var message = Console.ReadLine();
        //Console.WriteLine("You said " + message);
        Console.WriteLine($"You said {message}");
    }
}

