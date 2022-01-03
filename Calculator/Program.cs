namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.Write("x = ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            var y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            if(y == 0) {
                Console.WriteLine($"{x} / {y} = undefined");
            } else {
                Console.WriteLine($"{x} / {y} = {x/y}");
            }
        }
    }
}