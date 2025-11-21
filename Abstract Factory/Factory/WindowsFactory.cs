using Abstract_Factory.Button;
using Abstract_Factory.CheckBox;

namespace Abstract_Factory.Factory
{
    class WindowsFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
