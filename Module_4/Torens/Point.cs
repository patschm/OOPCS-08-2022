using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torens;

internal class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point operator+(Point lh, Point rh)
    {
        return new Point { X = lh.X + rh.X, Y = lh.Y + rh.Y };
    }

    public void Show()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}
