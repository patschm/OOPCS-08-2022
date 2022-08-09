using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torens
{
    internal class Etage
    {
        private static Lift otis = new Lift();
        public int EtageNummer { get; set; }

        public void RoepLift()
        {
            Etage.otis.Call(EtageNummer);
        }
        public void ToonLiftStatus()
        {
            Console.WriteLine(Etage.otis.CurrentFloor);
        }
    }
}
