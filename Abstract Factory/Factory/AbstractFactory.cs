using Abstract_Factory.Button;
using Abstract_Factory.CheckBox;

namespace Abstract_Factory.Factory
{
    // Interface abstraite
    public interface IAbstractFactory
    {
        abstract IButton CreateButton();
        abstract ICheckBox CreateCheckBox();
    }
}
