namespace NogMeerOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACME fabriek = new ACME();
            Arjen aj = new Arjen();
            Jos jos = new Jos();
            Andre ad = new Andre();
            Bokito bok = new Bokito();

            fabriek.Hire(aj);
            fabriek.Hire(jos);
            fabriek.Hire(ad);
            fabriek.Hire(bok);

            fabriek.Stoomfluit();
        }
    }
}