namespace StateDesignPattern.State
{
    public class DraftState : IState
    {
        public void DoAction(Context context)
        {
            // Code métier
            Console.WriteLine("Brouillon");

            context.SetState(this);
        }
    }
}