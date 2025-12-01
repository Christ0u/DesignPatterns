namespace Observer.Observers
{
    // Interface abstraite
    public interface IObserver
    {
        public abstract void Update(float temperature, float humidity, float pressure);
    }
}