namespace Catalogue;

public abstract class Notification
{
    public void FormatMessage(string message)
    {
        string formattedMessage = message.ToUpper();
    }

    public abstract bool ReportSuccess(int attempts);

}