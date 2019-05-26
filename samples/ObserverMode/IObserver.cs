using System;

namespace ObserverMode
{
    public interface IObserver<T>
    {
        void Update(object sender, T e);
    }
}