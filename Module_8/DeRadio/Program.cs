namespace DeRadio;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation skyRadio = new RadioStation();

        skyRadio.Subscribers += SoortOntvangst.ViaPostduif;
        skyRadio.Subscribers += SoortOntvangst.ViaRooksignalen;
        skyRadio.Subscribers += SoortOntvangst.ViaSms;
        skyRadio.Subscribers += SoortOntvangst.ViaKabel;
        skyRadio.Subscribers += SoortOntvangst.ViaAether;
        skyRadio.Subscribers += SoortOntvangst.ViaTamTam;
        skyRadio.Subscribers += SoortOntvangst.ViaWifi;
        skyRadio.Subscribers += SoortOntvangst.ViaPostduif;
        skyRadio.Subscribers += SoortOntvangst.ViaRooksignalen;
        skyRadio.Subscribers += SoortOntvangst.ViaSms;
        skyRadio.Subscribers += SoortOntvangst.ViaKabel;
        skyRadio.Subscribers += SoortOntvangst.ViaAether;
        skyRadio.Subscribers += SoortOntvangst.ViaTamTam;
        skyRadio.Subscribers += SoortOntvangst.ViaWifi;

        skyRadio.Narrowcast();

    }
}