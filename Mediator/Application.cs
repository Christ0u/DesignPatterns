using _Mediator.Mediators;

namespace _Mediator
{
    class Application
    {
        public void Main()
        {
            Mediator mediator = new ConcreteMediator();

            User user1 = new User("Christopher", "GERARD", "christopher.gerard", mediator);
            User user2 = new User("Quentin", "BRENNER", "quentin.brenner", mediator);
            User user3 = new User("Océane", "DRUENNE", "oceanne.druenne", mediator);

            mediator._users = new List<User>();

            mediator._users.Add(user1);
            mediator._users.Add(user2);
            mediator._users.Add(user3);

            user1.Send(user2, "Viens on fait du vélo!");
            user2.Send("Hello World!");
        }

        // Programme principal
        static void Main(string[] args)
        {
            Application application = new Application();
            application.Main();
        }
    }
}