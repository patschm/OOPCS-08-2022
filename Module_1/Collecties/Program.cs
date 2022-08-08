using System.Diagnostics;
using System.Text;

namespace Collecties;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10] {1,2,3,4,5,6,7,8,9, 10};
        // array[10] = 100;
        Stopwatch w = new Stopwatch();

        w.Start();
        for (int i = 0; i < array.Length; i++)
        {
            int tnp = array[i];
            Console.WriteLine(tnp);
        }
        w.Stop();
        Console.WriteLine(w.Elapsed);

        w.Reset();
        w.Start();
        foreach(int tnp in array)
        {
            Console.WriteLine(tnp);
        }
        w.Stop();
        Console.WriteLine(w.Elapsed);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        matrix[1, 1] = 9;

        int[,,] kubus = new int[3, 3, 3];

        int[][] jagged = new int[5][];
        jagged[0] = new int[4];
        jagged[1] = new int[14];

        string str = "";
        StringBuilder bld = new StringBuilder();
        w = new Stopwatch();
        w.Start();
        for(int idx = 0; idx < 100000;idx++ )
        {
            //str += idx;
            bld.Append(idx);
        }
        w.Stop();
        Console.WriteLine(w.Elapsed);
    }
}