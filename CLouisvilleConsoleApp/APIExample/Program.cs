// See https://aka.ms/new-console-template for more information
namespace APIExample
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var proxy = new UniversitiesAPIProxy();
            
            string searchNameByKentucky = await proxy.SearchByNameAsync("Kentucky");

            Console.WriteLine(searchNameByKentucky);

            string searchNameByKentuckyAndUSA = await proxy.SearchByNameAndCountryAsync("Kentucky", "United States");

            Console.WriteLine(searchNameByKentuckyAndUSA);

            List<University> searchByNamePrinceton = await proxy.SearchByNameAsUniversityAsync("Princeton");
            
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(searchByNamePrinceton));
        }
    }
}

