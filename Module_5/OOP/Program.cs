namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generaliseren. Je beschouwt de Vulpen als een Pen
            Pen vp = new Vulpen { Color = ConsoleColor.Blue, Linewidth = 20 };
            for(int i = 0; i < 6; i++)
                vp.Write("Hallo Vulpen");

            Pen st = new Stift { Color = ConsoleColor.Green, Linewidth = 20, IsAfneembaar=true };
            st.Write("Stiften");

            vp.Write("Hallo Vulpen");

            SchrijfIets(vp);
            SchrijfIets(st);
        }

        static void SchrijfIets(Pen p)
        {
            p.Write("Ik schrijf iets");
        }
    }
}