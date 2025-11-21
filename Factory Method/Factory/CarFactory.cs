using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    class CarFactory : TransportFactory
    {
        public override ITransport createTransport()
        {
            return new Car();
        }
    }
}
