namespace NogMeerOO;


// Ontkoppelen van interactie tussen objecten
// can-do relatie
interface IContract
{
    void Produceer();
}

internal class ACME
{
    private IContract[] werknemers = new IContract[5];

    public void Hire(IContract wn)
    {
        for(int i = 0;i < werknemers.Length;i++)
        {
            if (werknemers[i] == null)
            {
                werknemers[i] = wn;
                return;
            }
        }
    }
    public void Stoomfluit()
    {
        Console.Beep(3000, 2000);
        Console.WriteLine("We gaan beginnen");
        foreach(IContract wn in werknemers)
        {
            wn?.Produceer();
        }
    }
}
