using WalmartInterviewQuestion.Observer;

namespace WalmartInterviewQuestion.Observable
{
    internal interface INotificationAlert
    {
        public void addObserver(INotificationObserver observer);
        public void removeObserver(INotificationObserver observer);
        public void notifyObservers();
        public void setData(int data);

    }
}
