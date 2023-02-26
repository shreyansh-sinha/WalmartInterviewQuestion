using WalmartInterviewQuestion.Observable;
using WalmartInterviewQuestion.Observer;

public class Program
{
    public static void Main(String[] args)
    {
        INotificationAlert notificationAlert = new NotificationAlert();
        INotificationObserver observer1 = new EmailNotificationObserver(notificationAlert, "xyz@gmail.com");
        INotificationObserver observer2 = new EmailNotificationObserver(notificationAlert, "abc@gmail.com");
        INotificationObserver observer3 = new MobileNotificationObserver(notificationAlert, "xyz-abc");

        notificationAlert.addObserver(observer1);
        notificationAlert.addObserver(observer2);
        notificationAlert.addObserver(observer3);

        notificationAlert.setData(10);

    }
}