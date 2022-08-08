namespace LingoGame;

public class ExactCharacter : LingoCharacter
{
    // TODO 2b: Modify the Draw method to accept an argument of type IDevice
    // In the function replace the existing code for the DrawExact method.
    public override void Draw()
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(Character);
        Console.ResetColor();
    }

    public static new ExactCharacter Create(char c, int i)
    {
        return new ExactCharacter { Character = c, Position = i };
    }
}
