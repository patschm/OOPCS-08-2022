namespace NogMeerOO;

class Arjen : Werknemer
{
    public void DoetIets()
    {
        Console.WriteLine("Arjen doet iets");
    }

    public override void Werkt()
    {
        DoetIets(); 
    }
}
