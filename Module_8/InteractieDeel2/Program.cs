namespace InteractieDeel2;

internal class Program
{
    static void Main(string[] args)
    {
        Gwen gwen = new Gwen();
        Patrick pat = new Patrick();

        gwen.Execute(Explodeer);

        int[] vars = new int[] { 1, 2 };
        MyDelegate[] del = new MyDelegate[] { Explodeer, pat.Opdracht1 };
        //del();
    }

    static void Explodeer()
    {
        Console.WriteLine("Kaboom!!!");
    }
}