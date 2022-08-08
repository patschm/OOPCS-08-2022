namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        int age = 10;
        if (age < 16)
        {

        }
        else if (age < 18)
        {

        }
        else
        {

        }

        switch (age)
        {
            case 9:
            case 10:
                Console.WriteLine("Negen of tien");
                break;
            case 18:
                Console.WriteLine("Achttien");
                break;
            default:
                Console.WriteLine("Iets anders");
                break;
        }


        // Gebruik je als je weet hoe vaak je iets moet herhalen.
        for (int iter = 0; true; iter+= 10 )
        {
            if (iter > 200) continue;
           // Console.WriteLine($"Hello {iter}");
        }

        // Wordt 0 of meer keer uitgevoerd.
        // Je weet niet hoe vaak.
        while(age < 100)
        {
            Console.WriteLine(age++);
        }

        // Wordt 1 of meer keer uitgevoerd.
        // Je weet niet hoe vaak.
        do
        {
            Console.WriteLine(age++);
        }
        while (age < 1000);
    }
}