namespace Notification;

public static class NotificationServ{
    public static void SendSMS(string to, string content){
        Console.WriteLine("SMS is sent to "+ to);
    }
    public static void SendMail(string to, string content){
        Console.WriteLine("Mail is sent to "+ to);
    }
}

