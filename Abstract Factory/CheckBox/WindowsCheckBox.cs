namespace Abstract_Factory.CheckBox
{
    class WindowsCheckBox : ICheckBox
    {
        public void Toggle()
        {
            Console.WriteLine("Checkbox Windows cochée / décochée !");
        }
    }
}
