namespace Catalogue;

public struct LoanPeriod
{
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }

    public LoanPeriod(DateOnly dateA, DateOnly dateB)
    {
        StartDate = dateA;
        EndDate = dateB;
    }
}