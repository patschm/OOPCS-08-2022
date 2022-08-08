namespace LingoGame;

public static class LingoExtension
{  
    public static bool IsGuessed(this LingoWord guess)
    {
        bool[] isExact = new bool[guess.Count];
        for (int i = 0; i < guess.Count; i++)
        {
            if (guess[i] is ExactCharacter)
            {
                isExact[i] = true;
            }
        }
        return !isExact.Contains(false);
    }    
    public static void TrimToMaxLength(this LingoWord word, int maxLength = 5)
    {
        if (word.Count < maxLength)
        {
            for(int i = word.Count; i < maxLength; i++)
            {
                word.Add(LingoCharacter.Create(' ', i));
            }
        }
        else if (word.Count > maxLength)
        {
            word.RemoveRange(maxLength, word.Count - maxLength);
        }
    }
    public static bool IsExact(this LingoCharacter character)
    {
        return character is ExactCharacter;
    }
}
