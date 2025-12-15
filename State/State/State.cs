namespace StateDesignPattern.State
{
    public interface IState
    {
        abstract void DoAction(Context context);
    }
}