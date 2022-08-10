using IEEE;

namespace Logitech;

public class Camera : IDetectable
{
    public void Activate()
    {
        Record();
    }

    public void Record()
    {
        Console.WriteLine("De camara start met opnemen");
    }
}