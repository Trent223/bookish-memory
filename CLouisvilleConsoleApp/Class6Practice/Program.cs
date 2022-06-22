
using Class6Practice.People;
using System.Linq;
namespace Class6Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //while(true)
            //{
            //    WorkerClass.DoWork();
            //}

            List<string> someStrings = new List<string>()
            {
                "someString",

                "1234",
                "test",
                "Trent Minch",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };


            string? myString = someStrings.FirstOrDefault(item => item.StartsWith("J"));
            if (myString == null)
                Console.WriteLine("No match");
            else
                Console.WriteLine(myString);            

            //try
            //{
            //     myString = someStrings.First(item => item.StartsWith("J"));
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("No matching item");
            //}

           

            //MyModel? data = new();

            //string filePath = @"./Data/data.json";

            //using (FileStream sourceStream = File.OpenRead(filePath))
            //{
            //    data = System.Text.Json.JsonSerializer.Deserialize<MyModel>(sourceStream, 
            //        options: new() { PropertyNameCaseInsensitive = true});
            //}

            //Console.WriteLine(data.Name);

            //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));

            //File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(data));
        }
    }
}