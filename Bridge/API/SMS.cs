namespace Bridge.API
{
    class SMS : ISendAPI
    {
        public void SendMessage()
        {
            Console.WriteLine("Message envoyé par SMS.");
        }
    }
}
