namespace Bridge.API
{
    class Push : ISendAPI
    {
        public void SendMessage()
        {
            Console.WriteLine("Message envoyé par Push.");
        }
    }
}
