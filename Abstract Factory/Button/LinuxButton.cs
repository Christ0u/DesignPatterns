namespace Abstract_Factory.Button
{
    class LinuxButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Bouton Linux cliqué !");
        }
    }
}
