namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVdMeer sm = new SimonVdMeer();

        //wk.Bereken(Multiply, 1, 2);

        MathDel del = sm.Add;
        del += sm.Add;
        del += sm.Subtract;
        del -= sm.Add;
        del -= sm.Subtract;

        foreach(var item in del.GetInvocationList())
        {
            Console.WriteLine(item.Method.Name);
        }

        var res = del(1, 2);
        Console.WriteLine(res);
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}