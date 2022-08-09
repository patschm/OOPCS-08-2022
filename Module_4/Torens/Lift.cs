namespace Torens
{
    internal class Lift
    {
        private int _currentFloor = 0;

        public int CurrentFloor
        {
            get { return _currentFloor; }
        }
        public void Call(int floorNr)
        {
            Console.WriteLine($"bzzzz naar {floorNr}");
            _currentFloor = floorNr;
        }
    }
}