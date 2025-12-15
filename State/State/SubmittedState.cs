namespace StateDesignPattern.State
{
    public class SubmittedState : IState
    {
        public void DoAction(Context context)
        {
            // Code métier
            Console.WriteLine("Soumis");

            context.SetState(this);
        }
    }
}