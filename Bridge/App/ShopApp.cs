namespace Bridge.App
{
    class ShopApp : App
    {
        public override void Send()
        {
            SendAPI.SendMessage();
        }
    }
}
