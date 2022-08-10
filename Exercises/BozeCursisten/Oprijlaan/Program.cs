using Heras;
using Logitech;
using DoomsdayPreppers;
using Portacon;

namespace Oprijlaan;

internal class Program
{
    static void Main(string[] args)
    {
        Hek hekje = new Hek();
        Valkuil kuil = new Valkuil();
        Camera cam = new Camera();
        Detectielus lus = new Detectielus();


        lus.Detect();
    }
}