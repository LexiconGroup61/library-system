using Catalogue;

namespace CatalogueTests;

public class PostTests
{
    Post post = new Post();
    
    [Fact]
    public void CalculateCostTest()
    {
        // requirement – total cost should be price * 1.25
        // arrange
        
        // price 40 * tax .25 + 40
        decimal expected = 50;
        
        // act
        decimal actual = post.CalculateCost(40);
        
        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateAreaTest()
    {
        double expected = 20 * 30;

        double actual = post.CalculateArea(20, 30);
        
        Assert.Equal(600, actual);
    }
}


