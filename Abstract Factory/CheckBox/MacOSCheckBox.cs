namespace Abstract_Factory.CheckBox
{
    class MacOSCheckBox : ICheckBox
    {
        public void Toggle()
        {
            Console.WriteLine("Checkbox MacOS cochée / décochée !");
        }
    }
}
