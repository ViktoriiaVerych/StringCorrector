using System.Collections;
using NewCorrector;
/*
The code initializes the Checker class with reference data from a file.
It interacts with the user to input sentences and then identifies typos and suggests corrections.
The Fixer function removes separators and empty elements from the words list.
The loop continues until the user decides to end by entering "no" when prompted.
Detected typos are displayed, and suggestions for suitable corrections are provided.

*/
var data = new List<string>();

foreach (var line in File.ReadAllLines(@"C:\Users\Admin\RiderProjects\NewCorrector\StringCorrector\NewCorrector\NewCorrector\WordList.txt"))
{
    data.Add(line);
}

var checker = new Checker(data);
var separators = " .,-+:;!?";
bool end = false;
while (!end)
{
    Console.WriteLine("Enter a sentence: ");
    string input = Console.ReadLine();
    var words = input.Split(' ','.',',','—','+',':',';','!','?');
    var wordsList = new List<string>();
    foreach (var word in words)
    {
        wordsList.Add(word);
    }

    Fixer(wordsList);
    var mistakes = checker.TyposChecking(wordsList);
    Console.Write("Looks like you have typos in next words: ");
    Console.WriteLine();
    foreach (var word in mistakes)
    {
        Console.Write($"'{word}' ");
    }

    var result = checker.SuitableWords(mistakes);
    Console.WriteLine("Suggested correction:");
    Console.WriteLine();
    foreach (var word in result)
    {
        Console.Write($"'{word}' ");
    }
    Console.WriteLine();
    Console.Write("Continue: ");
    if (Console.ReadLine() == "no") 
        end = true;



}

void Fixer(IList<string> data)
{
    for (var i = 0; i < data.Count; i++)
    {
        foreach (var separator in separators)
        {
            if (data.Contains(separator.ToString()))
            {
                data.Remove(separator.ToString());
            }

            if (data.Contains(""))
            {
                data.Remove("");
            }
        }
    }
}
