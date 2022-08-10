using IEEE;

namespace Portacon;

public class Detectielus
{
    private IDetectable[] _devices = new IDetectable[10];
    public event Detectable? Detected;

    public void Connect(Detectable action)
    {
        Detected += action;
    }
    public void Connect(IDetectable device)
    {
        for(int i = 0; i < _devices.Length; i++)
        {
            if (_devices[i] == null)
            {
                _devices[i] = device;
                return;
            }
        }
    }
    public void Detect()
    {
        Console.WriteLine("De connectielus neemt iets waar");
        Console.WriteLine("==== Met interfaces ====");
        foreach (IDetectable device in _devices)
        {
            device?.Activate();  
        }
        Console.WriteLine("==== Met delegates ====");
        Detected?.Invoke();
    }
}