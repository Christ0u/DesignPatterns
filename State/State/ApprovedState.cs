namespace StateDesignPattern.State
{
    public class ApprovedState : IState
    {
        public void DoAction(Context context)
        {
            // Code métier
            Console.WriteLine("Approuvé");

            context.SetState(this);
        }
    }
}