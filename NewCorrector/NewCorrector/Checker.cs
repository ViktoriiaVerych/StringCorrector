﻿namespace NewCorrector;

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
        string[,] table = new string[first.Length + 2, second.Length + 2];
        table[1, 1] = "0";
        for (int i = 2, j = 0; i <= first.Length + 1; i++, j++)
        {
            table[i, 0] = first[j].ToString();
            table[i, 1] = "0";
        }

        for (int i = 2, j = 0; i <= second.Length + 1; i++, j++)
        {
            table[0, i] = second[j].ToString();
            table[1, i] = "0";
        }

        for (int i = 2; i <= first.Length + 1; i++)
        {
            string firstElement = table[i, 0];
            for (int j = 2; j <= second.Length + 1; j++)
            {
                string secondElement = table[0, j];
                if (firstElement == secondElement)
                {
                    table[i, j] = (Int32.Parse(table[i - 1, j - 1]) + 1).ToString();
                }
                else
                {
                    if (Int32.Parse(table[i, j - 1]) > Int32.Parse(table[i - 1, j]))
                    {
                        table[i, j] = table[i, j - 1];
                    }
                    else
                    {
                        table[i, j] = table[i - 1, j];
                    }
                }
            }
        }

        return Int32.Parse(table[first.Length + 1, second.Length + 1]);
    }


    private int Levenshtein(string f, string s)
    {
        var firstWordLength = f.Length;
        var secondWordLength = s.Length;
        //later by Annechka
    }
}