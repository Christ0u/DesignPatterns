using Abstract_Factory.Button;
using Abstract_Factory.CheckBox;

namespace Abstract_Factory.Factory
{
    class LinuxFactory : IAbstractFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new LinuxCheckBox();
        }
    }
}
