namespace _Mediator.Mediators
{
    abstract class Mediator
    {
        public List<User> _users = new List<User>();

        public abstract void Send(User fromUser, User toUser, string message);
        public abstract void Send(User fromUser, string message);
    }
}