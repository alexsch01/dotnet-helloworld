namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            Console.Write(Environment.NewLine);
        }
    }
}