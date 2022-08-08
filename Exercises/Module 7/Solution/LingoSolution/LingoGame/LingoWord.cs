namespace LingoGame;

public class LingoWord : List<LingoCharacter>
{
    
    // TODO 3: Modify the Show method to accept an argument of type IDevice
    // pass the argument to the Draw method
    // Now we're ready. The game is device independent.
    // Continue with the ConsoleLingo project
    public void Show(IDevice device)
    {
        foreach(LingoCharacter lc in this)
        {
            lc.Draw(device);
        }
    }
    public static void Examine(LingoWord targetWord, LingoWord guess)
    {
        CharCounter counter = new CharCounter(targetWord);
        
        for (int i = 0; i < guess.Count; i++)
        {
            LingoCharacter guessChar = guess[i]!;
            foreach (LingoCharacter targetChar in targetWord)
            {
                if (LingoCharacter.ExactlyEqual(targetChar, guessChar))
                {
                    counter.DecrementCharacterCount(targetChar);
                    guess[i] = ExactCharacter.Create(guessChar.Character, guessChar.Position);
                }
            }
        }
        for (int i = 0; i < guess.Count; i++)
        {
            LingoCharacter guessChar = guess[i]!;
            foreach (LingoCharacter thisChar in targetWord)
            {
                if (!guessChar.IsExact() &&
                    counter.IsCharacterInWord(guessChar) &&
                    LingoCharacter.PartialEqual(thisChar, guessChar))
                {
                    counter.DecrementCharacterCount(thisChar);
                    guess[i] = PartialCharacter.Create(guessChar.Character, guessChar.Position);
                }
            }
        }
    }
    public override string ToString()
    {
        char[] chars = new char[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            chars[i] = this[i].Character;
        }
        return new string(chars);
    }
    public LingoWord(string? word)
    {
        for(int i = 0; i < word?.Length; i++)
        {
            LingoCharacter ch = LingoCharacter.Create(word[i], i);
            this.Add(ch);
        }
    }
    public LingoWord()
    {

    }
}
