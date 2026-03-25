namespace Catalogue;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }

    public int ReturnNumber()
    {
        string number = Console.ReadLine();
        return int.Parse(number);
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