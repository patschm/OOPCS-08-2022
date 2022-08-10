namespace InteractieDeel2;

public delegate void MyDelegate();

public class Gwen
{
    public void Execute(MyDelegate info)
    {
        Console.WriteLine("Gwen gaat nu uitvoeren");
        info();
    }
}
