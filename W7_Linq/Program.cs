public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int> { -5, 0, 13, -107, 35, 152, 20, -16, 9, 32 };
        
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        Console.WriteLine("Odd numbers:");
        foreach (var num in oddNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");

        var negativeNumbers = numbers.Where(n => n < 0);
        Console.WriteLine("Negative numbers:");
        foreach (var num in negativeNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
        var positiveNumbers = numbers.Where(n => n > 0);
        Console.WriteLine("Positive numbers:");
        foreach (var num in positiveNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
        var selectedNumbers = numbers.Where(n => n > 15 && n < 22);
        Console.WriteLine("Numbers between 15 and 22:");
        foreach (var num in selectedNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
        var squaredNumbers = numbers.Select(n => n * n);
        Console.WriteLine("Squared numbers:");
        foreach (var num in squaredNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
        Console.ReadKey();
    }
}