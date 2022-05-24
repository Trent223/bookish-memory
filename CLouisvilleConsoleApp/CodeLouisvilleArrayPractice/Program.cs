
namespace CodeLouisvilleArrayPractice;

class Program
{
    static void Main(string[] args)
    {
        BusRoute route40 = new(40, "Morecambe", "Preston");
        BusRoute route42 = new(42, "Lancaster", "Blackpool");
        
        BusRoute[] routes =
        {
            route40,
            route42,
            new(100, "University", "Morecambe"),
            new(555, "Lancaster", "Keswick"),
        };

        Console.WriteLine("Where do you want to go?");
        string desiredLocation = Console.ReadLine();

        BusRoute route = FindBusTo(routes, desiredLocation);
        if (route != null)
            Console.WriteLine($"You can use route {route}");
        else
            Console.Write($"No routes go to {desiredLocation}");
    }

    public static BusRoute FindBusTo(BusRoute[] routes, string location)
    {
        foreach(BusRoute route in routes)
        {
            if (route.Origin == location || route.Destination == location)
                return route;
        }
        return null;
    }
}

