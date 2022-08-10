namespace DeRadio;


delegate void ReceiveMethod(string text);

internal class RadioStation
{
    //private ReceiveMethod? _subscribers;

    public event ReceiveMethod? Subscribers;
    //{
    //    add
    //    {
    //        _subscribers += value;
    //    }
    //    remove
    //    {
    //        _subscribers -= value;
    //    }
    //}

    public void Narrowcast()
    {
        Console.WriteLine("We gaan live");
        Subscribers?.Invoke("Hallo. Daar zijn we dan");
    }
}
