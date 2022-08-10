namespace EvolutieTheorieDerDelegates;

delegate int MathDel(int arg1, int arg2);

internal class Program
{
    static void Main()
    {
        // dotnet 1.0/1.1 (2002/2003)
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // dotnet 2.0  (2005)
        MathDel m2 = Add;
        result = m2(2,3);

        MathDel m3 = delegate (int a, int b)
        {
            return a + b;
        };
        result = m3(3, 4);

        // dotnet 3.0/3.5
        MathDel m4 = (a, b) => a + b;
        result = m4(4, 5);

        // Procedures
        Action<int> a1 = Console.WriteLine;

        // Functions
        Func<int, int, int> m5 = (a, b) => a * b;
        result = m5(5, 6);

        // Predicate functions die bool teruggeven.
        //Predicate<>

        result = Add2(7, 8);

        //Console.WriteLine(result);
        a1(result);

        int Add2(int a, int b)
        {
            return a + b;
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}