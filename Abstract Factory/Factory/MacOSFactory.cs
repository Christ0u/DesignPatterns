using Abstract_Factory.Button;
using Abstract_Factory.CheckBox;

namespace Abstract_Factory.Factory
{
    class MacOSFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckBox();
        }
    }
}
