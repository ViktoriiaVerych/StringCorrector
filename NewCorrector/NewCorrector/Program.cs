
public class Program
{
    

    public static void Main(string[] args)
    //accepts command-line arguments as an array of strings args
    {
        
        Console.WriteLine("Enter string t: ");
        string t = Console.ReadLine();

        Console.WriteLine("Enter string s: ");
        string s = Console.ReadLine();

        bool isSubsequence = IsSubsequence(s, t);
        Console.WriteLine($"Is '{s}' a subsequence of '{t}'? {isSubsequence}");
    }
    //passes the strings s and t as arguments, to determine if s is a subsequence of t
    //the result is stored in the boolean variable isSubsequence
    public static bool IsSubsequence(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;
        // two variables initialized sIndex and tIndex.
        // these variables represent the current positions in the strings s and t, respectively

        while (sIndex < s.Length && tIndex < t.Length)
        //the loop continues 'till there are characters left in both s and t    
        {
            if (s[sIndex] == t[tIndex]) 
            //checks if the character at the current position in s is equal to the character at the current position in t
            
            {
                sIndex++;
            }

            tIndex++;
            //always incremented in each iteration to move to the next character in t
        }

        return sIndex == s.Length;
        //checks if the entire s string has been processed
        
        //if sIndex is equal to s.Length, it means that all characters in s were found in t in the same order, and s is considered a subsequence of t
        //the method returns true in this case; otherwise, it returns false
    }
}
