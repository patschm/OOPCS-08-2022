namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 1;  // 0001
        int b = 2;  // 0010

        Console.WriteLine(a ^ b);

        int age = 10;
        string? name = Console.ReadLine();

        var test = name as string;
        Console.WriteLine(age > 18 ? "Ok": "Opkrassen");
    }
}