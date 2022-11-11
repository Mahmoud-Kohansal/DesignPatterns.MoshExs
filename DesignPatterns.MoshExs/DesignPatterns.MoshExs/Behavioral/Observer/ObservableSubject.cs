
namespace DesignPatterns.MoshExs.Behavioral.Observer
{
    public class ObservableSubject
    {
        private List<IObserver> _Observers = new();
        public void AddObserver(IObserver observer)
        {
            _Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _Observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in _Observers)
            {
                observer.Update();
            }
        }
    }
}
