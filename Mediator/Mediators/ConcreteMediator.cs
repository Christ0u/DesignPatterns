namespace _Mediator.Mediators
{
    class ConcreteMediator : Mediator
    {
        public override void Send(User fromUser, User toUser, string message)
        {
            if (this._users.Count() == 0)
            {
                return;
            }
            else if (this._users.Contains(toUser))
            {
                Console.WriteLine("Envoi du message '" + message + "' à '" + toUser.userName + "' de '" + fromUser.userName + "'\n");
            }
            else
            {
                Console.WriteLine("L'utilisateur '" + toUser.userName + "' n'existe pas");
            }
        }

        public override void Send(User fromUser, string message)
        {
            if (this._users.Count() == 0)
            {
                return;
            }
            else
            {

                foreach (User user in this._users)
                {
                    Console.WriteLine("Envoi du message '" + message + "' à " + "'" + user.userName + "' de '" + fromUser.userName + "'");
                }
            }
        }
    }
}