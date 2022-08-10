
namespace Generieken;

internal struct Point<T> where T : IFormattable, new()
{
    public T X { get; set; }
    public T Y { get; set; }

    //public T Create()
    //{
    //    return new T();
    //}

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

struct KipCaravan : IFormattable
{
    public int AantalBedden { get; set; }
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        throw new NotImplementedException();
    }
}
