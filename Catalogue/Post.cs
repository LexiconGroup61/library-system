namespace Catalogue;



public class Post : IPost
{
    private string textSnippet;
    public int Id { get; set; }
    public int ReturnNumber()
    {
        throw new NotImplementedException();
    }

    public string Title { get; set; }

    public int ReturnNumber(string text, int notUsed)
    {
        string number = Console.ReadLine();
        return int.Parse(number);
    }

    public int ReturnNumber(int num)
    {
        throw new NotImplementedException();
    }

    public decimal CalculateCost(decimal price)
    {
        return price * 1.25m;
    }

    public double CalculateArea(double sideA, double sideB)
    {
        return sideA * sideB;
    }
    
    
}