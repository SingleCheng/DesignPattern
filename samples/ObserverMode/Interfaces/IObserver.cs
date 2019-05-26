namespace ObserverMode.Interfaces
{
    public interface IObserver<T>
    {
        void Update(object sender, T e);
    }
}