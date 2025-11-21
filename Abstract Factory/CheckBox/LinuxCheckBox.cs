using Abstract_Factory.Button;

namespace Abstract_Factory.CheckBox
{
    class LinuxCheckBox : ICheckBox
    {
        public void Toggle()
        {
            Console.WriteLine("Checkbox Linux cochée / décochée !");
        }
    }
}
