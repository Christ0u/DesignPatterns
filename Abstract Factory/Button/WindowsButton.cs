namespace Abstract_Factory.Button
{
    class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Bouton Windows cliqué !");
        }
    }
}
