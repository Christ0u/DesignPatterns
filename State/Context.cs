using StateDesignPattern.State;

namespace StateDesignPattern
{
    public class Context
    {
        private IState _state;

        // Constructeur
        public Context(IState state)
        {
            this._state = state;
        }

        // Méthodes
        public void GetState()
        {
            Console.WriteLine($"L'état courant vaut {_state}");
        }

        public void SetState(IState state)
        {
            this._state = state;
        }
    }
}