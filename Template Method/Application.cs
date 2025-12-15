using TemplateMethodDesignPattern.Workers;

namespace TemplateMethodDesignPattern
{
    public class Application
    {
        public void Main()
        {
            Worker firstWorker = new FireFighter();
            firstWorker.DailyRoutine();

            Worker secondeWorker = new Postman();
            secondeWorker.DailyRoutine();
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }

}