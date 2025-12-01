namespace Observer.Observers
{
    public class AlertTemperature : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            if (temperature > 30.0f)
            {
                Console.WriteLine("ALERTE CANICULE! LA TEMPERATURE EST DE " + temperature + "°C\n");
            }
        }
    }
}