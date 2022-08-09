using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;

abstract class Pen
{
    // Fields. Hierin slaan we de eigenschappen op.
    private int _linewidth;
   
    // Properties. Hiermee kan ik gecontroleerde toegang to fields regelen (privates)
    // Encapsulation
    public int Linewidth
    {
        get
        {
            return _linewidth;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                _linewidth = value;
            }
        }
    }
    // Auto-generating property.
    // Breng zijn eigen private fieldd mee.
    public ConsoleColor Color { get; set; }

    // Methods: Hierin leg je gedrag vast (veredelde functions of procedures)
    // Virtual geeft aan dat het gedrag polymorf kan zijn (polymorf-ready)
    // Abstract moet een afgeleide class the methode overriden. En de hele class
    // wordt abstract.
    public abstract void Write(string txt);
    //{
    //    Console.ForegroundColor = Color;
    //    Console.WriteLine($"{txt} in linewidth {Linewidth}");
    //    Console.ResetColor();
    //}

    // Constructors. Bedoeld om _FIELDS_ van een initiele waarde te voorzien.
}
