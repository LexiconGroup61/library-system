using Application.Enums;

namespace Application.Models;

public class MediaItem
{
    public int Id { get; set; }
    public TimeSpan LoanPeriod { get; set; }
    public string Location { get; set; }
    public AvailabilityStatus AvailabilityStatus { get; set; }
}