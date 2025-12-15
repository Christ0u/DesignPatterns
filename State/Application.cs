using StateDesignPattern.State;

namespace StateDesignPattern
{
    public class Application
    {
        public void Main()
        {
            IState firstState = new DraftState();
            IState secondState = new ApprovedState();

            Context context = new Context(firstState);

            context.GetState();
            context.SetState(secondState);
            context.GetState();
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}