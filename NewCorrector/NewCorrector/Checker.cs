namespace NewCorrector;

public class Checker
{
    private readonly List<string> _data;
    //constuctor
    public Checker( List<string> data)
    {
        _data = data;
    }
    
    //preparation task
    public List<string> TyposChecking(IList<string> wordsList)
    {
        var mistakesInWords = new List<string>();
        foreach (var word in wordsList)
        {
            if (!_data.Contains(word))
            {
                mistakesInWords.Add(word);
            }
        }

        return mistakesInWords;
    }
    
    public List<string> SuitableWords(List<string> wordsList)
    {
        var suitableWords = new List<string>();
        foreach (var word in wordsList)
        {
            var counter = 0;
            foreach (var word2 in _data)
            {
                var subLength = LCS(word, word2);
                var levLength = Levenshtein(word, word2);
                if (subLength == word.Length - 1 && levLength <= 2)
                {
                    suitableWords.Add(word2);
                    counter++;
                }
    
                if (counter == 5)
                {
                    break;
                }
            }
        }
    
        return suitableWords;
    }

    private int LCS(string first, string second)
    {
        //later by Viktoriia
    }


    private int Levenshtein(string f, string s)
    {
        var firstWordLength = f.Length;
        var secondWordLength = s.Length;
        //later by Annechka
    }
}