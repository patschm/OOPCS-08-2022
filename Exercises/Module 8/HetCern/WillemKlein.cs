namespace HetCern;

delegate int MathDel(int arg1, int arg2);

internal class WillemKlein
{
    public void Bereken(MathDel berekening, int a, int b)
    {
        Console.WriteLine("Willem Klein gaat rekenen");
        int result = berekening(a, b);


        Console.WriteLine($"Willem Klein heeft berekend: {result}");
    }
}
