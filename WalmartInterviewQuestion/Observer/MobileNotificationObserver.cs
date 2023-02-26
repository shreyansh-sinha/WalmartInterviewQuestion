using WalmartInterviewQuestion.Observable;

namespace WalmartInterviewQuestion.Observer
{
    internal class MobileNotificationObserver : INotificationObserver
    {
        private readonly INotificationAlert notificationAlert;
        private string userName;
        public MobileNotificationObserver(INotificationAlert notificationAlert, string userName)
        {
            this.notificationAlert = notificationAlert;
            this.userName = userName;
        }

        public void update()
        {
            sendMessage();
        }

        private void sendMessage()
        {
            Console.WriteLine($"Message sent to {userName}");
        }
    }
}
