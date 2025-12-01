using Observer.Observers;

namespace Observer
{
    class Application
    {
        public void Main()
        {
            // Initialisation des observeurs
            DisplayWeather observer1 = new DisplayWeather();
            AlertTemperature observer2 = new AlertTemperature();

            // Initialisation de l'observable
            WeatherStation weatherStation = new WeatherStation();
            weatherStation.Subscribe(observer1);
            weatherStation.Subscribe(observer2);

            weatherStation.SetMesures(30.1f, 78.9f, 1024.0f);

            weatherStation.Notify();
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}