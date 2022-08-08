namespace Types
{
   // [Flags]
    enum WeekDay : int
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 4,
        Friday = 8,
        Saturday = 16,
        Sunday = 32,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDay dayOfWeek = WeekDay.Tuesday;
            int dow = 7;
            Console.WriteLine((WeekDay)dow);
            Console.WriteLine(WeekDay.Monday | WeekDay.Tuesday);
            Console.WriteLine((int)dayOfWeek);
        }
    }
}