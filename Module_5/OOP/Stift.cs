namespace OOP;

class Stift: Pen
{
    public bool IsAfneembaar { get; set; }

    public override void Write(string txt)
    {   
        Console.ForegroundColor = Color;
        Console.WriteLine($"De Stift: {txt} in linewidth {Linewidth}");
        Console.ResetColor();
    }
}
