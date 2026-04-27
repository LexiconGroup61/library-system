namespace Catalogue;

public class Directory
{
    public int Id { get; set; }
    private Dictionary<string, int> posts { get; set; } = new Dictionary<string, int>();
    private Dictionary<string, int> calculations { get; set; } = new Dictionary<string, int>();

    public Post Post { get; set; }
    
    public bool AddToPosts(string text, int number)
    {
        if (posts.ContainsKey(text))
        {
            return false;
        }
        posts[text] = number;
        return true;
    }

    public string AddNumbers(int a, int b)
    {
        string toBeKey = a < b ? "" + a + "+" + b : "" + b + "+" + a;
        if (calculations.ContainsKey(toBeKey))
        {
            return "Value is " + calculations[toBeKey] + ", gotten from cache";
        }

        int number = a + b;
        calculations[toBeKey] = number;
        return "Value is " + number;
    }
    


}