using LingoGame;
using System.Diagnostics;

namespace LingoWeb;

public class Game
{
    private string[] _wordlist = {"appel", "actie", "breed", "blind", "cadet", "creme",
                                    "deren", "dweil", "elven", "engel", "feest", "flora", "grote",
                                    "gebak", "hamer", "hoofd", "index", "icoon", "jawel", "japon",
                                    "kraan", "kleur", "licht", "laser", "motor", "markt", "nodig", "neven",
                                    "oases", "onwel", "polis", "preek", "quota", "quark", "ruzie", "schat",
                                    "treur", "typen", "uniek", "ultra", "vloer", "vorst", "wreed", "wazig",
                                    "xenon", "yacht", "yucca", "zomer", "zagen"};

    private readonly int MAX_WORD_LENGTH;
    public const int MAX_ATTEMPTS = 5;
    public List<LingoWord> Guesses { get; set; } = new List<LingoWord>(MAX_ATTEMPTS);
    public LingoWord? WordToBeGuessed { get; set; }
    public int Attempt
    {
        get
        {
            return Guesses.Count + 1;
        }
    }
    public bool IsFinished
    {
        get
        {
            bool guessed = Guesses.LastOrDefault()?.IsGuessed() ?? false;
            return Guesses.Count >= 5 || guessed;
        }
    }

    public void ResetGame()
    {
        Guesses = new List<LingoWord>();
        for (int idx = 0; idx < Guesses.Count; idx++)
        {
            Guesses[idx] = new LingoWord("     ");
        }
        RandomWord();
    }
    public void ShowGuesses(IDevice device)
    {
        foreach (var word in Guesses)
        {
            word.Show(device);
            Console.WriteLine();
        }
    }
    public void RandomWord()
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        int idx = rnd.Next(0, _wordlist.Length);
        WordToBeGuessed = new LingoWord(_wordlist[idx]);
        Debug.WriteLine(WordToBeGuessed);
    }
    public void Guess(LingoWord guess)
    {
        if (IsFinished) return;

        if (!IsValidInput(guess))
        {
            var message = $"{guess} is an invalid word";
            Status = message;
            guess.TrimToMaxLength(MAX_WORD_LENGTH);
            var tmp = Guesses.LastOrDefault();
            if (tmp != null)
            {
                for (int idx = 0; idx < tmp.Count; idx++)
                {
                    if (tmp[idx] is ExactCharacter)
                    {
                        guess[idx] = ExactCharacter.Create(tmp[idx].Character, tmp[idx].Position);
                        continue;
                    }
                    guess[idx] = LingoCharacter.Create(' ', idx);
                }            
            }
        } 
        Guesses.Add(guess);
        LingoWord.Examine(WordToBeGuessed!, guess);
        if (guess.IsGuessed())
        {
            var message = $"Congratulations! You guessed the word!";
            Status = message;
        }
        if (IsFinished)
        {
            ShowIQ();
        }
    }
    private bool IsValidInput(LingoWord guess)
    {
        return guess.Count == MAX_WORD_LENGTH;
    }
    private void ShowIQ()
    {
        string message;
        if (Attempt <= 5)
        {
            IQ iq = (IQ)Attempt;
            message = $"You guessed the word! Your IQ is {(IQ)Attempt}";
        }
        else
        {
            message = $"Game over!  Your IQ level must be expressed in decimal numbers";
        }
        Status = message;
    }
    public string Status { get; internal set; }
    public Game(int maxWordLength = 5)
    {
        MAX_WORD_LENGTH = maxWordLength;
        RandomWord();
    }
}

