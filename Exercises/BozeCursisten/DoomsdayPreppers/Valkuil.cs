using IEEE;

namespace DoomsdayPreppers;

public class Valkuil : IDetectable
{
    public void Activate()
    {
        KlaptOpen();
    }

    public void KlaptOpen()
    {
        Console.WriteLine("De valkuil met spiezen klapt open");
    }
}