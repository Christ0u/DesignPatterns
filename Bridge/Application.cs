using Bridge.API;
using Bridge.App;

namespace Bridge
{
    class Application
    {
        void Main()
        {
            // Exemple 1
            BankApp bankApp = new BankApp();
            bankApp.SendAPI = new SMS();

            bankApp.Send();

            // Exemple 2
            ShopApp shopApp = new ShopApp();
            shopApp.SendAPI = new Push();

            shopApp.Send();
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}
