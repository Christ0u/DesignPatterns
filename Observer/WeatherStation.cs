using Observer.Observers;

namespace Observer
{
    public class WeatherStation
    {
        private List<IObserver> observers = [];

        private float temperature = 0.0f;
        private float humidity = 0.0f;
        private float pressure = 0.0f;

        // Méthodes
        public void Subscribe(IObserver observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach(IObserver observer in this.observers)
            {
                observer.Update(this.temperature, this.humidity, this.pressure);
            }
        }

        public void SetMesures(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}