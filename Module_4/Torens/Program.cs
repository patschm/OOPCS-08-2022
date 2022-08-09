namespace Torens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point { X = 1, Y = 2 };
            Point b = new Point { X = 10, Y = 20 };

            Point c = a + b;
            c.Show();


            Etage[] flat = new Etage[50];

            for(int i = 0; i < flat.Length; i++)
            {
                flat[i] = new Etage {  EtageNummer = i };
            }

            flat[30].RoepLift();

            flat[42].RoepLift();

            foreach(Etage e in flat)
            {
                //e.ToonLiftStatus();
            }
        }
    }
}