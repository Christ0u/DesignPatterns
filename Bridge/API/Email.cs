namespace Bridge.API
{
    class Email : ISendAPI
    {
        public void SendMessage()
        {
            Console.WriteLine("Message envoyé par Email.");
        }
    }
}
