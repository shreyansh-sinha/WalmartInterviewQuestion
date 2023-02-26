using WalmartInterviewQuestion.Observer;

namespace WalmartInterviewQuestion.Observable
{
    internal class NotificationAlert : INotificationAlert
    {
        private List<INotificationObserver> notificationObservers = new();
        int stockCount = 0;
        public void addObserver(INotificationObserver observer)
        {
            notificationObservers.Add(observer);
        }

        public void notifyObservers()
        {
            foreach (var obj in notificationObservers)
                obj.update();
        }

        public void removeObserver(INotificationObserver observer)
        {
            notificationObservers.Remove(observer);
        }

        public void setData(int newStockCount)
        {
            if (stockCount == 0)
                notifyObservers();

            stockCount += newStockCount;
        }
    }
}
