namespace NogMeerOO;

abstract class Werknemer : Persoon, IContract
{
    public void Produceer()
    {
        Werkt();
    }

    public abstract void Werkt();
}
