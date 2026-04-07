namespace Catalogue;

public class EmailNotification : Notification
{
    public string Message()
    {
        return "Email was sent";
    }

    public override bool ReportSuccess(int attempts)
    {
        throw new NotImplementedException();
    }
}