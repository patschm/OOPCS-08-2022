
namespace DeRadio;

static class SoortOntvangst
{
    public static void ViaSms(string txt)
    {
        Console.WriteLine($"Via SMS: {txt}");
    }
    public static void ViaAether(string txt)
    {
        Console.WriteLine($"Via Aether: {txt}");
    }
    public static void ViaWifi(string txt)
    {
        Console.WriteLine($"Via Wifi: {txt}");
    }
    public static void ViaKabel (string txt)
    {
        Console.WriteLine($"Via Kabel: {txt}");
    }
    public static void ViaTamTam(string txt)
    {
        Console.WriteLine($"Via Tamtam: {txt}");
    }
    public static void ViaPostduif(string txt)
    {
        Console.WriteLine($"Via Postduif: {txt}");
    }
    public static void ViaRooksignalen(string txt)
    {
        Console.WriteLine($"Via Rooksignalen: {txt}");
    }
}
