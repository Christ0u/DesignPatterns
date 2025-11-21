namespace Bridge.App
{
    class BankApp : App
    {
        public override void Send()
        {
            SendAPI.SendMessage();
        }
    }
}
