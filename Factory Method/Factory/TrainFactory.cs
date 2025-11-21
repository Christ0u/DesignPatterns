using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    class TrainFactory : TransportFactory
    {
        public override ITransport createTransport()
        {
            return new Train();
        }
    }
}