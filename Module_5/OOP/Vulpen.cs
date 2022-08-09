namespace OOP;

// Vulpen erft eigenschappen en gedrag van Pen.
// Overerven bevordert hergebruik.
// Belangrijker nog: Biedt de mogelijkheid tot generaliseren.
// Is een structerings mechanisme. Je beschrijft families van objecten.
// Je moet je altijd de vraag stellen: Is het een? (is-a relation)
class Vulpen : Pen
{
    private int nrOfWrites = 5;
    public override void Write(string txt)
    {
        if (nrOfWrites--<=0)
        {
            Console.WriteLine("De vulling is op");
            return;
        }
        Console.ForegroundColor = Color;
        Console.WriteLine($"{txt} in linewidth {Linewidth}");
        Console.ResetColor();
    }
}
