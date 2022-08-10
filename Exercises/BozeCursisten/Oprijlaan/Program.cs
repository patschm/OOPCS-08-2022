using Heras;
using Logitech;
using DoomsdayPreppers;
using Portacon;

namespace Oprijlaan;

internal class Program
{
    static void Main(string[] args)
    {
        var hekje = new Hek();
        var kuil = new Valkuil();
        var cam = new Camera();
        var lus = new Detectielus();

        lus.Connect(hekje);
        lus.Connect(cam);
        lus.Connect(kuil);

        //lus.Connect(hekje.Open);
        //lus.Connect(cam.Record);
        //lus.Connect(kuil.KlaptOpen);

        lus.Detected += hekje.Open;
        lus.Detected += cam.Record;
        lus.Detected += kuil.KlaptOpen;
  
        lus.Detect();
    }
}