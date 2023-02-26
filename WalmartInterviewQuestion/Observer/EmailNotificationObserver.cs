using WalmartInterviewQuestion.Observable;

namespace WalmartInterviewQuestion.Observer
{
    internal class EmailNotificationObserver : INotificationObserver
    {
        private INotificationAlert notificationAlert;
        private string emailId;

        public EmailNotificationObserver(INotificationAlert notificationAlert, string emailId)
        {
            this.notificationAlert = notificationAlert;
            this.emailId = emailId;
        }

        public void update()
        {
            sendEmail();
        }

        private void sendEmail()
        {
            Console.WriteLine($"Message sent to {emailId}");
        }
    }
}
