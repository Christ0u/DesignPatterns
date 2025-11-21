using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    // Factory abstraite
    abstract class TransportFactory
    {
        public abstract ITransport createTransport();
    }
}
