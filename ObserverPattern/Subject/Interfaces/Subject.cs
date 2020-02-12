using ObserverPattern.Observers.Interfaces;

namespace ObserverPattern.Subject.Interfaces
{
    public interface ISubject
    {
        void registerObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyAllObservers();
    }
}
