namespace StateDesignPattern.State
{
    public class RejectedState : IState
    {
        public void DoAction(Context context)
        {
            // Code métier
            Console.WriteLine("Rejeté");

            context.SetState(this);
        }
    }
}