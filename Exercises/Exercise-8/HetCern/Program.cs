namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVdMeer sm = new SimonVdMeer();

        wk.Bereken(Multiply, 1, 2);
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}