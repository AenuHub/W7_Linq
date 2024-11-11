public class Program
{
    public static void Main(string[] args)
    {
        // create a list of 10 random numbers between -50 and 50
        var numbers = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(random.Next(-50, 50 + 1));
        }

        Console.WriteLine("Numbers in the list:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n------------------");
        
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
        if (selectedNumbers.Count() == 0)
        {
            Console.Write("No numbers found");
        }
        else
        {
            foreach (var num in selectedNumbers)
            {
                Console.Write(num + " ");
            }
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