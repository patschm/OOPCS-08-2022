using IEEE;

namespace Portacon;

public class Detectielus
{
    private IDetectable[] _devices = new IDetectable[10];

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
        foreach(IDetectable device in _devices)
        {
            device?.Activate();  
        }
    }
}