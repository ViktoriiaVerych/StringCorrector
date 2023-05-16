
public class Program
{
    // private static List<string> data;

    public static void Main(string[] args)
    {
        // data = new List<string>();
        //
        // foreach (var line in File.ReadAllLines(@"C:\Users\Admin\RiderProjects\NewCorrector\StringCorrector\NewCorrector\NewCorrector\WordList.txt"))
        // {
        //     data.Add(line);
        // }

        Console.WriteLine("Enter string s: ");
        string t = Console.ReadLine();

        Console.WriteLine("Enter string t: ");
        string s = Console.ReadLine();

        bool isSubsequence = IsSubsequence(s, t);
        Console.WriteLine($"Is '{t}' a subsequence of '{s}'? {isSubsequence}");
    }

    public static bool IsSubsequence(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }

            tIndex++;
        }

        return sIndex == s.Length;
    }
}
