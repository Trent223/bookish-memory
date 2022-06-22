namespace Class4Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("initialName");
            Person person2 = new()
            {
                Name = "Name",
                Age = 2
            };

            
            person.Name = "initialName";
        }

        static string Announce(string venue)
        {
            return venue + " will have bands performing tonight.";
        }

        static void AnnounceVoid(string venue)
        {
            Console.WriteLine($"{venue} will have bands performing tonight.");
        }
    }
}