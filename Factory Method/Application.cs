using Factory_Method.Factory;

namespace Factory_Method
{
    public class Application
    {
        private TransportFactory factory;

        private void Initialize()
        {
            // Saisie utilisateur
            Console.WriteLine("Saisissez le transport souhaité : ");
            string transportInput = Console.ReadLine();

            switch (transportInput.ToLowerInvariant())
            {
                case "bike":
                    this.factory = new BikeFactory();

                    break;

                case "car":
                    this.factory = new CarFactory();

                    break;

                case "train":
                    this.factory = new TrainFactory();

                    break;

                default:
                    throw new Exception("Transport non pris en charge.");
            }
        }

        public void Main()
        {
            this.Initialize();

            Transport.ITransport transport = this.factory.createTransport();
            transport.Deliver();
        }

        // Programme principal
        static void Main( string[] args )
        {
            Application application = new Application();
            application.Main();
        }
    }
}