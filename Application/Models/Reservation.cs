namespace Application.Models;

public class Reservation
{
    public int Id { get; set; }
    public Patron Patron { get; set; }
    public MediaItem MediaItem { get; set; }
    public DateTime ReservationDate { get; set; }

    private Reservation()
    {
        ReservationDate = DateTime.Now;
    }

    // public Reservation ReserveItem(Patron patron, MediaItem mediaItem)
    // {
    //     
    //     Patron = patron,
    //     MediaItem = mediaItem;
    // }
}

