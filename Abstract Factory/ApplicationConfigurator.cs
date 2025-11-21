using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    class ApplicationConfigurator
    {
        private IAbstractFactory factory;

        public void Initialize()
        {
            // Saisie utilisateur
            Console.WriteLine("Saisissez l'environnement souhaité : ");
            string environmentInput = Console.ReadLine();

            switch (environmentInput.ToLowerInvariant())
            {
                case "windows":
                    this.factory = new WindowsFactory();

                    break;

                case "linux":
                    this.factory = new LinuxFactory();

                    break;

                case "macos":
                    this.factory = new MacOSFactory();

                    break;

                default:
                    throw new Exception("Environnement non pris en charge.");
            }

            Application application = new(factory);
        }

        // Programme principal
        static void Main(string[] args)
        {
            ApplicationConfigurator applicationConfigurator = new ApplicationConfigurator();
            applicationConfigurator.Initialize();
        }
    }
}
