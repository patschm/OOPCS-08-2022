namespace Objecten;

class Pen
{
    // Fields. Hierin slaan we de eigenschappen op.
    private int _linewidth;
    //private ConsoleColor _color = ConsoleColor.Black;

    //public void SetLinewidth(int nwWidth)
    //{
    //    if (nwWidth > 0 && nwWidth < 100)
    //    {
    //        _linewidth = nwWidth;
    //    }
    //}
    //public int GetLineWidth()
    //{
    //    return _linewidth;
    //}

    // Properties. Hiermee kan ik gecontroleerde toegang to fields regelen (privates)
    // Encapsulation
    public int Linewidth
    {
        get
        {
            return _linewidth;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                _linewidth = value;
            }
        }
    }
    // Auto-generating property.
    // Breng zijn eigen private fieldd mee.
    public ConsoleColor Color { get; set; }

    public int LineSurface
    {
        get
        {
            return Linewidth * 100;
        }
    }

    // Methods: Hierin leg je gedrag vast (veredelde functions of procedures)
    public void Write(string txt)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"{txt} in linewidth {Linewidth}");
        Console.ResetColor();
    }

    // Constructors. Bedoeld om _FIELDS_ van een initiele waarde te voorzien.
    public Pen()
    {
        Console.WriteLine("Default Constructor");
    }
    public Pen(int linewidth, ConsoleColor color)
    {
        Linewidth = linewidth;
        this.Color = color;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Virtual Universe
        // Big Bang
        
        Pen p = new Pen(12, ConsoleColor.Red);
        //p.Color = ConsoleColor.Green;
        //p.Linewidth = 10;

        p.Write("Hello World");
        Pen p2 = new Pen { Color = ConsoleColor.Blue, Linewidth = 15 };
        p2.Linewidth =  20;
        p2.Write("Hello World");
        // Big Crunch
    }
}