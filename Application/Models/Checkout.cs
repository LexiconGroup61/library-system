namespace Application.Models;

public class Checkout
{
    public int Id { get; set; }
    public Patron Patron { get; set; }
    public MediaItem MediaItem { get; set; }
    public DateTime CheckoutDate { get; set; }
}