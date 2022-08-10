using Microsoft.Spatial;
using System.Collections;

namespace Generieken;

internal class Program
{
    static void Main(string[] args)
    {
        //Geometry
        //DateTime
        //int xxxx = 10;
        Point<int> p1 = new Point<int> { X = 10, Y = 20 };
       // sizeof(Point<int>);
        //ArrayList list = new ArrayList();
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //list.Add("4");

        foreach(int nr in list)
        {
            Console.WriteLine(nr);
        }

        Point<int> p1 = new Point<int>{ X = 10, Y=20 };
        //p1.Y = 200;
        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);

        KipCaravan k1 = new KipCaravan { AantalBedden = 4 };
        DoeIets(k1);
        double aa = 10.1;
        double bb = 20.4;

        Console.WriteLine($"aa={aa}, bb={bb}");
        Swap<double>(ref aa, ref bb);
        Console.WriteLine($"aa={aa}, bb={bb}");
    }

    private static void DoeIets(Point<int> pp1)
    {
        pp1.Y = 2000;
        pp1.X = 1000;
    }

    private static void DoeIets(object pp1)
    {
        //((KipCaravan)pp1).AantalBedden = 5;
    }

    static void Swap<Tita>(ref Tita aaa, ref Tita bbb)
    {
        Tita hulp = aaa;
        aaa = bbb;
        bbb = hulp;
    }

    //static void Swap(ref int aaa, ref int bbb)
    //{
    //    int hulp = aaa;
    //    aaa = bbb;
    //    bbb = hulp;
    //}
    //static void Swap(ref long aaa, ref long bbb)
    //{
    //    long hulp = aaa;
    //    aaa = bbb;
    //    bbb = hulp;
    //}
    //static void Swap(ref float aaa, ref float bbb)
    //{
    //    float hulp = aaa;
    //    aaa = bbb;
    //    bbb = hulp;
    //}
}