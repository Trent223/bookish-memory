namespace Class3Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop example
            Console.WriteLine("Please enter a number: ");
            string input = Console.ReadLine();
            int inputAsInt;
            bool wasInt = int.TryParse(input, out inputAsInt);
            while(!wasInt) //While the user's input was NOT an integer...
            {
                Console.WriteLine("That wasn't a number! Please try again.");
                Console.WriteLine("Please enter a number: ");
                input = Console.ReadLine();
                wasInt = int.TryParse(input, out inputAsInt);
            }
            
            Console.WriteLine($"You entered {inputAsInt}");
                
        }
    }
}