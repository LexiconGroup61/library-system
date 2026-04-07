namespace Catalogue;



public class Post : IPost, IBookable
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

    public (Insect, bool) ReturnInsect(int num)
    {
        Insect insect = new Insect();
        insect.Legs = 8;
        return (insect, true);
    }

    public decimal CalculateCost(decimal price)
    {
        return price * 1.25m;
    }

    public double CalculateArea(double sideA, double sideB)
    {
        return sideA * sideB;
    }


    public bool SetReturnDate(int days)
    {
        throw new NotImplementedException();
    }
}