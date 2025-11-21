using Factory_Method.Transport;

namespace Factory_Method.Factory
{
    class BikeFactory : TransportFactory
    {
       public override ITransport createTransport()
       {
            return new Bike();
       }
    }
}
