namespace OOP;

// Sealed. Je kunt niett meer erven van deze class.
sealed class Stift: Pen
{
    public bool IsAfneembaar { get; set; }

    public sealed override void Write(string txt)
    {   
        Console.ForegroundColor = Color;
        Console.WriteLine($"De Stift: {txt} in linewidth {Linewidth}");
        Console.ResetColor();
    }
}
