namespace Factory_Method.Transport
{
    class Bike : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Le vélo transporte par piste cyclable.");
        }
    }
}
