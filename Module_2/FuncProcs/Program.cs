namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        //int nr = AskNumber();
        //int nr = Add(c:3);
        //ShowNumber(nr);

        int a;
        //Console.WriteLine(a);
        DoeIets(out a);
        Console.WriteLine(a);
    }

    static void DoeIets(out int a)
    {
        a = 100;
    }

    // Function
    static int AskNumber()
    {
        do
        {
            Console.WriteLine("Give number");
            var snr = Console.ReadLine();
           // int nr;
            if (int.TryParse(snr, out int nr))
            {
                return nr;
            }
        }
        while (true);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
    // Overload
    static int Add(int a =0, int b = 0, int c =  0)
    {
        return a + b + c;
    }
    static int Add(params int[] arg)
    {
        return arg.Sum();
    }

    // Procedure
    static void ShowNumber(int number)
    {
        Console.WriteLine($"The number is {number}");
    }
}