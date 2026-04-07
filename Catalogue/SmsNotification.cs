namespace Catalogue;

public class SmsNotification : Notification
{
    public string Message()
    {
        return "Sms was sent";
    }

    public override bool ReportSuccess(int attempts)
    {
        throw new NotImplementedException();
    }
}