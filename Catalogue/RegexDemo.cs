using System.Text.RegularExpressions;

namespace Catalogue;

public class RegexDemo
{
    public static void DemoPart()
    {
        string text = "We find that the most secure text to search has a security above normal";
        string pattern = @"\b(security|safety)\b";
        Regex regexObject = new Regex(pattern);
        Console.WriteLine(regexObject.Match(text).Value);
        
    }
    
}