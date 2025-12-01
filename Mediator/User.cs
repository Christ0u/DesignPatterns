using _Mediator.Mediators;

namespace _Mediator
{
    class User
    {
        public string firstName;
        public string lastName;
        public string userName;
        public Mediator mediator;

        // Constructeur
        public User(string firstName, string lastName, string userName, Mediator mediator)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.mediator = mediator;
        }

        // Méthodes
        public void Send(User user, string message)
        {
            mediator.Send(this, user, message);
        }

        public void Send(string message)
        {
            mediator.Send(this, message);
        }
    }
}