namespace NogMeerOO;

class Jos : Werknemer
{
    public void MaaktAardbevingen()
    {
        Console.WriteLine("Jos maakt aardbevingspillen");
    }

    public override void Werkt()
    {
        MaaktAardbevingen();
    }
}
