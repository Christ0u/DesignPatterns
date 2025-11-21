namespace Abstract_Factory.Button
{
    class MacOSButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Bouton MacOS cliqué !");
        }
    }
}
