namespace Observer.Observers
{
    public class DisplayWeather : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine("BULLETIN METEO :\n\n");

            Console.WriteLine("\t- Température : " + temperature + "°C\n");
            Console.WriteLine("\t- Humidité    : " + humidity + "%\n");
            Console.WriteLine("\t- Pression    : " + pressure + "hPa\n");
        }
    }
}