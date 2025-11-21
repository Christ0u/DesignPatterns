using Abstract_Factory.Button;
using Abstract_Factory.CheckBox;
using Abstract_Factory.Factory;

namespace Abstract_Factory
{
    public class Application
    {
        private IAbstractFactory factory;

        private IButton button;
        private ICheckBox checkBox;

        // Constructeur
        public Application(IAbstractFactory factory)
        {
            this.factory = factory;

            this.CreateUI();
            this.OnClick();
            this.Toggle();
        }

        public void CreateUI()
        {
            this.button = this.factory.CreateButton();
            this.checkBox = this.factory.CreateCheckBox();
        }

        public void OnClick()
        {
            this.button.OnClick();
        }

        public void Toggle()
        {
            this.checkBox.Toggle();
        }
    }
}
