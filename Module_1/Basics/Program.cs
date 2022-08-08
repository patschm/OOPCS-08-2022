namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 1;  // 0001
        int b = 2;  // 0010

        Console.WriteLine(a ^ b);

        int? age = null;
        int age2 = age ?? 42;
        string? name = Console.ReadLine();

        var test = name as string;
        Console.WriteLine(age > 18 ? "Ok": "Opkrassen");
        Console.WriteLine(nameof(Main));
    }
}